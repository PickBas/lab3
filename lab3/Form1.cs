using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using lab3.City;
using lab3.ManageForms;
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

        private void UpdateData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("#");
            table.Columns.Add("Name");
            table.Columns.Add("Population");
            table.Columns.Add("Square");
            Dictionary<string, string> data = new Dictionary<string, string>();
            if (_currentDataType == "City")
            {
                for (int i = 1; i <= _cityRepo.GetData().Count; ++i)
                {
                    DataRow dr = table.NewRow();
                    dr["#"] = (i).ToString();
                    dr["Name"] = _cityRepo.GetData()[i-1].Name;
                    dr["Population"] = _cityRepo.GetData()[i-1].Population;
                    dr["Square"] = _cityRepo.GetData()[i-1].Square;
                    table.Rows.Add(dr);
                }
            }
            if (_currentDataType == "Megapolis")
            {
                for (int i = 1; i <= _megapolisRepo.GetData().Count; ++i)
                {
                    DataRow dr = table.NewRow();
                    dr["#"] = (i).ToString();
                    dr["Name"] = _megapolisRepo.GetData()[i-1].Name;
                    dr["Population"] = _megapolisRepo.GetData()[i-1].Population;
                    dr["Square"] = _megapolisRepo.GetData()[i-1].Square;
                    table.Rows.Add(dr);
                }
            }
            if (_currentDataType == "Place")
            {
                for (int i = 1; i <= _placeRepo.GetData().Count; ++i)
                {
                    DataRow dr = table.NewRow();
                    dr["#"] = (i).ToString();
                    dr["Name"] = _placeRepo.GetData()[i-1].Name;
                    dr["Population"] = _placeRepo.GetData()[i-1].Population;
                    dr["Square"] = _placeRepo.GetData()[i-1].Square;
                    table.Rows.Add(dr);
                }
            }
            if (_currentDataType == "Region")
            {
                for (int i = 1; i <= _regionRepo.GetData().Count; ++i)
                {
                    DataRow dr = table.NewRow();
                    dr["#"] = (i).ToString();
                    dr["Name"] = _regionRepo.GetData()[i-1].Name;
                    dr["Population"] = _regionRepo.GetData()[i-1].Population;
                    dr["Square"] = _regionRepo.GetData()[i-1].Square;
                    table.Rows.Add(dr);
                }
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 145;
            dataGridView1.Columns[3].Width = 140;
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
                UpdateData();
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

        private void entityChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentDataType = (sender as ComboBox)?.Text;
            UpdateData();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            switch (_currentDataType)
            {
                case string a when a.Equals("City"):
                    AddDialog<City.City> addDialogCity = new AddDialog<City.City>(_cityRepo);
                    if (addDialogCity.ShowDialog() == DialogResult.OK)
                    {
                        UpdateData();
                    }
                    break;
                case string a when a.Equals("Megapolis"):
                    AddDialog<Megapolis> addDialogMegapolis = new AddDialog<Megapolis>(_megapolisRepo);
                    if (addDialogMegapolis.ShowDialog() == DialogResult.OK)
                    {
                        UpdateData();
                    }
                    break;
                case string a when a.Equals("Place"):
                    AddDialog<Place.Place> addDialogPlace = new AddDialog<Place.Place>(_placeRepo);
                    if (addDialogPlace.ShowDialog() == DialogResult.OK)
                    {
                        UpdateData();
                    }
                    break;
                case string a when a.Equals("Region"):
                    AddDialog<Region.Region> addDialogRegion = new AddDialog<Region.Region>(_regionRepo);
                    if (addDialogRegion.ShowDialog() == DialogResult.OK)
                    {
                        UpdateData();
                    }
                    break;
            }
        }
    }
}
