namespace OTUS_Prototype_Pattern.Clases
{
    /// <summary>
    /// Класс колесный транспорт, наследует свойство класса Транспорт
    /// </summary>
    public class WheelTransport : Transport, IMyCloneable<WheelTransport>, ICloneable
    {
        public WheelTransport(string name, int wheelsCount) : base(name)
        {
            WheelsCount = wheelsCount;
        }

        public int WheelsCount { get; set; }

        public new string Output()
        {
            return $"{Name} - это колесный транспорт с количеством колес {WheelsCount}";
        }

        public new WheelTransport Clone()
        {
            return new WheelTransport(Name, WheelsCount);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
