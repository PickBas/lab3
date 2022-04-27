namespace lab3.Place
{
    public class Place
    {
        private string _name;
        private int hoursToDrive;
        private int _totalLikes;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int HoursToDrive
        {
            get => hoursToDrive;
            set => hoursToDrive = value;
        }

        public int TotalLikes
        {
            get => _totalLikes;
            set => _totalLikes = value;
        }
    }
}