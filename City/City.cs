namespace lab3.City
{
    public class City
    {
        private readonly string _name;
        private readonly int _population;
        private readonly int _square;

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

        public string Name => _name;

        public int Population => _population;

        public int Square => _square;

        public override bool Equals(object obj)
        {
            return obj is City city
                   && _name.Equals(city.Name)
                   && _population == city.Population
                   && _square == city.Square;
        }

        public override int GetHashCode()
        {
            return (_name, _population, _square).GetHashCode();
        }
    }
}