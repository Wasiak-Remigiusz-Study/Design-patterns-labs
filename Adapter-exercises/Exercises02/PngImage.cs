using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises02
{
    public class PngImage : IImage
    {
        public void Display()
        {
            Console.WriteLine("Displaying PNG Image.");
        }

        public void Load(string filename)
        {
            Console.WriteLine($"Loading PNG Image -  filename: {filename}.");
        }
    }
}
