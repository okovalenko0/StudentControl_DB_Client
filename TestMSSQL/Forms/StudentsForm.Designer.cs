
using MaterialSkin.Controls;

namespace TestMSSQL
{
    partial class StudentsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logOutButton = new System.Windows.Forms.Button();
            this.mainSearch_Fac = new System.Windows.Forms.ComboBox();
            this.mainSearchGB = new System.Windows.Forms.GroupBox();
            this.mainSearch_Label_Group = new System.Windows.Forms.Label();
            this.mainSearch_Group = new System.Windows.Forms.ComboBox();
            this.mainSearch_Label_Spec = new System.Windows.Forms.Label();
            this.mainSearch_Spec = new System.Windows.Forms.ComboBox();
            this.mainSearch_Lec = new System.Windows.Forms.ComboBox();
            this.mainSearch_Label_Lec = new System.Windows.Forms.Label();
            this.mainSearch_Label_Fac = new System.Windows.Forms.Label();
            this.getAllLecs = new System.Windows.Forms.Button();
            this.getAllSpecs = new System.Windows.Forms.Button();
            this.getAllGroups = new System.Windows.Forms.Button();
            this.getAllDataGB = new System.Windows.Forms.GroupBox();
            this.getAllFacs = new System.Windows.Forms.Button();
            this.getAllStudents = new System.Windows.Forms.Button();
            this.logOutGB = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mainSearchGB.SuspendLayout();
            this.getAllDataGB.SuspendLayout();
            this.logOutGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(6, 206);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(984, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 550);
            this.dataGridView1.TabIndex = 0;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(6, 19);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(85, 103);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Вийти";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // mainSearch_Fac
            // 
            this.mainSearch_Fac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mainSearch_Fac.FormattingEnabled = true;
            this.mainSearch_Fac.Location = new System.Drawing.Point(106, 19);
            this.mainSearch_Fac.Name = "mainSearch_Fac";
            this.mainSearch_Fac.Size = new System.Drawing.Size(459, 21);
            this.mainSearch_Fac.TabIndex = 8;
            this.mainSearch_Fac.SelectedIndexChanged += new System.EventHandler(this.mainSearchFacSelected);
            // 
            // mainSearchGB
            // 
            this.mainSearchGB.Controls.Add(this.mainSearch_Label_Group);
            this.mainSearchGB.Controls.Add(this.mainSearch_Group);
            this.mainSearchGB.Controls.Add(this.mainSearch_Label_Spec);
            this.mainSearchGB.Controls.Add(this.mainSearch_Spec);
            this.mainSearchGB.Controls.Add(this.mainSearch_Lec);
            this.mainSearchGB.Controls.Add(this.mainSearch_Label_Lec);
            this.mainSearchGB.Controls.Add(this.mainSearch_Label_Fac);
            this.mainSearchGB.Controls.Add(this.mainSearch_Fac);
            this.mainSearchGB.Location = new System.Drawing.Point(6, 71);
            this.mainSearchGB.Name = "mainSearchGB";
            this.mainSearchGB.Size = new System.Drawing.Size(571, 129);
            this.mainSearchGB.TabIndex = 9;
            this.mainSearchGB.TabStop = false;
            this.mainSearchGB.Text = "Пошук студентiв за группою";
            this.mainSearchGB.UseCompatibleTextRendering = true;
            // 
            // mainSearch_Label_Group
            // 
            this.mainSearch_Label_Group.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainSearch_Label_Group.AutoEllipsis = true;
            this.mainSearch_Label_Group.AutoSize = true;
            this.mainSearch_Label_Group.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainSearch_Label_Group.Location = new System.Drawing.Point(6, 104);
            this.mainSearch_Label_Group.Name = "mainSearch_Label_Group";
            this.mainSearch_Label_Group.Size = new System.Drawing.Size(39, 13);
            this.mainSearch_Label_Group.TabIndex = 15;
            this.mainSearch_Label_Group.Text = "Група:";
            this.mainSearch_Label_Group.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainSearch_Group
            // 
            this.mainSearch_Group.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mainSearch_Group.Enabled = false;
            this.mainSearch_Group.FormattingEnabled = true;
            this.mainSearch_Group.Location = new System.Drawing.Point(106, 101);
            this.mainSearch_Group.Name = "mainSearch_Group";
            this.mainSearch_Group.Size = new System.Drawing.Size(459, 21);
            this.mainSearch_Group.TabIndex = 14;
            this.mainSearch_Group.SelectedIndexChanged += new System.EventHandler(this.mainSearchGroupSelected);
            // 
            // mainSearch_Label_Spec
            // 
            this.mainSearch_Label_Spec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainSearch_Label_Spec.AutoEllipsis = true;
            this.mainSearch_Label_Spec.AutoSize = true;
            this.mainSearch_Label_Spec.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainSearch_Label_Spec.Location = new System.Drawing.Point(6, 77);
            this.mainSearch_Label_Spec.Name = "mainSearch_Label_Spec";
            this.mainSearch_Label_Spec.Size = new System.Drawing.Size(80, 13);
            this.mainSearch_Label_Spec.TabIndex = 13;
            this.mainSearch_Label_Spec.Text = "Спецiальнiсть:";
            this.mainSearch_Label_Spec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainSearch_Spec
            // 
            this.mainSearch_Spec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mainSearch_Spec.Enabled = false;
            this.mainSearch_Spec.FormattingEnabled = true;
            this.mainSearch_Spec.Location = new System.Drawing.Point(106, 74);
            this.mainSearch_Spec.Name = "mainSearch_Spec";
            this.mainSearch_Spec.Size = new System.Drawing.Size(459, 21);
            this.mainSearch_Spec.TabIndex = 12;
            this.mainSearch_Spec.SelectedIndexChanged += new System.EventHandler(this.mainSearchSpecSelected);
            // 
            // mainSearch_Lec
            // 
            this.mainSearch_Lec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mainSearch_Lec.Enabled = false;
            this.mainSearch_Lec.FormattingEnabled = true;
            this.mainSearch_Lec.Location = new System.Drawing.Point(106, 47);
            this.mainSearch_Lec.Name = "mainSearch_Lec";
            this.mainSearch_Lec.Size = new System.Drawing.Size(459, 21);
            this.mainSearch_Lec.TabIndex = 11;
            this.mainSearch_Lec.SelectedIndexChanged += new System.EventHandler(this.mainSearchLecSelected);
            // 
            // mainSearch_Label_Lec
            // 
            this.mainSearch_Label_Lec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainSearch_Label_Lec.AutoEllipsis = true;
            this.mainSearch_Label_Lec.AutoSize = true;
            this.mainSearch_Label_Lec.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainSearch_Label_Lec.Location = new System.Drawing.Point(6, 50);
            this.mainSearch_Label_Lec.Name = "mainSearch_Label_Lec";
            this.mainSearch_Label_Lec.Size = new System.Drawing.Size(55, 13);
            this.mainSearch_Label_Lec.TabIndex = 10;
            this.mainSearch_Label_Lec.Text = "Кафедра:";
            this.mainSearch_Label_Lec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainSearch_Label_Fac
            // 
            this.mainSearch_Label_Fac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainSearch_Label_Fac.AutoEllipsis = true;
            this.mainSearch_Label_Fac.AutoSize = true;
            this.mainSearch_Label_Fac.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainSearch_Label_Fac.Location = new System.Drawing.Point(6, 22);
            this.mainSearch_Label_Fac.Name = "mainSearch_Label_Fac";
            this.mainSearch_Label_Fac.Size = new System.Drawing.Size(66, 13);
            this.mainSearch_Label_Fac.TabIndex = 9;
            this.mainSearch_Label_Fac.Text = "Факультет:";
            this.mainSearch_Label_Fac.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // getAllLecs
            // 
            this.getAllLecs.Location = new System.Drawing.Point(6, 45);
            this.getAllLecs.Name = "getAllLecs";
            this.getAllLecs.Size = new System.Drawing.Size(230, 23);
            this.getAllLecs.TabIndex = 10;
            this.getAllLecs.Text = "Пошук всiх кафедр";
            this.getAllLecs.UseVisualStyleBackColor = true;
            this.getAllLecs.Click += new System.EventHandler(this.getAllLecs_Click);
            // 
            // getAllSpecs
            // 
            this.getAllSpecs.Location = new System.Drawing.Point(6, 72);
            this.getAllSpecs.Name = "getAllSpecs";
            this.getAllSpecs.Size = new System.Drawing.Size(230, 23);
            this.getAllSpecs.TabIndex = 11;
            this.getAllSpecs.Text = "Пошук всiх спецiальностей";
            this.getAllSpecs.UseVisualStyleBackColor = true;
            this.getAllSpecs.Click += new System.EventHandler(this.getAllSpecs_Click);
            // 
            // getAllGroups
            // 
            this.getAllGroups.Location = new System.Drawing.Point(6, 99);
            this.getAllGroups.Name = "getAllGroups";
            this.getAllGroups.Size = new System.Drawing.Size(230, 23);
            this.getAllGroups.TabIndex = 12;
            this.getAllGroups.Text = "Пошук всiх груп";
            this.getAllGroups.UseVisualStyleBackColor = true;
            this.getAllGroups.Click += new System.EventHandler(this.getAllGroups_Click);
            // 
            // getAllDataGB
            // 
            this.getAllDataGB.Controls.Add(this.getAllFacs);
            this.getAllDataGB.Controls.Add(this.getAllStudents);
            this.getAllDataGB.Controls.Add(this.getAllGroups);
            this.getAllDataGB.Controls.Add(this.getAllLecs);
            this.getAllDataGB.Controls.Add(this.getAllSpecs);
            this.getAllDataGB.Location = new System.Drawing.Point(583, 71);
            this.getAllDataGB.Name = "getAllDataGB";
            this.getAllDataGB.Size = new System.Drawing.Size(326, 129);
            this.getAllDataGB.TabIndex = 13;
            this.getAllDataGB.TabStop = false;
            this.getAllDataGB.Text = "Пошук всiх даних";
            // 
            // getAllFacs
            // 
            this.getAllFacs.Location = new System.Drawing.Point(6, 19);
            this.getAllFacs.Name = "getAllFacs";
            this.getAllFacs.Size = new System.Drawing.Size(230, 23);
            this.getAllFacs.TabIndex = 14;
            this.getAllFacs.Text = "Пошук всiх факультетiв";
            this.getAllFacs.UseVisualStyleBackColor = true;
            this.getAllFacs.Click += new System.EventHandler(this.getAllFacs_Click);
            // 
            // getAllStudents
            // 
            this.getAllStudents.Location = new System.Drawing.Point(242, 17);
            this.getAllStudents.Name = "getAllStudents";
            this.getAllStudents.Size = new System.Drawing.Size(78, 105);
            this.getAllStudents.TabIndex = 13;
            this.getAllStudents.Text = "Пошук всiх студентiв";
            this.getAllStudents.UseVisualStyleBackColor = true;
            this.getAllStudents.Click += new System.EventHandler(this.getAllStudents_Click);
            // 
            // logOutGB
            // 
            this.logOutGB.Controls.Add(this.logOutButton);
            this.logOutGB.Location = new System.Drawing.Point(915, 71);
            this.logOutGB.Name = "logOutGB";
            this.logOutGB.Size = new System.Drawing.Size(97, 129);
            this.logOutGB.TabIndex = 14;
            this.logOutGB.TabStop = false;
            this.logOutGB.Text = "Вихiд";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.logOutGB);
            this.Controls.Add(this.getAllDataGB);
            this.Controls.Add(this.mainSearchGB);
            this.Controls.Add(this.dataGridView1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "StudentsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentsForm";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.helpClicked);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeMethod);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mainSearchGB.ResumeLayout(false);
            this.mainSearchGB.PerformLayout();
            this.getAllDataGB.ResumeLayout(false);
            this.logOutGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.ComboBox mainSearch_Fac;
        private System.Windows.Forms.GroupBox mainSearchGB;
        private System.Windows.Forms.Label mainSearch_Label_Spec;
        private System.Windows.Forms.ComboBox mainSearch_Spec;
        private System.Windows.Forms.ComboBox mainSearch_Lec;
        private System.Windows.Forms.Label mainSearch_Label_Lec;
        private System.Windows.Forms.Label mainSearch_Label_Fac;
        private System.Windows.Forms.Label mainSearch_Label_Group;
        private System.Windows.Forms.ComboBox mainSearch_Group;
        private System.Windows.Forms.Button getAllLecs;
        private System.Windows.Forms.Button getAllSpecs;
        private System.Windows.Forms.Button getAllGroups;
        private System.Windows.Forms.GroupBox getAllDataGB;
        private System.Windows.Forms.Button getAllStudents;
        private System.Windows.Forms.GroupBox logOutGB;
        private System.Windows.Forms.Button getAllFacs;
    }
}