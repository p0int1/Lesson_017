namespace Task_2
{
    struct Car
    {
        readonly string marka;
        readonly string model;
        readonly int year;
        readonly string color;

        public Car(string marka, string model, int year, string color)
        {
            this.marka = marka;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public string Color { get { return color; } }

        public string Model { get { return model; } }

        public int Year { get { return year; } }

        public string Marka { get { return marka; } }

        public override string ToString()
        {
            return "Марка: " + marka + ", Модель: " + model + ", Год выпуска: " + year + ", Цвет: " + color;
        }
    }
}
