using System;
using System.Collections.Generic;

namespace MATPicker
{
    class Config
    {
        public static string ModFolder { get; set; }
        public static bool SingleFile { get; set; } = false;
        public static string OpenedFile { get; set; }
        public static string BaseFolder { get; set; }
        public static string ExportFolder { get; set; }
        public static bool PickMatFiles { get; set; } = true;
        public static bool PickTobjFiles { get; set; } = false;
        public static bool PickDdsFiles { get; set; } = false;
        public static bool PickModelFiles { get; set; } = false;
    }
}
