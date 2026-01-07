using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises02
{
    public class JpegImage : IImage
    {


        public void Display()
        {
            Console.WriteLine("Displaying JPEG Image.");
        }

        public void Load(string filename)
        {
            Console.WriteLine($"Loading JPEG Image - filename: {filename}.");
        }
    }
}
