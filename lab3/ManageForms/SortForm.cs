using System;
using System.Windows.Forms;

namespace lab3.ManageForms
{
    public partial class SortForm<T> : Form
    {
        private IRepository<T> _repository;
        
        public SortForm(IRepository<T> repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        private void populationBtn_Click(object sender, EventArgs e)
        {
            _repository.SortDataByPopulationDescending();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            _repository.SortDataBySquareDescending();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}