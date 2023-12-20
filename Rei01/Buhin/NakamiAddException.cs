using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rei01.Buhin
{
    internal sealed class NakamiAddException : Exception
    {
        public NakamiAddException(int id)
            :base($"NakamiにAddはできませんId={id}")
        {

        }
    }
}
