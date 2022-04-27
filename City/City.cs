namespace lab3.City
{
    public class City
    {
        private string _name;
        private int _population;
        private int _square;

        public City()
        {
            _name = "Unknown";
            _population = 0;
            _square = 0;
        }

        public City(string name, int population, int square)
        {
            _name = name;
            _population = population;
            _square = square;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Population
        {
            get => _population;
            set => _population = value;
        }

        public int Square
        {
            get => _square;
            set => _square = value;
        }
    }
}