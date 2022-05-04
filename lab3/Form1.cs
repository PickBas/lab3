using System;
using System.IO;
using System.Windows.Forms;
using lab3.City;
using lab3.Megalopolis;
using lab3.Place;
using lab3.Region;

namespace lab3
{
    public partial class Form1 : Form
    {

        private string _currentDataType;
        private IRepository<City.City> _cityRepo; 
        private IRepository<Megalopolis.Megapolis> _megapolisRepo; 
        private IRepository<Place.Place> _placeRepo; 
        private IRepository<Region.Region> _regionRepo; 

        public Form1()
        {
            _currentDataType = "City";
            _cityRepo = new CityRepository();
            _megapolisRepo = new MegapolisRepository();
            _placeRepo = new PlaceRepository();
            _regionRepo = new RegionRepository();
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Supported files (*.json;*.xml;*.csv)|*.json;*.xml;*.csv|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                filePathLabel.Text = filePath;
                string extension = Path.GetExtension(filePath);
                switch (_currentDataType)
                {
                    case string b when b.Equals("City"):
                        _cityRepo = new CityRepository(filePath, extension);
                        break;
                    case string b when b.Equals("Megapolis"):
                        _megapolisRepo = new MegapolisRepository(filePath, extension);
                        break;
                    case string b when b.Equals("Place"):
                        _placeRepo = new PlaceRepository(filePath, extension);
                        break;
                    case string b when b.Equals("Region"):
                        _regionRepo = new RegionRepository(filePath, extension);
                        break;
                }
            }
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            Form saveForm;
            switch (_currentDataType)
            {
                case string b when b.Equals("City"):
                    saveForm = new SaveDialog(_cityRepo);
                    saveForm.Show();
                    break;
                case string b when b.Equals("Megapolis"):
                    saveForm = new SaveDialog(_megapolisRepo);
                    saveForm.Show();
                    break;
                case string b when b.Equals("Place"):
                    saveForm = new SaveDialog(_placeRepo);
                    saveForm.Show();
                    break;
                case string b when b.Equals("Region"):
                    saveForm = new SaveDialog(_regionRepo);
                    saveForm.Show();
                    break;
            }
        }
    }
}
