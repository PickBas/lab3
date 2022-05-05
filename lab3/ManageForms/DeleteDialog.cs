using System;
using System.Windows.Forms;

namespace lab3.ManageForms
{
    public partial class DeleteDialog<T> : Form
    {
        private IRepository<T> _repository;

        public DeleteDialog(IRepository<T> repository)
        {
            _repository = repository;
            InitializeComponent();
            foreach (var entity in _repository.GetData())
            {
                entityComboBox.Items.Add(entity);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            _repository.DeleteObject(entityComboBox.SelectedIndex);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}