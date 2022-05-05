namespace lab3.Region
{
    public class RegionEntity
    {
        private string _name;
        private int _population;
        private int _square;

        public RegionEntity()
        {
            _name = "Unknown";
            _population = 0;
            _square = 0;
        }

        public RegionEntity(string name, int population, int square)
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
            return obj is RegionEntity region
                   && _name.Equals(region.Name)
                   && _population == region.Population
                   && _square == region.Square;
        }

        public override int GetHashCode()
        {
            return (_name, _population, _square).GetHashCode();
        }
    }
}