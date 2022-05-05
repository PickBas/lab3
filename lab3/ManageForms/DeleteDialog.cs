using System;
using System.Windows.Forms;

namespace lab3.ManageForms
{
    public partial class DeleteDialog<T> : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);
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
            Log.Info("Deleted item: " + entityComboBox.Items[entityComboBox.SelectedIndex]);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}