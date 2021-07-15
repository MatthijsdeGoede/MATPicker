using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace MATPicker
{
    class FileParser
    {
        public static HashSet<string> CollectFiles(string extension, string fileToSearchIn) {
            HashSet<string> files = new HashSet<string>();
            string correctedPath = correctFilePath(fileToSearchIn);
            string tryModFolder = Config.ModFolder + correctedPath;
            string tryBaseFolder = Config.BaseFolder + correctedPath;

            if (File.Exists(tryModFolder))
            {
                retrieveFilesFromFile(extension, tryModFolder, files);
            }
            else if (File.Exists(tryBaseFolder))
            {
                retrieveFilesFromFile(extension, tryBaseFolder, files);
            }
            else
            {
                Log.AppendMissing(fileToSearchIn);
            }
            return files;
        }

        private static void retrieveFilesFromFile(string extension, string filePath, HashSet<string> files)
        {
            string text = File.ReadAllText(filePath);
            Regex ItemRegex = new Regex(@"(\/)([a-zA-Z0-9_.\/]+?)(\" + extension + ")", RegexOptions.Compiled);

            foreach (Match ItemMatch in ItemRegex.Matches(text))
            {
                files.Add(ItemMatch.Value);
            }
        }

        internal static HashSet<string> CollectModelFiles(string pmdFile)
        {
            HashSet<string> modelFiles = new HashSet<string>();
            addModelFileIfFound(pmdFile, modelFiles, ".pmd");
            addModelFileIfFound(pmdFile, modelFiles, ".pmg");
            addModelFileIfFound(pmdFile, modelFiles, ".pmc");
            return modelFiles;
        }

        private static void addModelFileIfFound(string pmdFile, HashSet<string> modelFiles, string fileExtension)
        {
            string filePath = pmdFile.Substring(0, pmdFile.LastIndexOf(".")) + fileExtension;
            string searchPath = Config.ModFolder + correctFilePath(filePath);
            Debug.Print(searchPath);
            if (File.Exists(searchPath))
            {
                modelFiles.Add(filePath);
            }
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
                if (matFile != null)
                {
                    tobjFiles.UnionWith(CollectFiles(".tobj", matFile));
                }
            } 
            return tobjFiles;
        }

        public static HashSet<string> CollectDdsFiles(HashSet<string> tobjFiles)
        {
            HashSet<string> ddsFiles = new HashSet<string>();
            foreach (var tobjFile in tobjFiles)
            {
                if (tobjFile != null) {
                    ddsFiles.UnionWith(CollectFiles(".dds", tobjFile));
                }                
            }
            return ddsFiles;
        }

        public static string correctFilePath(string filePath) {
            return filePath.Replace("/", @"\");
        }

    }
}
