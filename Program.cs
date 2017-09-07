using System.IO;
using System.Drawing;

namespace ImageToBytes
{
	class Program
    {
        static void Main(string[] args)
        {
            byte[] imgArray;
            Image srcImg = Image.FromFile(@"C:\PathImage");
            Program execute = new ImageToBytes.Program();

            imgArray = execute.ImageToByteArrayPNG(srcImg);

            System.Console.WriteLine(Encoding.UTF8.GetString(imgArray));
            System.Console.ReadLine();

        }

        public byte[] ImageToByteArrayPNG(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
