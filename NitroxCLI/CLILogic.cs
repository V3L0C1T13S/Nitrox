using System;
using NitroxCLI;
using NitroxCLI.Models.Patching;

namespace NitroxCLI
{
    internal class CLILogic : IDisposable
    {
        private NitroxEntryPatch nitroxEntryPatch;

        private CLIConfig config;

        public CLILogic()
        {
            
        }

        public void BeginPatch()
        {
            if (nitroxEntryPatch.IsApplied)
            {
                Console.WriteLine("Nitrox patch already applied.");
                return;
            }

            Console.WriteLine("Applying Nitrox patch...");
            nitroxEntryPatch.Apply();
            Console.WriteLine("Nitrox patch applied.");
        }

        public void LaunchSubnautica() 
        {
            Console.WriteLine("Launching Subnautica...");
            //Process.Start(config.SubnauticaPath);
        }

        public void Dispose()
        {
            Console.WriteLine("kill me");
        }
    }
}