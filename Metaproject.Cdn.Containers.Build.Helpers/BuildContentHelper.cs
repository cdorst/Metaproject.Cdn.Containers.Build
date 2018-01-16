using static Metaproject.Cdn.Containers.Build.Helpers.ContentConstants;
using static Metaproject.Cdn.Containers.Build.Helpers.FileSaver;

namespace Metaproject.Cdn.Containers.Build.Helpers
{
    public static class BuildContentHelper
    {
        public static void SaveAppveyorYml(string destinationPath)
            => Save(AppveyorNugetBuild, destinationPath);

        public static void SaveNuGetConfig(string destinationPath)
            => Save(NugetConfig, destinationPath);
    }
}
