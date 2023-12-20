using Rei01.Buhin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rei01.Buhin
{
    internal abstract class BuhinBase
    {
        private KaisouEntity _entity;
        protected BuhinBase(KaisouEntity entity)
        {
            _entity= entity;
        }

        public string Name => _entity.Name;
        public int Lebel => _entity.Lebel;
        public int Id => _entity.Id;
        public int ParentId => _entity.PearentId;

        public abstract void Execute();
        public abstract void Add(BuhinBase buhin);

    }
}
