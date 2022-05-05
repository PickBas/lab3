using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using lab3.City;
using lab3.ManageForms;
using lab3.Megapolis;
using lab3.Place;
using lab3.Region;

namespace lab3
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);
        private string _currentDataType;
        private IRepository<CityEntity> _cityRepo; 
        private IRepository<MegapolisEntity> _megapolisRepo; 
        private IRepository<PlaceEntity> _placeRepo; 
        private IRepository<RegionEntity> _regionRepo; 

        public Form1()
        {
            _currentDataType = "City";
            _cityRepo = new CityRepository();
            _megapolisRepo = new MegapolisRepository();
            _placeRepo = new PlaceRepository();
            _regionRepo = new RegionRepository();
            InitializeComponent();
            Log.Info("Initialized Form1");
        }

        private void UpdateData()
        {
            FillData();
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 145;
            dataGridView1.Columns[3].Width = 140;
        }

        private void FillData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("#");
            table.Columns.Add("Name");
            table.Columns.Add("Population");
            table.Columns.Add("Square");
            if (_currentDataType == "City")
            {
                for (int i = 1; i <= _cityRepo.GetData().Count; ++i)
                {
                    DataRow dr = table.NewRow();
                    dr["#"] = (i).ToString();
                    dr["Name"] = _cityRepo.GetData()[i - 1].Name;
                    dr["Population"] = _cityRepo.GetData()[i - 1].Population;
                    dr["Square"] = _cityRepo.GetData()[i - 1].Square;
                    table.Rows.Add(dr);
                }
            }

            if (_currentDataType == "Megapolis")
            {
                for (int i = 1; i <= _megapolisRepo.GetData().Count; ++i)
                {
                    DataRow dr = table.NewRow();
                    dr["#"] = (i).ToString();
                    dr["Name"] = _megapolisRepo.GetData()[i - 1].Name;
                    dr["Population"] = _megapolisRepo.GetData()[i - 1].Population;
                    dr["Square"] = _megapolisRepo.GetData()[i - 1].Square;
                    table.Rows.Add(dr);
                }
            }

            if (_currentDataType == "Place")
            {
                for (int i = 1; i <= _placeRepo.GetData().Count; ++i)
                {
                    DataRow dr = table.NewRow();
                    dr["#"] = (i).ToString();
                    dr["Name"] = _placeRepo.GetData()[i - 1].Name;
                    dr["Population"] = _placeRepo.GetData()[i - 1].Population;
                    dr["Square"] = _placeRepo.GetData()[i - 1].Square;
                    table.Rows.Add(dr);
                }
            }

            if (_currentDataType == "Region")
            {
                for (int i = 1; i <= _regionRepo.GetData().Count; ++i)
                {
                    DataRow dr = table.NewRow();
                    dr["#"] = (i).ToString();
                    dr["Name"] = _regionRepo.GetData()[i - 1].Name;
                    dr["Population"] = _regionRepo.GetData()[i - 1].Population;
                    dr["Square"] = _regionRepo.GetData()[i - 1].Square;
                    table.Rows.Add(dr);
                }
            }

            dataGridView1.DataSource = table;
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
                Log.Info("Opened file: " + filePathLabel.Text);
            }
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            Form saveForm;
            switch (_currentDataType)
            {
                case string b when b.Equals("City"):
                    saveForm = new SaveDialog<CityEntity>(_cityRepo);
                    saveForm.Show();
                    break;
                case string b when b.Equals("Megapolis"):
                    saveForm = new SaveDialog<MegapolisEntity>(_megapolisRepo);
                    saveForm.Show();
                    break;
                case string b when b.Equals("Place"):
                    saveForm = new SaveDialog<PlaceEntity>(_placeRepo);
                    saveForm.Show();
                    break;
                case string b when b.Equals("Region"):
                    saveForm = new SaveDialog<RegionEntity>(_regionRepo);
                    saveForm.Show();
                    break;
            }
            Log.Info("Saved file");
        }

        private void entityChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentDataType = (sender as ComboBox)?.Text;
            UpdateData();
            Log.Info("Changed entity");
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            switch (_currentDataType)
            {
                case string a when a.Equals("City"):
                    AddDialog<CityEntity> addDialogCity = new AddDialog<CityEntity>(_cityRepo);
                    if (addDialogCity.ShowDialog() == DialogResult.OK)
                    {
                        UpdateData();
                    }
                    break;
                case string a when a.Equals("Megapolis"):
                    AddDialog<MegapolisEntity> addDialogMegapolis = new AddDialog<MegapolisEntity>(_megapolisRepo);
                    if (addDialogMegapolis.ShowDialog() == DialogResult.OK)
                    {
                        UpdateData();
                    }
                    break;
                case string a when a.Equals("Place"):
                    AddDialog<PlaceEntity> addDialogPlace = new AddDialog<PlaceEntity>(_placeRepo);
                    if (addDialogPlace.ShowDialog() == DialogResult.OK)
                    {
                        UpdateData();
                    }
                    break;
                case string a when a.Equals("Region"):
                    AddDialog<RegionEntity> addDialogRegion = new AddDialog<RegionEntity>(_regionRepo);
                    if (addDialogRegion.ShowDialog() == DialogResult.OK)
                    {
                        UpdateData();
                    }
                    break;
            }
            Log.Info("Added item to data grid");
        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            switch (_currentDataType)
            {
                case string a when a.Equals("City"):
                    DeleteDialog<CityEntity> addDialogCity = new DeleteDialog<CityEntity>(_cityRepo);
                    if (addDialogCity.ShowDialog() == DialogResult.OK)
                    {
                        UpdateData();
                    }
                    break;
                case string a when a.Equals("Megapolis"):
                    DeleteDialog<MegapolisEntity> addDialogMegapolis = new DeleteDialog<MegapolisEntity>(_megapolisRepo);
                    if (addDialogMegapolis.ShowDialog() == DialogResult.OK)
                    {
                        UpdateData();
                    }
                    break;
                case string a when a.Equals("Place"):
                    DeleteDialog<PlaceEntity> addDialogPlace = new DeleteDialog<PlaceEntity>(_placeRepo);
                    if (addDialogPlace.ShowDialog() == DialogResult.OK)
                    {
                        UpdateData();
                    }
                    break;
                case string a when a.Equals("Region"):
                    DeleteDialog<RegionEntity> addDialogRegion = new DeleteDialog<RegionEntity>(_regionRepo);
                    if (addDialogRegion.ShowDialog() == DialogResult.OK)
                    {
                        UpdateData();
                    }
                    break;
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            FilterDialog filterDialog = new FilterDialog(dataGridView1);
            filterDialog.Show();
            Log.Info("Filtered data");
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            switch (_currentDataType) 
            {
                case string a when a.Equals("City"):
                    SortForm<CityEntity> formCity = new SortForm<CityEntity>(_cityRepo);
                    if (formCity.ShowDialog() == DialogResult.OK) {
                        UpdateData();
                    }
                    break;
                case string a when a.Equals("Megapolis"):
                    SortForm<MegapolisEntity> formMegapolis = new SortForm<MegapolisEntity>(_megapolisRepo);
                    if (formMegapolis.ShowDialog() == DialogResult.OK) {
                        UpdateData();
                    }
                    break;
                case string a when a.Equals("Place"):
                    SortForm<PlaceEntity> formPlace = new SortForm<PlaceEntity>(_placeRepo);
                    if (formPlace.ShowDialog() == DialogResult.OK) {
                        UpdateData();
                    }
                    break; 
                case string a when a.Equals("Region"):
                    SortForm<RegionEntity> formRegion = new SortForm<RegionEntity>(_regionRepo);
                    if (formRegion.ShowDialog() == DialogResult.OK) {
                        UpdateData();
                    }
                    break;
            }
        }
    }
}
