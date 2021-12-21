using System.Windows.Forms;

namespace TestMSSQL.FormActions
{
    class GrpActions
    {
        private static BindingSource bindingSource = new BindingSource();

        public static void LoadTable(DataGridView GridViev, int SelectedIndex)
        {
            bindingSource.DataSource = DBDataOperations.GetAllData(SelectedIndex);

            GridViev.AutoGenerateColumns = true;
            GridViev.DataSource = bindingSource.DataSource;
            GridViev.Columns[0].Width = 210;
            GridViev.Columns[1].Width = 412;
            GridViev.Columns[2].Width = 250;
            GridViev.Columns[3].Width = 200;
        }
    }
}
