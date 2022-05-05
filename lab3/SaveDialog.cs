using System;
using System.Windows.Forms;
using lab3.FileWork.CSV;
using lab3.FileWork.JSON;
using lab3.FileWork.Services;
using lab3.FileWork.XML;
using lab3.Megalopolis;

namespace lab3
{
    public partial class SaveDialog<T> : Form
    {
        private IRepository<T> _repository;

        public SaveDialog(IRepository<T> repository)
        {
            _repository = repository;
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
            if (_repository != null)
            {
                IWriter<T> writer = new JsonWriter<T>();
                writer.Write(fileName, _repository);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void xmlSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            String fileName = saveFileDialog.FileName;
            if (_repository != null)
            {
                IWriter<T> writer = new XMLWriter<T>();
                writer.Write(fileName, _repository);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void csvSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            String fileName = saveFileDialog.FileName;
            if (_repository != null)
            {
                IWriter<T> writer = new CSVWriter<T>();
                writer.Write(fileName, _repository);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}