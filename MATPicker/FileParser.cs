using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace MATPicker
{
    class FileParser
    {
        public static HashSet<string> CollectFiles(string extension, string fileToSearchIn) {
            HashSet<string> files = new HashSet<string>();

            string text = File.ReadAllText(fileToSearchIn);

            Regex ItemRegex = new Regex(@"(\/)([a-zA-Z0-9_.\/]+?)(\" + extension + ")", RegexOptions.Compiled);

            foreach (Match ItemMatch in ItemRegex.Matches(text))
            {
                files.Add(ItemMatch.Value);
            }

            return files;
        }

        public static HashSet<string> CollectMaterials(string filename)
        {
            if (Path.GetExtension(filename) != ".pmd")
            {
                Log.AppendError($"Given file: {Path.GetFileName(filename)} is not a .pmd file and cannot be processed!");
            }

            return CollectFiles(".mat", filename);
        }

        public static HashSet<string> CollectTobjs(HashSet<string> matFiles)
        {
            HashSet<string> tobjFiles = new HashSet<string>();
            foreach (var matFile in matFiles) {
                
                string filePath = correctFilePath(matFile);
                if (filePath != null)
                {
                    tobjFiles.UnionWith(CollectFiles(".tobj", filePath));
                }
            } 
            return tobjFiles;
        }

        public static HashSet<string> CollectDdsFiles(HashSet<string> tobjFiles)
        {
            HashSet<string> ddsFiles = new HashSet<string>();
            foreach (var tobjFile in tobjFiles)
            {
                string filePath = correctFilePath(tobjFile);
                if (filePath != null) {
                    ddsFiles.UnionWith(CollectFiles(".dds", filePath));
                }                
            }
            return ddsFiles;
        }

        public static string correctFilePath(string filePath) {
            filePath = filePath.Replace("/", @"\");
            return Config.ModFolder + filePath;
        }

    }
}
