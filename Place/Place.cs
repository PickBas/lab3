namespace lab3.Place
{
    public class Place
    {
        private readonly string _name;
        private readonly int _population;
        private readonly int _square;

        public Place()
        {
            _name = "Unknown";
            _population = 0;
            _square = 0;
        }

        public Place(string name, int population, int square)
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
            return obj is Place place
                   && _name.Equals(place.Name)
                   && _population == place.Population
                   && _square == place.Square;
        }

        public override int GetHashCode()
        {
            return (_name, _population, _square).GetHashCode();
        }
    }
}