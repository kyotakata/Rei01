namespace Rei01.Buhin.Data
{
    internal sealed class KaisouEntity
    {
        public KaisouEntity(int id, int pearentId, int kind, int lebel, string name)
        {
            Id = id;
            PearentId = pearentId;
            Kind = kind;
            Lebel = lebel;
            Name = name;
        }

        public int Id { get; }
        public int PearentId { get; }
        public int Kind { get; }
        public int Lebel { get; }
        public string Name { get; }

    }
}
