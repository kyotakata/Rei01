using Rei01.Buhin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rei01.Buhin
{
    internal sealed class Youki : BuhinBase
    {
        private List<BuhinBase> _buhins = new List<BuhinBase>();

        public Youki(KaisouEntity entity)
            :base(entity)
        {
        }


        public override void Execute()
        {
            MessageBox.Show(Name);

            foreach (var buhin in _buhins)
            {
                buhin.Execute();
            }
        }

        public override void Add(BuhinBase buhin)
        {
            _buhins.Add(buhin);
        }

        public override string ToString()
        {
            return string.Concat(Enumerable.Repeat("+", Lebel)) + Name;
        }

    }
}
