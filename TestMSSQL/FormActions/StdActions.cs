using System.Windows.Forms;

namespace TestMSSQL.FormActions
{
    class StdActions
    {
        private static BindingSource bindingSource = new BindingSource();

        public static void LoadTable(DataGridView GridViev, int SelectedIndex)
        {
            bindingSource.DataSource = DBDataOperations.GetAllData(SelectedIndex);

            GridViev.AutoGenerateColumns = true;
            GridViev.DataSource = bindingSource.DataSource;
            GridViev.Columns[0].Width = 40;
            GridViev.Columns[1].Width = 60;
            GridViev.Columns[2].Width = 115;
            GridViev.Columns[3].Width = 145;
            GridViev.Columns[4].Width = 127;
            GridViev.Columns[5].Width = 145;
            GridViev.Columns[6].Width = 140;
            GridViev.Columns[7].Width = 145;
            GridViev.Columns[8].Width = 155;
        }
    }
}
