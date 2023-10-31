using Task02BurrowsWheelerTransform;

Console.WriteLine("Enter the string: ");
string input;
while (true)
{
    input = Console.ReadLine() ?? "";
    if (input == "")
        Console.WriteLine("Incorrect Input!");
    else
        break;
}

(string, int) encoded = BurrowsWheelerTransform.Encode(input);
string decoded = BurrowsWheelerTransform.Decode(encoded.Item1, encoded.Item2);
Console.WriteLine($"Input:   {input}");
Console.WriteLine($"Encoded: {encoded.Item1} {encoded.Item2}");
Console.WriteLine($"Decoded: {decoded}");
