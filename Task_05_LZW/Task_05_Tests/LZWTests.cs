using System.Text;
using Task_05_LZW;

namespace Task_05_Tests
{
    public class LZWTests
    {
        [Test]
        public void Test1()
        {
            byte[] data = Encoding.ASCII.GetBytes("AHAHAHHAHAHAHAHHAHAHHAHAHHAHAAHAHHAHAH XD");
            byte[] compressed = LZW.Compress(data);
            byte[] decompressed = LZW.Decompress(compressed);

            Assert.That(decompressed, Is.EqualTo(data));
        }

        [Test]
        public void Test2()
        {
            byte[] data = Encoding.ASCII.GetBytes("");
            byte[] compressed = LZW.Compress(data);
            byte[] decompressed = LZW.Decompress(compressed);

            Assert.That(decompressed, Is.EqualTo(data));
        }

        [Test]
        public void Test3()
        {
            byte[] data = Encoding.ASCII.GetBytes(".");
            byte[] compressed = LZW.Compress(data);
            byte[] decompressed = LZW.Decompress(compressed);

            Assert.That(decompressed, Is.EqualTo(data));
        }

        [Test]
        public void Test4()
        {
            byte[] data = Encoding.ASCII.GetBytes("aa");
            byte[] compressed = LZW.Compress(data);
            byte[] decompressed = LZW.Decompress(compressed);

            Assert.That(decompressed, Is.EqualTo(data));
        }
    }
}
