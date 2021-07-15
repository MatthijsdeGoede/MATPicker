using System;
using System.Collections.Generic;
using System.IO;

namespace MATPicker
{
    class FileCollector
    {
        public static void CollectFilesForExport(HashSet<string> filePaths)
        {
            foreach (var filePath in filePaths)
            {
                getFile(filePath);
            }
        }

        private static void getFile(string filePath)
        {
            string correctedFilePath = filePath.Replace("/", @"\");
            string relativePath = Path.GetDirectoryName(correctedFilePath);

            string tryModFolder = Config.ModFolder + correctedFilePath;
            string tryBaseFolder = Config.BaseFolder + correctedFilePath;
            string destFile = Config.ExportFolder + correctedFilePath;

            if (File.Exists(tryModFolder))
            {
                Directory.CreateDirectory(Config.ExportFolder + relativePath);
                File.Copy(tryModFolder, destFile, true);
                Log.AppendPicked(filePath);
            }
            else if (File.Exists(tryBaseFolder))
            {
                Directory.CreateDirectory(Config.ExportFolder + relativePath);
                File.Copy(tryBaseFolder, destFile, true);
                Log.AppendPicked(filePath);
            }
            else
            {
                Log.AppendMissing(filePath);
                if (Config.ExportEmptyFolders) 
                {
                    Directory.CreateDirectory(Config.ExportFolder + relativePath);
                }
            }
        }
    }
}
