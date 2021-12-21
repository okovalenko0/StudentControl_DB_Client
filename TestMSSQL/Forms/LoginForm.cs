using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TestMSSQL
{
    public partial class LoginForm : Form
    {
        #region Global Variables
        //private DBConnection dBConnection = new DBConnection();
        private SqlConnection connection = DBConnection.Connect();

        private Color regularTextBoxBackColor;
        private Color errorTextBoxBackColor = Color.FromKnownColor(KnownColor.Crimson);

        private bool isUserExist = false;
        private bool isAdmin = false;

        private AdminForm adminForm;
        private StudentsForm studentsForm;
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
            settings.Fields.Login = LoginTextBox.Text;
            settings.Fields.Password = PasswordTextBox.Text;
            settings.Fields.SaveSettings = SaveSettings.Checked;
            settings.WriteXml();
        }
        //Чтение настроек
        private void readSetting()
        {
            settings.ReadXml();
            LoginTextBox.Text = settings.Fields.Login;
            PasswordTextBox.Text = settings.Fields.Password;
            if (settings.Fields.SaveSettings) SaveSettings.CheckState = CheckState.Checked;
            else SaveSettings.CheckState = CheckState.Unchecked;
        }
        #endregion

        #region Form Actions
        public LoginForm()
        {
            InitializeComponent();
            KeyPreview = true;
            this.regularTextBoxBackColor = LoginTextBox.BackColor;
            readSetting();
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Data Actions
        public AdminForm AdminForm
        {
            get
            {
                return adminForm;
            }
        }
        public StudentsForm StudentsForm
        {
            get
            {
                return studentsForm;
            }
        }
        #endregion

        #region Buttons
        public void TryToLogin()
        {
            isUserExist = DBDataOperations.isUserExist(LoginTextBox.Text, PasswordTextBox.Text);
            if (isUserExist)
            {
                isAdmin = DBDataOperations.isHaveAdminAcces(LoginTextBox.Text, PasswordTextBox.Text);
                if (SaveSettings.Checked) writeSetting();
                else resetSettings();

                if (isAdmin)
                {
                    adminForm = new AdminForm(ActiveForm);
                    adminForm.Show();
                    Hide();
                }
                else
                {
                    studentsForm = new StudentsForm(ActiveForm);
                    studentsForm.Show();
                    Hide();
                }
            }
            else
            {
                errorProvider.SetError(LoginTextBox, "Пользователь " + LoginTextBox.Text + " не существует или введён неверный пароль!");
                LoginTextBox.BackColor = errorTextBoxBackColor;
                PasswordTextBox.BackColor = errorTextBoxBackColor;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            TryToLogin();
        }

        private void loginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TryToLogin();
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TryToLogin();
            }
        }

        #endregion
    }
}
