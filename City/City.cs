namespace lab3.City
{
    public class City
    {
        private string _name;
        private int _population;
        private int _square;

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