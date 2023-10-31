using Task02BurrowsWheelerTransform;

public class BurrowsWheelerTransformTests
{
    [Test]
    public void BurrowsWheelerTransformStandartStringReturnsSameString()
    {
        string input = "Ahahaahahalolkek";
        (string, int) encoded = BurrowsWheelerTransform.Encode(input);
        string decoded = BurrowsWheelerTransform.Decode(encoded.Item1, encoded.Item2);

        Assert.That(input, Is.EqualTo(decoded));
    }

    [Test]
    public void BurrowsWheelerTransformOneLetterTypeStringReturnsSameString()
    {
        string input = "ooooooooooooo";
        (string, int) encoded = BurrowsWheelerTransform.Encode(input);
        string decoded = BurrowsWheelerTransform.Decode(encoded.Item1, encoded.Item2);

        Assert.That(input, Is.EqualTo(decoded));
    }

    [Test]
    public void BurrowsWheelerTransformOneLetterStringReturnsSameString()
    {
        string input = "o";
        (string, int) encoded = BurrowsWheelerTransform.Encode(input);
        string decoded = BurrowsWheelerTransform.Decode(encoded.Item1, encoded.Item2);

        Assert.That(input, Is.EqualTo(decoded));
    }

    [Test]
    public void BurrowsWheelerTransformEmptyStringReturnsSameString()
    {
        string input = "";
        (string, int) encoded = BurrowsWheelerTransform.Encode(input);
        string decoded = BurrowsWheelerTransform.Decode(encoded.Item1, encoded.Item2);

        Assert.That(input, Is.EqualTo(decoded));
    }
}
