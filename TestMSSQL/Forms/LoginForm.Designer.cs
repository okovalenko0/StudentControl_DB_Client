namespace TestMSSQL
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginButton = new System.Windows.Forms.Button();
            this.logoPuctureBox = new System.Windows.Forms.PictureBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.ProgramName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LogoHAI = new System.Windows.Forms.PictureBox();
            this.AboutDeveloper = new System.Windows.Forms.Label();
            this.SaveSettings = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPuctureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHAI)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LoginButton.Location = new System.Drawing.Point(450, 294);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(303, 52);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Авторизацiя";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // logoPuctureBox
            // 
            this.logoPuctureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPuctureBox.Image")));
            this.logoPuctureBox.InitialImage = null;
            this.logoPuctureBox.Location = new System.Drawing.Point(32, 29);
            this.logoPuctureBox.Name = "logoPuctureBox";
            this.logoPuctureBox.Size = new System.Drawing.Size(376, 356);
            this.logoPuctureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPuctureBox.TabIndex = 1;
            this.logoPuctureBox.TabStop = false;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.LoginTextBox.Location = new System.Drawing.Point(558, 192);
            this.LoginTextBox.MaxLength = 24;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(195, 35);
            this.LoginTextBox.TabIndex = 2;
            this.LoginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox_KeyDown);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.PasswordTextBox.Location = new System.Drawing.Point(558, 233);
            this.PasswordTextBox.MaxLength = 24;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(195, 35);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.loginLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loginLabel.Location = new System.Drawing.Point(462, 195);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(82, 29);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логiн:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordLabel.Location = new System.Drawing.Point(445, 236);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(107, 29);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Пароль:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ProgramName.ForeColor = System.Drawing.SystemColors.Control;
            this.ProgramName.Location = new System.Drawing.Point(444, 73);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(296, 62);
            this.ProgramName.TabIndex = 7;
            this.ProgramName.Text = "База даних для обліку\r\nстудентських груп";
            this.ProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LogoHAI
            // 
            this.LogoHAI.Image = ((System.Drawing.Image)(resources.GetObject("LogoHAI.Image")));
            this.LogoHAI.InitialImage = null;
            this.LogoHAI.Location = new System.Drawing.Point(32, 29);
            this.LogoHAI.Name = "LogoHAI";
            this.LogoHAI.Size = new System.Drawing.Size(376, 356);
            this.LogoHAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoHAI.TabIndex = 8;
            this.LogoHAI.TabStop = false;
            // 
            // AboutDeveloper
            // 
            this.AboutDeveloper.AutoSize = true;
            this.AboutDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.AboutDeveloper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(63)))));
            this.AboutDeveloper.Location = new System.Drawing.Point(309, 420);
            this.AboutDeveloper.Name = "AboutDeveloper";
            this.AboutDeveloper.Size = new System.Drawing.Size(178, 32);
            this.AboutDeveloper.TabIndex = 9;
            this.AboutDeveloper.Text = "Коваленко Олекiй 535-ст2 \r\n2021 ХАI";
            this.AboutDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveSettings
            // 
            this.SaveSettings.AutoSize = true;
            this.SaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.SaveSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveSettings.Location = new System.Drawing.Point(479, 352);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(244, 33);
            this.SaveSettings.TabIndex = 10;
            this.SaveSettings.Text = "Запам\'ятати мене";
            this.SaveSettings.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.SaveSettings);
            this.Controls.Add(this.AboutDeveloper);
            this.Controls.Add(this.LogoHAI);
            this.Controls.Add(this.ProgramName);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.logoPuctureBox);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додаток для обліку студентcьких груп";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logoPuctureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoHAI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox logoPuctureBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox LogoHAI;
        private System.Windows.Forms.Label AboutDeveloper;
        private System.Windows.Forms.CheckBox SaveSettings;
    }
}