namespace Task_05_LZW
{
    class Program
    {
        static string CompressFile(string filePath)
        {
            byte[] inputFileBytes = File.ReadAllBytes(filePath);

            Console.WriteLine("Compressing data...");
            byte[] outputFileBytes = LZW.Compress(inputFileBytes);
            Console.WriteLine("Done!");

            var ratio = Convert.ToDouble(inputFileBytes.Length) / outputFileBytes.Length;

            string compressedFilePath = filePath + ".zipped";
            File.WriteAllBytes(compressedFilePath, outputFileBytes);

            Console.WriteLine($"Ratio: {ratio}\nOutput path: {compressedFilePath}");
            return compressedFilePath;
        }

        static string DecompressFile(string compressedFilePath)
        {
            byte[] compressedFileBytes = File.ReadAllBytes(compressedFilePath);

            Console.WriteLine("Decompressing data...");
            byte[] decompressedFileBytes = LZW.Decompress(compressedFileBytes);
            Console.WriteLine("Done!");

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
                Console.WriteLine("ERROR: Invalid number of command line arguments.");
                return;
            }

            string filePath = Path.GetFullPath(args[0]);
            if (!File.Exists(filePath)) {
                Console.WriteLine($"ERROR: File {filePath} does not exist.");
                return;
            }

            string option = args[1];

            switch (option)
            {
                case "-c":
                    CompressFile(filePath);
                    break;
                case "-u":
                    if (!filePath.EndsWith(".zipped"))
                    {
                        Console.WriteLine("ERROR: File must have .zipped extension to be decompressed.");
                        return;
                    }
                    try
                    {
                        DecompressFile(filePath);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"ERROR: Can't decompress this file.\n{e.Message}");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine($"ERROR: Invalid option: {option}. Available options: -c, -u");
                    return;
            }
        }
    }
}
