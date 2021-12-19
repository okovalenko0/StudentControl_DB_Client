
using MaterialSkin.Controls;

namespace TestMSSQL
{
    partial class AdminForm
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
            this.MainControl = new System.Windows.Forms.TabControl();
            this.FacTab = new System.Windows.Forms.TabPage();
            this.FacViewBox = new System.Windows.Forms.GroupBox();
            this.FacViewGrid = new System.Windows.Forms.DataGridView();
            this.FacEditBox = new System.Windows.Forms.GroupBox();
            this.FacEditControl = new System.Windows.Forms.TabControl();
            this.FacAddTab = new System.Windows.Forms.TabPage();
            this.FacEditTab = new System.Windows.Forms.TabPage();
            this.FacDeleteTab = new System.Windows.Forms.TabPage();
            this.LecTab = new System.Windows.Forms.TabPage();
            this.LecViewBox = new System.Windows.Forms.GroupBox();
            this.LecViewGrid = new System.Windows.Forms.DataGridView();
            this.LecEditBox = new System.Windows.Forms.GroupBox();
            this.LecEditControl = new System.Windows.Forms.TabControl();
            this.LecAddTab = new System.Windows.Forms.TabPage();
            this.LecEditTab = new System.Windows.Forms.TabPage();
            this.LecDeleteTab = new System.Windows.Forms.TabPage();
            this.SpecTab = new System.Windows.Forms.TabPage();
            this.SpecViewBox = new System.Windows.Forms.GroupBox();
            this.SpecViewGrid = new System.Windows.Forms.DataGridView();
            this.SpecEditBox = new System.Windows.Forms.GroupBox();
            this.SpecEditControl = new System.Windows.Forms.TabControl();
            this.SpecAddTab = new System.Windows.Forms.TabPage();
            this.SpecEditTab = new System.Windows.Forms.TabPage();
            this.SpecDeleteTab = new System.Windows.Forms.TabPage();
            this.GroupTab = new System.Windows.Forms.TabPage();
            this.GroupsViewBox = new System.Windows.Forms.GroupBox();
            this.GroupsViewGrid = new System.Windows.Forms.DataGridView();
            this.GroupsEditBox = new System.Windows.Forms.GroupBox();
            this.GroupsEditControl = new System.Windows.Forms.TabControl();
            this.GroupsAddTab = new System.Windows.Forms.TabPage();
            this.GroupsEditTab = new System.Windows.Forms.TabPage();
            this.GroupsDeleteTab = new System.Windows.Forms.TabPage();
            this.StudentsTab = new System.Windows.Forms.TabPage();
            this.StudentsViewBox = new System.Windows.Forms.GroupBox();
            this.StudentsViewGrid = new System.Windows.Forms.DataGridView();
            this.StudentsEditBox = new System.Windows.Forms.GroupBox();
            this.StudentsEditControl = new System.Windows.Forms.TabControl();
            this.StudentsAddTab = new System.Windows.Forms.TabPage();
            this.StudentsEditTab = new System.Windows.Forms.TabPage();
            this.StudentsDeleteTab = new System.Windows.Forms.TabPage();
            this.MainControl.SuspendLayout();
            this.FacTab.SuspendLayout();
            this.FacViewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacViewGrid)).BeginInit();
            this.FacEditBox.SuspendLayout();
            this.FacEditControl.SuspendLayout();
            this.LecTab.SuspendLayout();
            this.LecViewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecViewGrid)).BeginInit();
            this.LecEditBox.SuspendLayout();
            this.LecEditControl.SuspendLayout();
            this.SpecTab.SuspendLayout();
            this.SpecViewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecViewGrid)).BeginInit();
            this.SpecEditBox.SuspendLayout();
            this.SpecEditControl.SuspendLayout();
            this.GroupTab.SuspendLayout();
            this.GroupsViewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsViewGrid)).BeginInit();
            this.GroupsEditBox.SuspendLayout();
            this.GroupsEditControl.SuspendLayout();
            this.StudentsTab.SuspendLayout();
            this.StudentsViewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsViewGrid)).BeginInit();
            this.StudentsEditBox.SuspendLayout();
            this.StudentsEditControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainControl
            // 
            this.MainControl.Controls.Add(this.FacTab);
            this.MainControl.Controls.Add(this.LecTab);
            this.MainControl.Controls.Add(this.SpecTab);
            this.MainControl.Controls.Add(this.GroupTab);
            this.MainControl.Controls.Add(this.StudentsTab);
            this.MainControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainControl.Location = new System.Drawing.Point(12, 69);
            this.MainControl.Name = "MainControl";
            this.MainControl.SelectedIndex = 0;
            this.MainControl.Size = new System.Drawing.Size(1000, 687);
            this.MainControl.TabIndex = 0;
            this.MainControl.SelectedIndexChanged += new System.EventHandler(this.MainControl_SelectedIndexChanged);
            // 
            // FacTab
            // 
            this.FacTab.BackColor = System.Drawing.Color.White;
            this.FacTab.Controls.Add(this.FacViewBox);
            this.FacTab.Controls.Add(this.FacEditBox);
            this.FacTab.Location = new System.Drawing.Point(4, 33);
            this.FacTab.Name = "FacTab";
            this.FacTab.Padding = new System.Windows.Forms.Padding(3);
            this.FacTab.Size = new System.Drawing.Size(992, 650);
            this.FacTab.TabIndex = 0;
            this.FacTab.Text = "Факультети";
            // 
            // FacViewBox
            // 
            this.FacViewBox.Controls.Add(this.FacViewGrid);
            this.FacViewBox.Location = new System.Drawing.Point(10, 7);
            this.FacViewBox.Name = "FacViewBox";
            this.FacViewBox.Size = new System.Drawing.Size(972, 415);
            this.FacViewBox.TabIndex = 3;
            this.FacViewBox.TabStop = false;
            this.FacViewBox.Text = "Перегляд даних";
            // 
            // FacViewGrid
            // 
            this.FacViewGrid.AllowUserToAddRows = false;
            this.FacViewGrid.AllowUserToDeleteRows = false;
            this.FacViewGrid.AllowUserToResizeColumns = false;
            this.FacViewGrid.AllowUserToResizeRows = false;
            this.FacViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FacViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacViewGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.FacViewGrid.Location = new System.Drawing.Point(6, 28);
            this.FacViewGrid.Name = "FacViewGrid";
            this.FacViewGrid.ReadOnly = true;
            this.FacViewGrid.RowHeadersVisible = false;
            this.FacViewGrid.Size = new System.Drawing.Size(960, 381);
            this.FacViewGrid.TabIndex = 1;
            // 
            // FacEditBox
            // 
            this.FacEditBox.Controls.Add(this.FacEditControl);
            this.FacEditBox.Location = new System.Drawing.Point(10, 428);
            this.FacEditBox.Name = "FacEditBox";
            this.FacEditBox.Size = new System.Drawing.Size(972, 216);
            this.FacEditBox.TabIndex = 2;
            this.FacEditBox.TabStop = false;
            this.FacEditBox.Text = "Редагування даних";
            // 
            // FacEditControl
            // 
            this.FacEditControl.Controls.Add(this.FacAddTab);
            this.FacEditControl.Controls.Add(this.FacEditTab);
            this.FacEditControl.Controls.Add(this.FacDeleteTab);
            this.FacEditControl.Location = new System.Drawing.Point(6, 28);
            this.FacEditControl.Name = "FacEditControl";
            this.FacEditControl.SelectedIndex = 0;
            this.FacEditControl.Size = new System.Drawing.Size(960, 182);
            this.FacEditControl.TabIndex = 0;
            this.FacEditControl.SelectedIndexChanged += new System.EventHandler(this.FacEditControl_SelectedIndexChanged);
            // 
            // FacAddTab
            // 
            this.FacAddTab.Location = new System.Drawing.Point(4, 33);
            this.FacAddTab.Name = "FacAddTab";
            this.FacAddTab.Padding = new System.Windows.Forms.Padding(3);
            this.FacAddTab.Size = new System.Drawing.Size(952, 145);
            this.FacAddTab.TabIndex = 0;
            this.FacAddTab.Text = "Додати данi";
            this.FacAddTab.UseVisualStyleBackColor = true;
            // 
            // FacEditTab
            // 
            this.FacEditTab.Location = new System.Drawing.Point(4, 33);
            this.FacEditTab.Name = "FacEditTab";
            this.FacEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.FacEditTab.Size = new System.Drawing.Size(952, 145);
            this.FacEditTab.TabIndex = 1;
            this.FacEditTab.Text = "Редагувати данi";
            this.FacEditTab.UseVisualStyleBackColor = true;
            // 
            // FacDeleteTab
            // 
            this.FacDeleteTab.Location = new System.Drawing.Point(4, 33);
            this.FacDeleteTab.Name = "FacDeleteTab";
            this.FacDeleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.FacDeleteTab.Size = new System.Drawing.Size(952, 145);
            this.FacDeleteTab.TabIndex = 2;
            this.FacDeleteTab.Text = "Видалити данi";
            this.FacDeleteTab.UseVisualStyleBackColor = true;
            // 
            // LecTab
            // 
            this.LecTab.BackColor = System.Drawing.Color.White;
            this.LecTab.Controls.Add(this.LecViewBox);
            this.LecTab.Controls.Add(this.LecEditBox);
            this.LecTab.Location = new System.Drawing.Point(4, 33);
            this.LecTab.Name = "LecTab";
            this.LecTab.Padding = new System.Windows.Forms.Padding(3);
            this.LecTab.Size = new System.Drawing.Size(992, 650);
            this.LecTab.TabIndex = 1;
            this.LecTab.Text = "Кафедри";
            // 
            // LecViewBox
            // 
            this.LecViewBox.Controls.Add(this.LecViewGrid);
            this.LecViewBox.Location = new System.Drawing.Point(10, 7);
            this.LecViewBox.Name = "LecViewBox";
            this.LecViewBox.Size = new System.Drawing.Size(972, 415);
            this.LecViewBox.TabIndex = 5;
            this.LecViewBox.TabStop = false;
            this.LecViewBox.Text = "Перегляд даних";
            // 
            // LecViewGrid
            // 
            this.LecViewGrid.AllowUserToAddRows = false;
            this.LecViewGrid.AllowUserToDeleteRows = false;
            this.LecViewGrid.AllowUserToResizeColumns = false;
            this.LecViewGrid.AllowUserToResizeRows = false;
            this.LecViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LecViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecViewGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.LecViewGrid.Location = new System.Drawing.Point(6, 28);
            this.LecViewGrid.Name = "LecViewGrid";
            this.LecViewGrid.ReadOnly = true;
            this.LecViewGrid.RowHeadersVisible = false;
            this.LecViewGrid.Size = new System.Drawing.Size(960, 381);
            this.LecViewGrid.TabIndex = 2;
            // 
            // LecEditBox
            // 
            this.LecEditBox.Controls.Add(this.LecEditControl);
            this.LecEditBox.Location = new System.Drawing.Point(10, 428);
            this.LecEditBox.Name = "LecEditBox";
            this.LecEditBox.Size = new System.Drawing.Size(972, 216);
            this.LecEditBox.TabIndex = 4;
            this.LecEditBox.TabStop = false;
            this.LecEditBox.Text = "Редагування даних";
            // 
            // LecEditControl
            // 
            this.LecEditControl.Controls.Add(this.LecAddTab);
            this.LecEditControl.Controls.Add(this.LecEditTab);
            this.LecEditControl.Controls.Add(this.LecDeleteTab);
            this.LecEditControl.Location = new System.Drawing.Point(6, 28);
            this.LecEditControl.Name = "LecEditControl";
            this.LecEditControl.SelectedIndex = 0;
            this.LecEditControl.Size = new System.Drawing.Size(960, 182);
            this.LecEditControl.TabIndex = 0;
            // 
            // LecAddTab
            // 
            this.LecAddTab.Location = new System.Drawing.Point(4, 33);
            this.LecAddTab.Name = "LecAddTab";
            this.LecAddTab.Padding = new System.Windows.Forms.Padding(3);
            this.LecAddTab.Size = new System.Drawing.Size(952, 145);
            this.LecAddTab.TabIndex = 0;
            this.LecAddTab.Text = "Додати данi";
            this.LecAddTab.UseVisualStyleBackColor = true;
            // 
            // LecEditTab
            // 
            this.LecEditTab.Location = new System.Drawing.Point(4, 33);
            this.LecEditTab.Name = "LecEditTab";
            this.LecEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.LecEditTab.Size = new System.Drawing.Size(952, 145);
            this.LecEditTab.TabIndex = 1;
            this.LecEditTab.Text = "Редагувати данi";
            this.LecEditTab.UseVisualStyleBackColor = true;
            // 
            // LecDeleteTab
            // 
            this.LecDeleteTab.Location = new System.Drawing.Point(4, 33);
            this.LecDeleteTab.Name = "LecDeleteTab";
            this.LecDeleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.LecDeleteTab.Size = new System.Drawing.Size(952, 145);
            this.LecDeleteTab.TabIndex = 2;
            this.LecDeleteTab.Text = "Видалити данi";
            this.LecDeleteTab.UseVisualStyleBackColor = true;
            // 
            // SpecTab
            // 
            this.SpecTab.BackColor = System.Drawing.Color.White;
            this.SpecTab.Controls.Add(this.SpecViewBox);
            this.SpecTab.Controls.Add(this.SpecEditBox);
            this.SpecTab.Location = new System.Drawing.Point(4, 33);
            this.SpecTab.Name = "SpecTab";
            this.SpecTab.Padding = new System.Windows.Forms.Padding(3);
            this.SpecTab.Size = new System.Drawing.Size(992, 650);
            this.SpecTab.TabIndex = 2;
            this.SpecTab.Text = "Спецiальностi";
            // 
            // SpecViewBox
            // 
            this.SpecViewBox.Controls.Add(this.SpecViewGrid);
            this.SpecViewBox.Location = new System.Drawing.Point(10, 7);
            this.SpecViewBox.Name = "SpecViewBox";
            this.SpecViewBox.Size = new System.Drawing.Size(972, 415);
            this.SpecViewBox.TabIndex = 5;
            this.SpecViewBox.TabStop = false;
            this.SpecViewBox.Text = "Перегляд даних";
            // 
            // SpecViewGrid
            // 
            this.SpecViewGrid.AllowUserToAddRows = false;
            this.SpecViewGrid.AllowUserToDeleteRows = false;
            this.SpecViewGrid.AllowUserToResizeColumns = false;
            this.SpecViewGrid.AllowUserToResizeRows = false;
            this.SpecViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SpecViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecViewGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SpecViewGrid.Location = new System.Drawing.Point(6, 28);
            this.SpecViewGrid.Name = "SpecViewGrid";
            this.SpecViewGrid.ReadOnly = true;
            this.SpecViewGrid.RowHeadersVisible = false;
            this.SpecViewGrid.Size = new System.Drawing.Size(960, 381);
            this.SpecViewGrid.TabIndex = 2;
            // 
            // SpecEditBox
            // 
            this.SpecEditBox.Controls.Add(this.SpecEditControl);
            this.SpecEditBox.Location = new System.Drawing.Point(10, 428);
            this.SpecEditBox.Name = "SpecEditBox";
            this.SpecEditBox.Size = new System.Drawing.Size(972, 216);
            this.SpecEditBox.TabIndex = 4;
            this.SpecEditBox.TabStop = false;
            this.SpecEditBox.Text = "Редагування даних";
            // 
            // SpecEditControl
            // 
            this.SpecEditControl.Controls.Add(this.SpecAddTab);
            this.SpecEditControl.Controls.Add(this.SpecEditTab);
            this.SpecEditControl.Controls.Add(this.SpecDeleteTab);
            this.SpecEditControl.Location = new System.Drawing.Point(6, 28);
            this.SpecEditControl.Name = "SpecEditControl";
            this.SpecEditControl.SelectedIndex = 0;
            this.SpecEditControl.Size = new System.Drawing.Size(960, 182);
            this.SpecEditControl.TabIndex = 0;
            // 
            // SpecAddTab
            // 
            this.SpecAddTab.Location = new System.Drawing.Point(4, 33);
            this.SpecAddTab.Name = "SpecAddTab";
            this.SpecAddTab.Padding = new System.Windows.Forms.Padding(3);
            this.SpecAddTab.Size = new System.Drawing.Size(952, 145);
            this.SpecAddTab.TabIndex = 0;
            this.SpecAddTab.Text = "Додати данi";
            this.SpecAddTab.UseVisualStyleBackColor = true;
            // 
            // SpecEditTab
            // 
            this.SpecEditTab.Location = new System.Drawing.Point(4, 33);
            this.SpecEditTab.Name = "SpecEditTab";
            this.SpecEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.SpecEditTab.Size = new System.Drawing.Size(952, 145);
            this.SpecEditTab.TabIndex = 1;
            this.SpecEditTab.Text = "Редагувати данi";
            this.SpecEditTab.UseVisualStyleBackColor = true;
            // 
            // SpecDeleteTab
            // 
            this.SpecDeleteTab.Location = new System.Drawing.Point(4, 33);
            this.SpecDeleteTab.Name = "SpecDeleteTab";
            this.SpecDeleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.SpecDeleteTab.Size = new System.Drawing.Size(952, 145);
            this.SpecDeleteTab.TabIndex = 2;
            this.SpecDeleteTab.Text = "Видалити данi";
            this.SpecDeleteTab.UseVisualStyleBackColor = true;
            // 
            // GroupTab
            // 
            this.GroupTab.BackColor = System.Drawing.Color.White;
            this.GroupTab.Controls.Add(this.GroupsViewBox);
            this.GroupTab.Controls.Add(this.GroupsEditBox);
            this.GroupTab.Location = new System.Drawing.Point(4, 33);
            this.GroupTab.Name = "GroupTab";
            this.GroupTab.Padding = new System.Windows.Forms.Padding(3);
            this.GroupTab.Size = new System.Drawing.Size(992, 650);
            this.GroupTab.TabIndex = 3;
            this.GroupTab.Text = "Групи";
            // 
            // GroupsViewBox
            // 
            this.GroupsViewBox.Controls.Add(this.GroupsViewGrid);
            this.GroupsViewBox.Location = new System.Drawing.Point(10, 7);
            this.GroupsViewBox.Name = "GroupsViewBox";
            this.GroupsViewBox.Size = new System.Drawing.Size(972, 415);
            this.GroupsViewBox.TabIndex = 5;
            this.GroupsViewBox.TabStop = false;
            this.GroupsViewBox.Text = "Перегляд даних";
            // 
            // GroupsViewGrid
            // 
            this.GroupsViewGrid.AllowUserToAddRows = false;
            this.GroupsViewGrid.AllowUserToDeleteRows = false;
            this.GroupsViewGrid.AllowUserToResizeColumns = false;
            this.GroupsViewGrid.AllowUserToResizeRows = false;
            this.GroupsViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GroupsViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsViewGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GroupsViewGrid.Location = new System.Drawing.Point(6, 28);
            this.GroupsViewGrid.Name = "GroupsViewGrid";
            this.GroupsViewGrid.ReadOnly = true;
            this.GroupsViewGrid.RowHeadersVisible = false;
            this.GroupsViewGrid.Size = new System.Drawing.Size(960, 381);
            this.GroupsViewGrid.TabIndex = 2;
            // 
            // GroupsEditBox
            // 
            this.GroupsEditBox.Controls.Add(this.GroupsEditControl);
            this.GroupsEditBox.Location = new System.Drawing.Point(10, 428);
            this.GroupsEditBox.Name = "GroupsEditBox";
            this.GroupsEditBox.Size = new System.Drawing.Size(972, 216);
            this.GroupsEditBox.TabIndex = 4;
            this.GroupsEditBox.TabStop = false;
            this.GroupsEditBox.Text = "Редагування даних";
            // 
            // GroupsEditControl
            // 
            this.GroupsEditControl.Controls.Add(this.GroupsAddTab);
            this.GroupsEditControl.Controls.Add(this.GroupsEditTab);
            this.GroupsEditControl.Controls.Add(this.GroupsDeleteTab);
            this.GroupsEditControl.Location = new System.Drawing.Point(6, 28);
            this.GroupsEditControl.Name = "GroupsEditControl";
            this.GroupsEditControl.SelectedIndex = 0;
            this.GroupsEditControl.Size = new System.Drawing.Size(960, 182);
            this.GroupsEditControl.TabIndex = 0;
            // 
            // GroupsAddTab
            // 
            this.GroupsAddTab.Location = new System.Drawing.Point(4, 33);
            this.GroupsAddTab.Name = "GroupsAddTab";
            this.GroupsAddTab.Padding = new System.Windows.Forms.Padding(3);
            this.GroupsAddTab.Size = new System.Drawing.Size(952, 145);
            this.GroupsAddTab.TabIndex = 0;
            this.GroupsAddTab.Text = "Додати данi";
            this.GroupsAddTab.UseVisualStyleBackColor = true;
            // 
            // GroupsEditTab
            // 
            this.GroupsEditTab.Location = new System.Drawing.Point(4, 33);
            this.GroupsEditTab.Name = "GroupsEditTab";
            this.GroupsEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.GroupsEditTab.Size = new System.Drawing.Size(952, 145);
            this.GroupsEditTab.TabIndex = 1;
            this.GroupsEditTab.Text = "Редагувати данi";
            this.GroupsEditTab.UseVisualStyleBackColor = true;
            // 
            // GroupsDeleteTab
            // 
            this.GroupsDeleteTab.Location = new System.Drawing.Point(4, 33);
            this.GroupsDeleteTab.Name = "GroupsDeleteTab";
            this.GroupsDeleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.GroupsDeleteTab.Size = new System.Drawing.Size(952, 145);
            this.GroupsDeleteTab.TabIndex = 2;
            this.GroupsDeleteTab.Text = "Видалити данi";
            this.GroupsDeleteTab.UseVisualStyleBackColor = true;
            // 
            // StudentsTab
            // 
            this.StudentsTab.BackColor = System.Drawing.Color.White;
            this.StudentsTab.Controls.Add(this.StudentsViewBox);
            this.StudentsTab.Controls.Add(this.StudentsEditBox);
            this.StudentsTab.Location = new System.Drawing.Point(4, 33);
            this.StudentsTab.Name = "StudentsTab";
            this.StudentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsTab.Size = new System.Drawing.Size(992, 650);
            this.StudentsTab.TabIndex = 4;
            this.StudentsTab.Text = "Студенти";
            // 
            // StudentsViewBox
            // 
            this.StudentsViewBox.Controls.Add(this.StudentsViewGrid);
            this.StudentsViewBox.Location = new System.Drawing.Point(10, 7);
            this.StudentsViewBox.Name = "StudentsViewBox";
            this.StudentsViewBox.Size = new System.Drawing.Size(972, 415);
            this.StudentsViewBox.TabIndex = 5;
            this.StudentsViewBox.TabStop = false;
            this.StudentsViewBox.Text = "Перегляд даних";
            // 
            // StudentsViewGrid
            // 
            this.StudentsViewGrid.AllowUserToAddRows = false;
            this.StudentsViewGrid.AllowUserToDeleteRows = false;
            this.StudentsViewGrid.AllowUserToResizeColumns = false;
            this.StudentsViewGrid.AllowUserToResizeRows = false;
            this.StudentsViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsViewGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StudentsViewGrid.Location = new System.Drawing.Point(6, 28);
            this.StudentsViewGrid.Name = "StudentsViewGrid";
            this.StudentsViewGrid.ReadOnly = true;
            this.StudentsViewGrid.RowHeadersVisible = false;
            this.StudentsViewGrid.Size = new System.Drawing.Size(960, 381);
            this.StudentsViewGrid.TabIndex = 2;
            // 
            // StudentsEditBox
            // 
            this.StudentsEditBox.Controls.Add(this.StudentsEditControl);
            this.StudentsEditBox.Location = new System.Drawing.Point(10, 428);
            this.StudentsEditBox.Name = "StudentsEditBox";
            this.StudentsEditBox.Size = new System.Drawing.Size(972, 216);
            this.StudentsEditBox.TabIndex = 4;
            this.StudentsEditBox.TabStop = false;
            this.StudentsEditBox.Text = "Редагування даних";
            // 
            // StudentsEditControl
            // 
            this.StudentsEditControl.Controls.Add(this.StudentsAddTab);
            this.StudentsEditControl.Controls.Add(this.StudentsEditTab);
            this.StudentsEditControl.Controls.Add(this.StudentsDeleteTab);
            this.StudentsEditControl.Location = new System.Drawing.Point(6, 28);
            this.StudentsEditControl.Name = "StudentsEditControl";
            this.StudentsEditControl.SelectedIndex = 0;
            this.StudentsEditControl.Size = new System.Drawing.Size(960, 182);
            this.StudentsEditControl.TabIndex = 0;
            // 
            // StudentsAddTab
            // 
            this.StudentsAddTab.Location = new System.Drawing.Point(4, 33);
            this.StudentsAddTab.Name = "StudentsAddTab";
            this.StudentsAddTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsAddTab.Size = new System.Drawing.Size(952, 145);
            this.StudentsAddTab.TabIndex = 0;
            this.StudentsAddTab.Text = "Додати данi";
            this.StudentsAddTab.UseVisualStyleBackColor = true;
            // 
            // StudentsEditTab
            // 
            this.StudentsEditTab.Location = new System.Drawing.Point(4, 33);
            this.StudentsEditTab.Name = "StudentsEditTab";
            this.StudentsEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsEditTab.Size = new System.Drawing.Size(952, 145);
            this.StudentsEditTab.TabIndex = 1;
            this.StudentsEditTab.Text = "Редагувати данi";
            this.StudentsEditTab.UseVisualStyleBackColor = true;
            // 
            // StudentsDeleteTab
            // 
            this.StudentsDeleteTab.Location = new System.Drawing.Point(4, 33);
            this.StudentsDeleteTab.Name = "StudentsDeleteTab";
            this.StudentsDeleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsDeleteTab.Size = new System.Drawing.Size(952, 145);
            this.StudentsDeleteTab.TabIndex = 2;
            this.StudentsDeleteTab.Text = "Видалити данi";
            this.StudentsDeleteTab.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.MainControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "AdminForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Адмiн форма перегляду даних";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeMethod);
            this.MainControl.ResumeLayout(false);
            this.FacTab.ResumeLayout(false);
            this.FacViewBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacViewGrid)).EndInit();
            this.FacEditBox.ResumeLayout(false);
            this.FacEditControl.ResumeLayout(false);
            this.LecTab.ResumeLayout(false);
            this.LecViewBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LecViewGrid)).EndInit();
            this.LecEditBox.ResumeLayout(false);
            this.LecEditControl.ResumeLayout(false);
            this.SpecTab.ResumeLayout(false);
            this.SpecViewBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpecViewGrid)).EndInit();
            this.SpecEditBox.ResumeLayout(false);
            this.SpecEditControl.ResumeLayout(false);
            this.GroupTab.ResumeLayout(false);
            this.GroupsViewBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupsViewGrid)).EndInit();
            this.GroupsEditBox.ResumeLayout(false);
            this.GroupsEditControl.ResumeLayout(false);
            this.StudentsTab.ResumeLayout(false);
            this.StudentsViewBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsViewGrid)).EndInit();
            this.StudentsEditBox.ResumeLayout(false);
            this.StudentsEditControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainControl;

        private System.Windows.Forms.TabPage FacTab;
        private System.Windows.Forms.TabPage LecTab;
        private System.Windows.Forms.TabPage SpecTab;
        private System.Windows.Forms.TabPage GroupTab;
        private System.Windows.Forms.TabPage StudentsTab;

        private System.Windows.Forms.GroupBox FacViewBox;
        private System.Windows.Forms.DataGridView FacViewGrid;
        private System.Windows.Forms.GroupBox FacEditBox;
        private System.Windows.Forms.TabControl FacEditControl;
        private System.Windows.Forms.TabPage FacAddTab;
        private System.Windows.Forms.TabPage FacEditTab;
        private System.Windows.Forms.TabPage FacDeleteTab;

        private System.Windows.Forms.GroupBox LecViewBox;
        private System.Windows.Forms.GroupBox LecEditBox;
        private System.Windows.Forms.TabControl LecEditControl;
        private System.Windows.Forms.TabPage LecAddTab;
        private System.Windows.Forms.TabPage LecEditTab;
        private System.Windows.Forms.TabPage LecDeleteTab;

        private System.Windows.Forms.GroupBox SpecViewBox;
        private System.Windows.Forms.GroupBox SpecEditBox;
        private System.Windows.Forms.TabControl SpecEditControl;
        private System.Windows.Forms.TabPage SpecAddTab;
        private System.Windows.Forms.TabPage SpecEditTab;
        private System.Windows.Forms.TabPage SpecDeleteTab;

        private System.Windows.Forms.GroupBox GroupsViewBox;
        private System.Windows.Forms.GroupBox GroupsEditBox;
        private System.Windows.Forms.TabControl GroupsEditControl;
        private System.Windows.Forms.TabPage GroupsAddTab;
        private System.Windows.Forms.TabPage GroupsEditTab;
        private System.Windows.Forms.TabPage GroupsDeleteTab;

        private System.Windows.Forms.GroupBox StudentsViewBox;
        private System.Windows.Forms.GroupBox StudentsEditBox;
        private System.Windows.Forms.TabControl StudentsEditControl;
        private System.Windows.Forms.TabPage StudentsAddTab;
        private System.Windows.Forms.TabPage StudentsEditTab;
        private System.Windows.Forms.TabPage StudentsDeleteTab;
        private System.Windows.Forms.DataGridView LecViewGrid;
        private System.Windows.Forms.DataGridView SpecViewGrid;
        private System.Windows.Forms.DataGridView GroupsViewGrid;
        private System.Windows.Forms.DataGridView StudentsViewGrid;
    }
}

