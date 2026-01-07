using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises02
{
    public interface IImage
    {
        void Load(string filename);
        void Display();
    }
}
