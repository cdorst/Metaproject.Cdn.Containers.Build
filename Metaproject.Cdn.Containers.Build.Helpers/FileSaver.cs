using DevOps.ContentDelivery.Structures.AzureBlob;
using static Metaproject.Cdn.Common.Helpers.CDorstCdnHelper;

namespace Metaproject.Cdn.Containers.Build.Helpers
{
    internal static class FileSaver
    {
        private const string Container = "build";

        public static void Save(string fileName, string destinationPath)
            => ExtractZip(
                new Blob(Container, fileName),
                destinationPath);
    }
}
