namespace lab3.Place
{
    public class Place
    {
        private string _name;
        private int _population;
        private int _square;

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

        public override string ToString()
        {
            return "name: " + _name + ", population: " + _population + ", square: " + _square;
        }
        
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