﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rei01.Buhin
{
    internal sealed class Youki : IBuhin
    {
        private List<IBuhin> _buhins = new List<IBuhin>();

        public Youki(string name, int lebel)
        {
            Name = name;
            Lebel = lebel;
        }

        public string Name { get; }

        public int Lebel { get; }
        public void Execute()
        {
            MessageBox.Show(Name);

            foreach (var buhin in _buhins)
            {
                buhin.Execute();
            }
        }

        public void Add(IBuhin buhin)
        {
            _buhins.Add(buhin);
        }

        public override string ToString()
        {
            return string.Concat(Enumerable.Repeat("+", Lebel)) + Name;
        }

    }
}
