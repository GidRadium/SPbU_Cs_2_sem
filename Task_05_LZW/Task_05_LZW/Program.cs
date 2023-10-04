namespace Task_05_LWZ
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

            switch (option)
            {
                case "-c":
                    //Compress(filePath);
                    break;
                case "-u":
                    //Decompress(filePath);
                    break;
                default:
                    Console.WriteLine($"Invalid option: {option}. Available options: -c, -u");
                    return;
            }
        }
    }
}
