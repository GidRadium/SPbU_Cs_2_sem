using Task_02_BWT;

public class Tests
{
    [Test]
    public void Test1()
    {
        string input = "Ahahaahahalolkek";
        Tuple<string, int> encoded = BWT.Encode(input);
        string decoded = BWT.Decode(encoded.Item1, encoded.Item2);

        Assert.That(input, Is.EqualTo(decoded));
    }

    [Test]
    public void Test2()
    {
        string input = "ooooooooooooo";
        Tuple<string, int> encoded = BWT.Encode(input);
        string decoded = BWT.Decode(encoded.Item1, encoded.Item2);

        Assert.That(input, Is.EqualTo(decoded));
    }

    [Test]
    public void Test3()
    {
        string input = "o";
        Tuple<string, int> encoded = BWT.Encode(input);
        string decoded = BWT.Decode(encoded.Item1, encoded.Item2);

        Assert.That(input, Is.EqualTo(decoded));
    }

    [Test]
    public void Test4()
    {
        string input = "";
        Tuple<string, int> encoded = BWT.Encode(input);
        string decoded = BWT.Decode(encoded.Item1, encoded.Item2);

        Assert.That(input, Is.EqualTo(decoded));
    }
}
