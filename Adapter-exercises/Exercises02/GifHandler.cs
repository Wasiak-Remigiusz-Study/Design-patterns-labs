using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises02
{
    public class GifHandler
    {
        public void OpenFile(string filename)
        {
            Console.WriteLine($"Opening GIF Image - filename: {filename}.");
        }
        public void RenderGif()
        {
            Console.WriteLine("Rendering GIF Image.");
        }
    }
}
