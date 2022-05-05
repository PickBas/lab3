using System;
using System.Windows.Forms;

namespace lab3.ManageForms
{
    public partial class FilterDialog : Form
    {
        private DataGridView _dataGridView;
        
        public FilterDialog(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            InitializeComponent();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _dataGridView.DataSource;
            bindingSource.Filter = " " 
                                   + "Population" 
                                   + " >= " 
                                   + populationInput.Text 
                                   + " AND " 
                                   + "Square" 
                                   + " >= " 
                                   + squareInput.Text 
                                   + " ";
            _dataGridView.DataSource = bindingSource;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}