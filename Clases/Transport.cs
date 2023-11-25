namespace OTUS_Prototype_Pattern.Clases
{
    /// <summary>
    /// Класс транспорт
    /// </summary>
    public class Transport : IMyCloneable<Transport>, ICloneable
    {
        public Transport(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string Output()
        {
            return $"{Name} - это транспорт";
        }

        public Transport Clone()
        {
            return new Transport(Name);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
