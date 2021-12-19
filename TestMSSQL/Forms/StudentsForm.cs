using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using MaterialSkin.Controls;
using MaterialSkin;

namespace TestMSSQL
{
    public partial class StudentsForm : MaterialForm
    {
        #region Constants
        private Form prevForm;
        private BindingSource bindingSource = new BindingSource();
        #endregion

        #region Form Load/Close
        public StudentsForm(Form prevForm)
        {
            this.prevForm = prevForm;
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            mainSearch_Fac.Items.AddRange(DBData.GetComboData("FacName", "Faculties"));
        }

        private void closeMethod(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Hide();
        }

        private void helpClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Розробник: © Коваленко Олексiй. 2021р");
        }
        #endregion

        #region Main Search
        private void mainSearchFacSelected(object sender, EventArgs e)
        {
            mainSearch_Lec.Text = "";
            mainSearch_Spec.Text = "";
            mainSearch_Group.Text = "";
            mainSearch_Lec.Items.Clear();
            mainSearch_Spec.Items.Clear();
            mainSearch_Group.Items.Clear();
            mainSearch_Lec.Items.AddRange(DBData.GetComboData("LecName", "Lecterns", "LecFacID = '" + (mainSearch_Fac.SelectedIndex + 1) + "'"));
            mainSearch_Lec.Enabled = true;
        }

        private void mainSearchLecSelected(object sender, EventArgs e)
        {
            int ID = DBData.GetIndex("LecID", "Lecterns", "LecName = '" + mainSearch_Lec.Text + "'");
            mainSearch_Spec.Text = "";
            mainSearch_Group.Text = "";
            mainSearch_Spec.Items.Clear();
            mainSearch_Group.Items.Clear();
            mainSearch_Spec.Items.AddRange(DBData.GetComboData("SpecProg", "Specialitys", "SpecLecID = " + ID));
            mainSearch_Spec.Enabled = true;
        }

        private void mainSearchSpecSelected(object sender, EventArgs e)
        {
            int ID = DBData.GetIndex("ID", "Specialitys", "SpecProg = '" + mainSearch_Spec.Text + "'");
            mainSearch_Group.Text = "";
            mainSearch_Group.Items.Clear();
            mainSearch_Group.Items.AddRange(DBData.GetComboData("GrpID", "Groups", "GrpSpecID = " + ID));
            mainSearch_Group.Enabled = true;
        }

        private void mainSearchGroupSelected(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            bindingSource.DataSource = DBData.GetStudentsData(mainSearch_Group.Text);
            dataGridView1.DataSource = bindingSource;
        }
        #endregion

        #region All Data Search
        private void fillTable(int data)
        {
            dataGridView1.AutoGenerateColumns = true;
            bindingSource.DataSource = DBData.GetAllData(data);
            dataGridView1.DataSource = bindingSource;
        }

        private void getAllFacs_Click(object sender, EventArgs e)
        {
            fillTable(0);
        }

        private void getAllLecs_Click(object sender, EventArgs e)
        {
            fillTable(1);
        }

        private void getAllSpecs_Click(object sender, EventArgs e)
        {
            fillTable(2);
        }

        private void getAllGroups_Click(object sender, EventArgs e)
        {
            fillTable(3);
        }

        private void getAllStudents_Click(object sender, EventArgs e)
        {
            fillTable(4);
        }
        #endregion
    }
}