using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace TaleWorlds.EconomyExpanded
{
    public class EconomyExpandedSubModule : MBSubModuleBase
    {
    
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            new Harmony("EconomyExpanded.Patches").PatchAll();
        }


    }
}
