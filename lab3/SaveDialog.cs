using System;
using System.Windows.Forms;
using lab3.FileWork.JSON;
using lab3.FileWork.Services;
using lab3.Megalopolis;

namespace lab3
{
    public partial class SaveDialog : Form
    {
        private IRepository<City.City> _cityRepo; 
        private IRepository<Megalopolis.Megapolis> _megapolisRepo; 
        private IRepository<Place.Place> _placeRepo; 
        private IRepository<Region.Region> _regionRepo; 

        public SaveDialog(
            IRepository<City.City> cityRepo)
        {
            _cityRepo = cityRepo;
            InitializeComponent();
        }
        
        public SaveDialog(
            IRepository<Megapolis> megapolisRepo)
        {
            _megapolisRepo = megapolisRepo;
            InitializeComponent();
        }
        
        public SaveDialog(
            IRepository<Place.Place> placeRepo)
        {
            _placeRepo = placeRepo;
            InitializeComponent();
        }
        
        public SaveDialog(
            IRepository<Region.Region> regionRepo)
        {
            _regionRepo = regionRepo;
            InitializeComponent();
        }

        private void jsonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            String fileName = saveFileDialog.FileName;
            if (_cityRepo != null)
            {
                IWriter<City.City> writer = new JsonWriter<City.City>();
                writer.Write(fileName, _cityRepo);
            }
            if (_megapolisRepo != null)
            {
                IWriter<City.City> writer = new JsonWriter<City.City>();
                writer.Write(fileName, _cityRepo); 
            }
            if (_placeRepo != null)
            {
                IWriter<City.City> writer = new JsonWriter<City.City>();
                writer.Write(fileName, _cityRepo);
            }
            if (_regionRepo != null)
            {
                IWriter<City.City> writer = new JsonWriter<City.City>();
                writer.Write(fileName, _cityRepo);
            }
        }
    }
}