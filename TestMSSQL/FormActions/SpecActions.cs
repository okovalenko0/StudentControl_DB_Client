﻿using System.Windows.Forms;

namespace TestMSSQL.FormActions
{
    class SpecActions
    {
        private static BindingSource bindingSource = new BindingSource();

        public static void LoadTable(DataGridView GridViev, int SelectedIndex)
        {
            bindingSource.DataSource = DBDataOperations.GetAllData(SelectedIndex);

            GridViev.AutoGenerateColumns = true;
            GridViev.DataSource = bindingSource.DataSource;
            GridViev.Columns[0].Width = 40;
            GridViev.Columns[1].Width = 165;
            GridViev.Columns[2].Width = 205;
            GridViev.Columns[3].Width = 331;
            GridViev.Columns[4].Width = 331;
        }
    }
}
