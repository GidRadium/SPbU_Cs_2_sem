﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_LZW
{
    public class LZW
    {
        private static List<byte> ToBytes(uint value, int minLengthInBytes)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            var result = new List<byte>();
            if (value >= 0)
                result.Add(bytes[0]);
            if (value >= 256)
                result.Add(bytes[1]);
            if (value >= 256 * 256)
                result.Add(bytes[2]);
            if (value >= 256 * 256 * 256)
                result.Add(bytes[3]);
            while (result.Count < minLengthInBytes)
                result.Add(0);
            return result;
        }

        private static uint ToUint(List<byte> bytes)
        {
            uint result = 0;
            uint ratio = 1;
            for (int i = 0; i < bytes.Count; i++)
            {
                result += (uint)((bytes[i])) * ratio;
                ratio *= 256;
            }

            return result;
        }

        public static string Compress(string filePath, ref double ratio)
        {
            byte[] inputFileBytes = File.ReadAllBytes(filePath);
            
            List<byte> compressedBytesList = new List<byte>();
            ByteTrie trie = new ByteTrie();
            List<byte> currentCode = new List<byte>();
            int idMinLengthInBytes = 1;
            for (int i = 0; i < inputFileBytes.Length; i++)
            {
                currentCode.Add(inputFileBytes[i]);

                if (i == inputFileBytes.Length - 1)
                {
                    currentCode.RemoveAt(currentCode.Count - 1);
                    compressedBytesList.AddRange(ToBytes(trie.Contains(currentCode.ToArray()), idMinLengthInBytes));
                    compressedBytesList.Add(inputFileBytes[i]);
                    break;
                }

                if (trie.Contains(currentCode.ToArray()) == 0)
                {
                    uint id = trie.Add(currentCode.ToArray());
                    currentCode.RemoveAt(currentCode.Count - 1);
                    uint writedId = trie.Contains(currentCode.ToArray());
                    compressedBytesList.AddRange(ToBytes(writedId, idMinLengthInBytes));
                    compressedBytesList.Add(inputFileBytes[i]);
                    currentCode.Clear();
                    
                    if (id == 255)
                        idMinLengthInBytes = int.Max(idMinLengthInBytes, 2);
                    if (id == 256 * 256 - 1)
                        idMinLengthInBytes = int.Max(idMinLengthInBytes, 3);
                    if (id == 256 * 256 * 256 - 1)
                        idMinLengthInBytes = int.Max(idMinLengthInBytes, 4);
                }
            }

            string compressedFilePath = filePath + ".zipped";
            File.WriteAllBytes(compressedFilePath, compressedBytesList.ToArray());
            ratio = Convert.ToDouble(inputFileBytes.Length) / compressedBytesList.Count;

            return compressedFilePath;
        }

        public static string Decompress(string compressedFilePath, ref double ratio)
        {
            byte[] compressedFileBytes = File.ReadAllBytes(compressedFilePath);
            
            var decompressedBytesList = new List<byte>();
            var codes = new List<List<byte>>();
            codes.Add(new List<byte>());
            int idMinLengthInBytes = 1;

            for (int i = 0; i < compressedFileBytes.Length; i++)
            {
                var idList = new List<byte>();
                for (int j = 0; j < idMinLengthInBytes; j++)
                    idList.Add(compressedFileBytes[i + j]);
                uint id = ToUint(idList);
                i += idMinLengthInBytes;

                var letter = compressedFileBytes[i];
                codes.Add(new List<byte>());
                codes[codes.Count - 1].AddRange(codes[(int)id]);
                codes[codes.Count - 1].Add(letter);
                decompressedBytesList.AddRange(codes[codes.Count - 1]);

                if (codes.Count == 256)
                    idMinLengthInBytes = int.Max(idMinLengthInBytes, 2);
                if (codes.Count == 256 * 256)
                    idMinLengthInBytes = int.Max(idMinLengthInBytes, 3);
                if (codes.Count == 256 * 256 * 256)
                    idMinLengthInBytes = int.Max(idMinLengthInBytes, 4);
            }

            string decompressedFilePath = compressedFilePath.Substring(0, compressedFilePath.Length - ".zipped".Length);
            File.WriteAllBytes(decompressedFilePath, decompressedBytesList.ToArray());
            ratio = Convert.ToDouble(decompressedBytesList.Count) / compressedFileBytes.Length;

            return decompressedFilePath;
        }
    }
}
