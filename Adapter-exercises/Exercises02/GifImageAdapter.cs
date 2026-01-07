using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises02
{
    public class GifImageAdapter : IImage
    {

        private GifHandler _gifHandler;

        public GifImageAdapter(GifHandler gifHandler)
        {
            _gifHandler = gifHandler;
        }
        //public GifImageAdapter()
        //{
        //    _gifHandler = new GifHandler();
        //}

        public void Display()
        {
            _gifHandler.RenderGif();
        }

        public void Load(string filename)
        {
            _gifHandler.OpenFile(filename);
        }
    }
}
