using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclarationsLibrary
{
    public class JsonCompressionHelper
    {
        public static string Compress(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            MemoryStream ms = new MemoryStream();
            using (GZipStream zip = new GZipStream(ms, CompressionMode.Compress)) {
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
            try
            {
                using (MemoryStream msi = new
                MemoryStream(Convert.FromBase64String(compressedString)))
                using (MemoryStream mso = new MemoryStream())
                {
                    using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                    {
                        await gs.CopyToAsync(mso);
                    }
                    return Encoding.UTF8.GetString(mso.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
