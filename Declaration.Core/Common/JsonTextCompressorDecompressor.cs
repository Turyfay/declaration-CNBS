using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.Core.Common
{
    public class JsonTextDeclarationHelpe
    {
        public static string Compress(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            MemoryStream ms = new MemoryStream();
            using (GZipStream zip = new GZipStream(ms, CompressionMode.Compress, true))
            {
                zip.Write(buffer, 0, buffer.Length);
            }
            ms.Position = 0;
            MemoryStream outStream = new MemoryStream();
            byte[] compressed = new byte[ms.Length];
            ms.Read(compressed, 0, compressed.Length);
            return Convert.ToBase64String(compressed);
        }

        public static async System.Threading.Tasks.Task<string> DecompressAsync(string compressedString)
        {
            if (string.IsNullOrEmpty(compressedString))
            {
                throw new ArgumentException("The compressed string cannot be null or empty.", nameof(compressedString));
            }

            byte[] compressedBytes = Convert.FromBase64String(compressedString);

            using (var msi = new MemoryStream(compressedBytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    await gs.CopyToAsync(mso, 81920); // Use a buffer size of 80 KB
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }

        }
    }
}
