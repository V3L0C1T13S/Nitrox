using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using NitroxModel.Discovery;
using NitroxModel.Platforms.Store;

namespace NitroxCLI
{
    internal class CLIConfig
    {
        private Platform subnauticaPlatform = Platform.NONE;
        private string subnauticaPath = string.Empty;
        public string SubnauticaPath
        {
            get => subnauticaPath;
            set
            {
                // Ensures the path looks alright (no mixed / and \ path separators)
                subnauticaPath = Path.GetFullPath(value);
                subnauticaPlatform = GamePlatforms.GetPlatformByGameDir(subnauticaPath)?.platform ?? Platform.NONE;
            }
        }
    }
}