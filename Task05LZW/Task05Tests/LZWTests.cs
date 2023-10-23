using Task05LZW;
using System.Text;
namespace Task05Tests;

public class LZWTests
{
    [Test]
    public void LZWStandartStringReturnsSameString()
    {
        byte[] data = Encoding.ASCII.GetBytes("AHAHAHHAHAHAHAHHAHAHHAHAHHAHAAHAHHAHAH XD");
        byte[] compressed = LZW.Compress(data);
        byte[] decompressed = LZW.Decompress(compressed);

        Assert.That(decompressed, Is.EqualTo(data));
    }

    [Test]
    public void LZWEmptyStringReturnsEmptyString()
    {
        byte[] data = Encoding.ASCII.GetBytes("");
        byte[] compressed = LZW.Compress(data);
        byte[] decompressed = LZW.Decompress(compressed);

        Assert.That(decompressed, Is.EqualTo(data));
    }

    [Test]
    public void LZWOneElementStringReturnsSameString()
    {
        byte[] data = Encoding.ASCII.GetBytes(".");
        byte[] compressed = LZW.Compress(data);
        byte[] decompressed = LZW.Decompress(compressed);

        Assert.That(decompressed, Is.EqualTo(data));
    }

    [Test]
    public void LZWTwoElementStringReturnsSameString()
    {
        byte[] data = Encoding.ASCII.GetBytes("aa");
        byte[] compressed = LZW.Compress(data);
        byte[] decompressed = LZW.Decompress(compressed);

        Assert.That(decompressed, Is.EqualTo(data));
    }
}
