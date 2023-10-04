namespace Task_05_LZW
{
    class Program
    {
        static string CompressFile(string filePath)
        {
            byte[] inputFileBytes = File.ReadAllBytes(filePath);
            byte[] outputFileBytes = LZW.Compress(inputFileBytes);
            var ratio = Convert.ToDouble(inputFileBytes.Length) / outputFileBytes.Length;

            string compressedFilePath = filePath + ".zipped";
            File.WriteAllBytes(compressedFilePath, outputFileBytes);

            Console.WriteLine($"Ratio: {ratio}\nOutput path: {compressedFilePath}");
            return compressedFilePath;
        }

        static string DecompressFile(string compressedFilePath)
        {
            byte[] compressedFileBytes = File.ReadAllBytes(compressedFilePath);
            byte[] decompressedFileBytes = LZW.Decompress(compressedFileBytes);
            var ratio = Convert.ToDouble(compressedFileBytes.Length) / decompressedFileBytes.Length;

            string decompressedFilePath = compressedFilePath.Substring(0, compressedFilePath.Length - ".zipped".Length);
            File.WriteAllBytes(decompressedFilePath, decompressedFileBytes);
            
            Console.WriteLine($"Ratio: {ratio}\nOutput path: {decompressedFilePath}");

            return decompressedFilePath;
        }

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Invalid number of command line arguments.");
                return;
            }

            string filePath = Path.GetFullPath(args[0]);
            if (!File.Exists(filePath)) {
                Console.WriteLine($"File {filePath} does not exist.");
                return;
            }

            string option = args[1];

            switch (option)
            {
                case "-c":
                    CompressFile(filePath);
                    break;
                case "-u":
                    DecompressFile(filePath);
                    break;
                default:
                    Console.WriteLine($"Invalid option: {option}. Available options: -c, -u");
                    return;
            }
        }
    }
}
