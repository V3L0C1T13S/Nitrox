using System;
using NitroxCLI.Models.Patching;

namespace NitroxCLI
{
    internal class CLILogic : IDisposable
    {
        private NitroxEntryPatch nitroxEntryPatch;

        public void Dispose()
        {
            Console.WriteLine("kill me");
        }
    }
}