using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_LZW
{
    public class LZW
    {
        public static string Compress(string filePath, ref double ratio)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            string compressedFilePath = filePath + ".zipped";
            File.WriteAllBytes(compressedFilePath, fileBytes);

            ratio = fileBytes.Length / fileBytes.Length;
            return compressedFilePath;
        }
        public static string Decompress(string compressedFilePath, ref double ratio)
        {
            byte[] fileBytes = File.ReadAllBytes(compressedFilePath);
            string decompressedFilePath = Path.GetFileNameWithoutExtension(compressedFilePath);
            File.WriteAllBytes(decompressedFilePath, fileBytes);

            ratio = fileBytes.Length / fileBytes.Length;
            return decompressedFilePath;
        }
    }
}
