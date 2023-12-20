using Rei01.Buhin.Data;

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

        public int Id => _entity.Id;

        public int ParentId => _entity.PearentId;

        public void Add(IBuhin buhin)
        {
            throw new NakamiAddException(Id);
        }

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
