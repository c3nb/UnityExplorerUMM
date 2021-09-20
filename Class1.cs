using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityModManagerNet;

namespace UnityExplorer
{
    public class Main
    {
        public static bool Load(UnityModManager.ModEntry modEntry) { ExplorerStandalone.CreateInstance(); return true; }
    }
}
