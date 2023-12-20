﻿using Rei01.Buhin.Data;

namespace Rei01.Buhin
{
    internal sealed class Nakami : IBuhin
    {
        private KaisouEntity _entity;
        public Nakami(KaisouEntity entity)
        {
            _entity = entity;
        }

        public string Name => _entity.Name;
        public int Lebel => _entity.Lebel;

        public void Execute()
        {
            MessageBox.Show(Name);
        }

        public override string ToString()
        {
            return string.Concat(Enumerable.Repeat("+", Lebel)) + Name;
        }
    }
}
