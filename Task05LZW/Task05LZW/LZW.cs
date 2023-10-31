namespace Task05LZW;

public class LZW
{
    private static readonly int[] byteLengthBarrier = { 0, 256, 256 * 256, 256 * 256 * 256 };

    private static List<byte> ToBytes(uint value, int minLengthInBytes)
    {
        byte[] bytes = BitConverter.GetBytes(value);
        var result = new List<byte>();

        for (int j = 0; j < byteLengthBarrier.Length; j++)
            if (value >= byteLengthBarrier[j])
                result.Add(bytes[j]);

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

    public static byte[] Compress(byte[] inputBytes)
    {   
        var compressedBytesList = new List<byte>();
        var trie = new ByteTrie();
        var currentCode = new List<byte>();
        int idMinLengthInBytes = 1;
        for (int i = 0; i < inputBytes.Length; i++)
        {
            currentCode.Add(inputBytes[i]);

            if (i == inputBytes.Length - 1)
            {
                currentCode.RemoveAt(currentCode.Count - 1);
                compressedBytesList.AddRange(ToBytes(trie.Contains(currentCode.ToArray()), idMinLengthInBytes));
                compressedBytesList.Add(inputBytes[i]);
                break;
            }

            if (trie.Contains(currentCode.ToArray()) == 0)
            {
                uint id = trie.Add(currentCode.ToArray());
                currentCode.RemoveAt(currentCode.Count - 1);
                uint writedId = trie.Contains(currentCode.ToArray());
                compressedBytesList.AddRange(ToBytes(writedId, idMinLengthInBytes));
                compressedBytesList.Add(inputBytes[i]);
                currentCode.Clear();
                
                for (int j = 1; j < byteLengthBarrier.Length; j++)
                    if (id == byteLengthBarrier[j] - 1)
                        idMinLengthInBytes = int.Max(idMinLengthInBytes, j + 1);
            }
        }

        return compressedBytesList.ToArray();
    }

    public static byte[] Decompress(byte[] compressedBytes)
    {
        var decompressedBytesList = new List<byte>();
        var codes = new List<List<byte>>();
        codes.Add(new List<byte>());
        int idMinLengthInBytes = 1;

        for (int i = 0; i < compressedBytes.Length; i++)
        {
            var idList = new List<byte>();
            for (int j = 0; j < idMinLengthInBytes; j++)
                idList.Add(compressedBytes[i + j]);
            uint id = ToUint(idList);
            i += idMinLengthInBytes;

            var letter = compressedBytes[i];
            codes.Add(new List<byte>());
            codes[codes.Count - 1].AddRange(codes[(int)id]);
            codes[codes.Count - 1].Add(letter);
            decompressedBytesList.AddRange(codes[codes.Count - 1]);

            for (int j = 1; j < byteLengthBarrier.Length; j++)
                if (codes.Count == byteLengthBarrier[j])
                    idMinLengthInBytes = int.Max(idMinLengthInBytes, j + 1);
        }

        return decompressedBytesList.ToArray();
    }
}
