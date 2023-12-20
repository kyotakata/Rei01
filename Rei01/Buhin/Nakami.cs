using Rei01.Buhin.Data;

namespace Rei01.Buhin
{
    internal sealed class Nakami : BuhinBase
    {
        public Nakami(KaisouEntity entity)
            :base(entity)
        {
        }


        public override void Add(BuhinBase buhin)
        {
            throw new NakamiAddException(Id);
        }

        public override void Execute()
        {
            MessageBox.Show(Name);
        }

        public override string ToString()
        {
            return string.Concat(Enumerable.Repeat("+", Lebel)) + Name;
        }
    }
}
