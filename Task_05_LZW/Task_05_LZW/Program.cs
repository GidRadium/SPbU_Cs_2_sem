namespace Task_05_LZW
{
    class Program
    {
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
            double ratio = 0;
            string outFilePath = "";

            switch (option)
            {
                case "-c":
                    outFilePath = LZW.Compress(filePath, ref ratio);
                    break;
                case "-u":
                    outFilePath = LZW.Decompress(filePath, ref ratio);
                    break;
                default:
                    Console.WriteLine($"Invalid option: {option}. Available options: -c, -u");
                    return;
            }

            Console.WriteLine($"Result path: {outFilePath}\nRatio: {ratio}");
        }
    }
}
