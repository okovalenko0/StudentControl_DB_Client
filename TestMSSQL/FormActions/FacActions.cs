using System.Windows.Forms;

namespace TestMSSQL.FormActions
{
    class FacActions
    {
        private static BindingSource bindingSource = new BindingSource();

        public static void LoadTable(DataGridView GridViev, int SelectedIndex)
        {
            bindingSource.DataSource = DBDataOperations.GetAllData(SelectedIndex);

            GridViev.AutoGenerateColumns = true;
            GridViev.DataSource = bindingSource.DataSource;
            GridViev.Columns[0].Width = 223;
            GridViev.Columns[1].Width = 866;
        }
    }
}
