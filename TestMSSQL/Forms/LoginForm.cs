using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestMSSQL
{
    public partial class LoginForm : Form
    {
        #region Global Variables
        //private DBConnection dBConnection = new DBConnection();
        private SqlConnection connection = DBConnection.Connect();
        #endregion

        #region Settings
        //Экземпляр класса с настройками
        Settings settings = new Settings();

        public SqlConnection Connection { get => connection; set => connection = value; }

        //Сброс настроек
        private void resetSettings()
        {
            settings.Fields.Login = @"Student";
            settings.Fields.Password = @"123";
            settings.Fields.SaveSettings = false;
            settings.WriteXml();
        }
        //Запись настроек
        private void writeSetting()
        {
            settings.Fields.Login = login_TextBox.Text;
            settings.Fields.Password = password_TextBox.Text;
            settings.Fields.SaveSettings = saveSettings.Checked;
            settings.WriteXml();
        }
        //Чтение настроек
        private void readSetting()
        {
            settings.ReadXml();
            login_TextBox.Text = settings.Fields.Login;
            password_TextBox.Text = settings.Fields.Password;
            if (settings.Fields.SaveSettings) saveSettings.CheckState = CheckState.Checked;
            else saveSettings.CheckState = CheckState.Unchecked;
        }
        #endregion

        #region Form Load
        public LoginForm()
        {
            InitializeComponent();
            readSetting();
        }
        #endregion

        #region Users Activities
        private bool isUserExist()
        {
            bool isExist = false;
            connection.Open();
            SqlCommand command = new SqlCommand("select UserAccess from Users where UserLogin = '" + login_TextBox.Text + "' and UserPasswd = '" + password_TextBox.Text + "'", Connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isExist = reader.HasRows;
            }
            reader.Close();
            Connection.Close();
            return isExist;
        }
        private bool isHaveAdminAcces()
        {
            bool isAdmin = false;
            connection.Open();
            SqlCommand command = new SqlCommand("select UserAccess from Users where UserLogin = '" + login_TextBox.Text + "' and UserPasswd = '" + password_TextBox.Text + "'", Connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isAdmin = reader.GetBoolean(0);
            }
            reader.Close();
            Connection.Close();
            return isAdmin;
        }
        #endregion

        #region Form actions
        private void login_Button_Click(object sender, EventArgs e)
        {
            if (isUserExist())
            {
                if (saveSettings.Checked) writeSetting();
                else resetSettings();

                if (isHaveAdminAcces())
                {
                    AdminForm mainForm = new AdminForm(ActiveForm);
                    mainForm.Show();
                    Hide();
                }
                else
                {
                    StudentsForm studentsForm = new StudentsForm(ActiveForm);
                    studentsForm.Show();
                    Hide();
                }
            }
            else MessageBox.Show("Неверный логин или пароль!");
        }
        #endregion
    }
}
