using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Managers;

namespace MTMod
{
    public class SubtypeHybrid
    {
        public static readonly string Key = "Hybrid_Subtype_Hybrid";

        public static void BuildAndRegister()
        {
            CustomCharacterManager.RegisterSubtype(Key, "Hybrid");
        }
    }
}
