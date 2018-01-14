using DevOps.ContentDelivery.Structures.AzureBlob;
using static Metaproject.Cdn.Common.Helpers.CDorstCdnHelper;
using static Metaproject.Cdn.Containers.Build.Helpers.ContentConstants;

namespace Metaproject.Cdn.Containers.Build.Helpers
{
    public static class BuildContentHelpers
    {
        private const string Container = "build";

        public static void SaveGitAttributeIgnoreFiles(string destinationPath)
            => ExtractZip(
                new Blob(Container, AppveyorNugetBuild),
                destinationPath);
    }
}
