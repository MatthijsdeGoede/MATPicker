namespace MATPicker
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Text.RegularExpressions;

    internal class FileParser
    {
        public static HashSet<string> CollectFiles(string extension, string fileToSearchIn)
        {
            HashSet<string> files = new HashSet<string>();
            string correctedPath = CorrectFilePath(fileToSearchIn);
            string tryModFolder = Config.ModFolder + correctedPath;

            if (File.Exists(tryModFolder))
            {
                RetrieveFilesFromFile(extension, tryModFolder, files);
            }
            else
            {
                TryBaseFolders(correctedPath, extension, files, fileToSearchIn);
            }
            return files;
        }

        private static void TryBaseFolders(string correctedPath, string extension, HashSet<string> files, string fileToSearchIn)
        {
            foreach (string baseFolder in Config.BaseFolders)
            {
                string tryBaseFolder = baseFolder + correctedPath;
                if (File.Exists(tryBaseFolder))
                {
                    RetrieveFilesFromFile(extension, tryBaseFolder, files);
                    return;
                }
            }
            Log.AppendMissing(fileToSearchIn);
        }

        private static void RetrieveFilesFromFile(string extension, string filePath, HashSet<string> files)
        {
            string text = File.ReadAllText(filePath);
            Regex ItemRegex = new Regex(@"(\/)([a-zA-Z0-9_.\/]+?)(\" + extension + ")", RegexOptions.Compiled);

            foreach (Match ItemMatch in ItemRegex.Matches(text))
            {
                files.Add(ItemMatch.Value);
            }
        }

        public static HashSet<string> CollectModelFiles(string pmdFile)
        {
            HashSet<string> modelFiles = new HashSet<string>();
            AddModelFileIfFound(pmdFile, modelFiles, ".pmd");
            AddModelFileIfFound(pmdFile, modelFiles, ".pmg");
            AddModelFileIfFound(pmdFile, modelFiles, ".pmc");
            return modelFiles;
        }

        private static void AddModelFileIfFound(string pmdFile, HashSet<string> modelFiles, string fileExtension)
        {
            string filePath = pmdFile.Substring(0, pmdFile.LastIndexOf(".")) + fileExtension;
            string searchPath = Config.ModFolder + CorrectFilePath(filePath);
            Debug.Print(searchPath);
            if (File.Exists(searchPath))
            {
                modelFiles.Add(filePath.Replace(@"\", "/"));
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
            foreach (var matFile in matFiles)
            {
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
                if (tobjFile != null)
                {
                    ddsFiles.UnionWith(CollectFiles(".dds", tobjFile));
                }
            }
            return ddsFiles;
        }

        public static string CorrectFilePath(string filePath)
        {
            return filePath.Replace("/", @"\");
        }
    }
}
