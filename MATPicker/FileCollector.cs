namespace MATPicker
{
    using System.Collections.Generic;
    using System.IO;

    internal class FileCollector
    {
        public static void CollectFilesForExport(HashSet<string> filePaths)
        {
            foreach (var filePath in filePaths)
            {
                GetFile(filePath);
            }
        }

        private static void GetFile(string filePath)
        {
            string correctedFilePath = filePath.Replace("/", @"\");
            string relativePath = Path.GetDirectoryName(correctedFilePath);
            string tryModFolder = Config.ModFolder + correctedFilePath;
            string destFile = Config.ExportFolder + correctedFilePath;

            if (File.Exists(tryModFolder))
            {
                Directory.CreateDirectory(Config.ExportFolder + relativePath);
                File.Copy(tryModFolder, destFile, true);
                Log.AppendPicked(filePath);
            }
            else
            {
                TryBaseFolders(correctedFilePath, relativePath, destFile, filePath);
            }
        }

        private static void TryBaseFolders(string correctedFilePath, string relativePath, string destFile, string filePath)
        {
            foreach (string baseFolder in Config.BaseFolders)
            {
                string tryBaseFolder = baseFolder + correctedFilePath;
                if (File.Exists(tryBaseFolder))
                {
                    Directory.CreateDirectory(Config.ExportFolder + relativePath);
                    File.Copy(tryBaseFolder, destFile, true);
                    Log.AppendPicked(filePath);
                    return;
                }
            }
            Log.AppendMissing(filePath);
            if (Config.ExportEmptyFolders)
            {
                Directory.CreateDirectory(Config.ExportFolder + relativePath);
            }
        }
    }
}
