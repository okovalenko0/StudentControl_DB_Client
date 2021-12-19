
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
            this.login_Button = new System.Windows.Forms.Button();
            this.saveSettings = new System.Windows.Forms.CheckBox();
            this.login_Label = new System.Windows.Forms.Label();
            this.password_Label = new System.Windows.Forms.Label();
            this.login_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(15, 55);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(75, 23);
            this.login_Button.TabIndex = 0;
            this.login_Button.Text = "Войти";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // saveSettings
            // 
            this.saveSettings.AutoSize = true;
            this.saveSettings.Location = new System.Drawing.Point(96, 59);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(82, 17);
            this.saveSettings.TabIndex = 1;
            this.saveSettings.Text = "Запомнить";
            this.saveSettings.UseVisualStyleBackColor = true;
            // 
            // login_Label
            // 
            this.login_Label.AutoSize = true;
            this.login_Label.Location = new System.Drawing.Point(12, 9);
            this.login_Label.Name = "login_Label";
            this.login_Label.Size = new System.Drawing.Size(41, 13);
            this.login_Label.TabIndex = 2;
            this.login_Label.Text = "Логин:";
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Location = new System.Drawing.Point(12, 32);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(48, 13);
            this.password_Label.TabIndex = 3;
            this.password_Label.Text = "Пароль:";
            // 
            // login_TextBox
            // 
            this.login_TextBox.Location = new System.Drawing.Point(55, 6);
            this.login_TextBox.Name = "login_TextBox";
            this.login_TextBox.Size = new System.Drawing.Size(123, 20);
            this.login_TextBox.TabIndex = 4;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(55, 29);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.PasswordChar = '*';
            this.password_TextBox.Size = new System.Drawing.Size(123, 20);
            this.password_TextBox.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 85);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.login_TextBox);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.login_Label);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.login_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(196, 124);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(196, 124);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.CheckBox saveSettings;
        private System.Windows.Forms.Label login_Label;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.TextBox login_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
    }
}