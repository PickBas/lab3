using System;
using System.Windows.Forms;

namespace lab3.ManageForms
{
    public partial class AddDialog<T> : Form
    {
        private IRepository<T> _repository;

        public AddDialog(IRepository<T> repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _repository.AddObject(nameInput.Text,
                Int32.Parse(populationInput.Text), 
                Int32.Parse(squareInput.Text));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}