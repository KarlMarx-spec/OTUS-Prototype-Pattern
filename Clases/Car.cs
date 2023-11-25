namespace OTUS_Prototype_Pattern.Clases
{
    /// <summary>
    /// Класс машина, наследует свойства классов Колесный транспорт и Транспорт
    /// </summary>
    public class Car : WheelTransport, IMyCloneable<Car>, ICloneable
    {
        public Car(string name, int wheelsCount,
            string mark, string model, int hp, int maxSpeed) : base(name, wheelsCount)
        {
            Mark = mark;
            Model = model;
            HP = hp;
            MaxSpeed = maxSpeed;
        }

        public string Mark { get; set; }
        public string Model { get; set; }
        public int HP { get; set; }
        public int MaxSpeed { get; set; }

        public new string Output()
        {
            return $"{Mark} {Model} - это {Name} с количеством колес {WheelsCount}, с {HP} л.с. и макс. скоростью {MaxSpeed}";
        }

        public new Car Clone()
        {
            return new Car(Name, WheelsCount, Mark, Model, HP, MaxSpeed);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
