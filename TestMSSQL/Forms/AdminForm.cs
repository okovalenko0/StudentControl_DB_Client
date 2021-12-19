using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace TestMSSQL
{
    public partial class AdminForm : MaterialForm
    {
        #region Global Variables
        private Form prevForm;
        private BindingSource bindingSource = new BindingSource();
        #endregion

        #region Form Load
        public AdminForm(Form prevForm)
        {
            this.prevForm = prevForm;
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            FacViewGrid.AutoGenerateColumns = true;
            FacViewGrid.DataSource = fillTable(0);
        }
        #endregion

        #region Form Close
        private void closeMethod(object sender, FormClosedEventArgs e)
        {
            //prevForm.Show();
            //this.Close();
            Application.Exit();
        }
        #endregion

        #region Main Activities
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Хуй соси");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        private BindingSource fillTable(int data)
        {
            bindingSource.DataSource = DBData.GetAllData(data);
            return bindingSource;
        }

        #region Faculty Activities
        private void MainControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MainControl.SelectedIndex)
            {
                case 0:
                    FacViewGrid.AutoGenerateColumns = true;
                    FacViewGrid.DataSource = fillTable(0);
                    break;
                case 1:
                    LecViewGrid.AutoGenerateColumns = true;
                    LecViewGrid.DataSource = fillTable(1);
                    break;
                case 2:
                    SpecViewGrid.AutoGenerateColumns = true;
                    SpecViewGrid.DataSource = fillTable(2);
                    break;
                case 3:
                    GroupsViewGrid.AutoGenerateColumns = true;
                    GroupsViewGrid.DataSource = fillTable(3);
                    break;
                case 4:
                    StudentsViewGrid.AutoGenerateColumns = true;
                    StudentsViewGrid.DataSource = fillTable(4);
                    break;
            }
        }

        private void FacEditControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Lecterns Activities
        //Some code..
        #endregion

        #region Specialitys Activities
        //Some code..
        #endregion

        #region Groups Activities
        //Some code..
        #endregion

        #region Students Activities
        //Some code..
        #endregion
    }
}