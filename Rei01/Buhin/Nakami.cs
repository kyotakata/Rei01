namespace Rei01.Buhin
{
    internal sealed class Nakami : IBuhin
    {
        public Nakami(string name,int lebel)
        {
            Name = name;
            Lebel = lebel;
        }

        public string Name { get; }
        public int Lebel{ get; }
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
