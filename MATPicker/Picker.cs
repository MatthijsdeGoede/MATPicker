namespace MATPicker
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;

    public class Picker
    {
        public static void Pick()
        {
            HashSet<string> materialFiles = new HashSet<string>();
            HashSet<string> tobjFiles = new HashSet<string>();
            HashSet<string> ddsFiles = new HashSet<string>();
            HashSet<string> modelFiles = new HashSet<string>();
            string[] filesToPickFor = Config.SingleFile ? new string[] { Config.OpenedFile } : Directory.GetFiles(Config.OpenedFile, "*.pmd", SearchOption.AllDirectories);

            foreach (var file in filesToPickFor)
            {
                string relativeFilePath = $"\\{Path.GetRelativePath(Config.ModFolder, file)}";
                HashSet<string> materialFilesFromSinglePmd = FileParser.CollectMaterials(relativeFilePath);
                HashSet<string> tobjFilesFromMats = FileParser.CollectTobjs(materialFilesFromSinglePmd);
                if (Config.PickMatFiles)
                {
                    materialFiles.UnionWith(materialFilesFromSinglePmd);
                }
                if (Config.PickTobjFiles)
                {
                    tobjFiles.UnionWith(tobjFilesFromMats);
                }
                if (Config.PickDdsFiles)
                {
                    HashSet<string> ddsFilesFromTobjs = FileParser.CollectDdsFiles(tobjFilesFromMats);
                    ddsFiles.UnionWith(ddsFilesFromTobjs);
                }
                if (Config.PickModelFiles)
                {
                    modelFiles.UnionWith(FileParser.CollectModelFiles(relativeFilePath));
                }
            }

            FileCollector.CollectFilesForExport(materialFiles);
            FileCollector.CollectFilesForExport(tobjFiles);
            FileCollector.CollectFilesForExport(ddsFiles);
            FileCollector.CollectFilesForExport(modelFiles);
        }
    }
}
