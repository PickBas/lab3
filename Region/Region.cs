namespace lab3.Region
{
    public class Region
    {
        private readonly string _name;
        private readonly int _population;
        private readonly int _square;

        public Region()
        {
            _name = "Unknown";
            _population = 0;
            _square = 0;
        }

        public Region(string name, int population, int square)
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
            return obj is Region region
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