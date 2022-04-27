﻿namespace lab3.Megalopolis
{
    public class Megapolis
    {
        private readonly string _name;
        private readonly int _population;
        private readonly int _square;

        public Megapolis()
        {
            _name = "Unknown";
            _population = 0;
            _square = 0;
        }

        public Megapolis(string name, int population, int square)
        {
            _name = name;
            _population = population;
            _square = square;
        }

        public string Name => _name;

        public int Population => _population;

        public int Square => _square;
        
        public override string ToString()
        {
            return "name: " + _name + ", population: " + _population + ", square: " + _square;
        }
        
        public override bool Equals(object obj)
        {
            return obj is Megapolis megapolis
                   && _name.Equals(megapolis.Name)
                   && _population == megapolis.Population
                   && _square == megapolis.Square;
        }

        public override int GetHashCode()
        {
            return (_name, _population, _square).GetHashCode();
        }
    }
}