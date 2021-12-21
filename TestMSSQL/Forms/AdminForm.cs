using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TestMSSQL.FormActions;

namespace TestMSSQL
{
    public partial class AdminForm : MaterialForm
    {
        #region Global Variables
        private string TextPattern = @"^(?=.{1,80}$)[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ]+(?:[-`', ][а-щА-ЩЬьЮюЯяЇїІіЄєҐґ]+)*$";
        private string NumberPattern = @"^(?=.{1,80}$)[0-9]+(?:[0-9]+)*$";
        private string ComboPattern = @"^(?=.{1,80}$)[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ0-9]+(?:[-][а-щА-ЩЬьЮюЯяЇїІіЄєҐґ0-9]+)*$";
        private string TicketPattern = @"^[A-Z]{2}[0-9]{8}$";
        private string RecordPattern = @"^[0-9]{6}$";
        #endregion

        #region Form Activities
        public AdminForm(Form prevForm)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void activationMethod(object sender, EventArgs e)
        {
            FacActions.LoadTable(FacViewGrid, MainControl.SelectedIndex);
        }

        private void closeMethod(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Main Activities
        private void MainControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MainControl.SelectedIndex)
            {
                case 0:
                    FacActions.LoadTable(FacViewGrid, MainControl.SelectedIndex);
                    break;
                case 1:
                    LecActions.LoadTable(LecViewGrid, MainControl.SelectedIndex);
                    break;
                case 2:
                    SpecActions.LoadTable(SpecViewGrid, MainControl.SelectedIndex);
                    break;
                case 3:
                    GrpActions.LoadTable(GroupsViewGrid, MainControl.SelectedIndex);
                    break;
                case 4:
                    StdActions.LoadTable(StudentsViewGrid, MainControl.SelectedIndex);
                    break;
                default:
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private bool StrRegexCheck(string check)
        {
            Match match = Regex.Match(check, TextPattern);
            if (match.Success) return true;
            else return false;
        }

        private bool NumRegexCheck(string check)
        {
            Match match = Regex.Match(check, NumberPattern);
            if (match.Success) return true;
            else return false;
        }

        private bool ComboRegexCheck(string check)
        {
            Match match = Regex.Match(check, ComboPattern);
            if (match.Success) return true;
            else return false;
        }

        private bool TicketRegexCheck(string check)
        {
            Match match = Regex.Match(check, TicketPattern);
            if (match.Success) return true;
            else return false;
        }

        private bool RecordRegexCheck(string check)
        {
            Match match = Regex.Match(check, RecordPattern);
            if (match.Success) return true;
            else return false;
        }
        #endregion

        #region Faculty Activities
        private string FacCellIndex = "";
        private void FacInsertToTextBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FacCellIndex = FacViewGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                FacEditTextbox.Text = FacViewGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                FacDeleteTextbox.Text = FacViewGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void FacAddButton_Click(object sender, EventArgs e)
        {
            if (StrRegexCheck(FacAddTextbox.Text))
            {
                DBDataOperations.AddData("Faculties", "FacName", "'" + FacAddTextbox.Text + "'");
                FacActions.LoadTable(FacViewGrid, MainControl.SelectedIndex);
            }
            else MessageBox.Show("Введiть коректну назву факультету (тiльки лiтери!)");
        }

        private void FacEditButton_Click(object sender, EventArgs e)
        {
            if (StrRegexCheck(FacEditTextbox.Text))
            {
                DBDataOperations.EditData("Faculties", "FacName='" + FacEditTextbox.Text + "'", "FacID =" + FacCellIndex);
                FacActions.LoadTable(FacViewGrid, MainControl.SelectedIndex);
            }
            else MessageBox.Show("Введiть коректну назву факультету (тiльки лiтери!)");
        }

        private void FacDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Пiдтвердiть видалення факультету '" + FacDeleteTextbox.Text + "'!", "УВАГА", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBDataOperations.DeleteData("Faculties", "FacName", FacDeleteTextbox.Text);
                FacActions.LoadTable(FacViewGrid, MainControl.SelectedIndex);
            }
        }

        #endregion

        #region Lecterns Activities
        private string SelectedLec = "";
        private void LecInsertToTextBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedLec = LecViewGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                LecEditTextbox_FacNumber.Text = LecViewGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                LecEditTextbox_LecNumber.Text = LecViewGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                LecEditTextbox_LecName.Text = LecViewGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                LecDeleteTextbox_FacNumber.Text = LecViewGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                LecDeleteTextbox_LecNumber.Text = LecViewGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                LecDeleteTextbox_LecName.Text = LecViewGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void LecAddButton_Click(object sender, EventArgs e)
        {
            if (NumRegexCheck(LecAddTextbox_LecNumber.Text))
            {
                if (NumRegexCheck(LecAddTextbox_FacNumber.Text))
                {
                    if (StrRegexCheck(LecAddTextbox_LecName.Text))
                    {
                        string data = "'" + LecAddTextbox_LecNumber.Text + "','" + LecAddTextbox_FacNumber.Text + "','" + LecAddTextbox_LecName.Text + "'";
                        DBDataOperations.AddData("Lecterns", "LecID, LecFacID, LecName", data);
                        LecActions.LoadTable(LecViewGrid, MainControl.SelectedIndex);
                    }
                    else MessageBox.Show("Введiть коректну назву кафедри (тiльки лiтери!)");
                }
                else MessageBox.Show("Введiть коректний номер факультету (тiльки цифри!)");
            }
            else MessageBox.Show("Введiть коректний номер кафедри (тiльки цифри!)");
        }

        private void LecEditButton_Click(object sender, EventArgs e)
        {
            if (NumRegexCheck(LecEditTextbox_LecNumber.Text))
            {
                if (NumRegexCheck(LecEditTextbox_FacNumber.Text))
                {
                    if (StrRegexCheck(LecEditTextbox_LecName.Text))
                    {
                        string data = "LecID=" + LecEditTextbox_LecNumber.Text + ",LecFacID=" + LecEditTextbox_FacNumber.Text + ",LecName='" + LecEditTextbox_LecName.Text + "'";
                        DBDataOperations.EditData("Lecterns", data, "LecName='" + SelectedLec + "'");
                        LecActions.LoadTable(LecViewGrid, MainControl.SelectedIndex);
                    }
                    else MessageBox.Show("Введiть коректну назву кафедри (тiльки лiтери!)");
                }
                else MessageBox.Show("Введiть коректний номер факультету (тiльки цифри!)");
            }
            else MessageBox.Show("Введiть коректний номер кафедри (тiльки цифри!)");
        }

        private void LecDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Пiдтвердiть видалення кафедри '" + LecDeleteTextbox_LecName.Text + "'!", "УВАГА", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBDataOperations.DeleteData("Lecterns", "LecName", LecDeleteTextbox_LecName.Text);
                LecActions.LoadTable(LecViewGrid, MainControl.SelectedIndex);
            }
        }
        #endregion

        #region Specialitys Activities
        private string SelectedSpec = "";
        private void SpecInsertToTextBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedSpec = SpecViewGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                SpecEditTextbox_LecNumber.Text = SpecViewGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                SpecEditTextbox_SpecNumber.Text = SpecViewGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                SpecEditTextbox_SpecName.Text = SpecViewGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                SpecEditTextbox_StudyName.Text = SpecViewGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                SpecDeleteTextbox_LecNumber.Text = SpecViewGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                SpecDeleteTextbox_SpecNumber.Text = SpecViewGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                SpecDeleteTextbox_SpecName.Text = SpecViewGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                SpecDeleteTextbox_StudyName.Text = SpecViewGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void SpecAddButton_Click(object sender, EventArgs e)
        {
            if (NumRegexCheck(SpecAddTextbox_SpecNumber.Text))
            {
                if (NumRegexCheck(SpecAddTextbox_LecNumber.Text))
                {
                    if (StrRegexCheck(SpecAddTextbox_SpecName.Text))
                    {
                        if (StrRegexCheck(SpecAddTextbox_StudyName.Text))
                        {
                            string data = "'" + SpecAddTextbox_SpecNumber.Text + "','" + SpecAddTextbox_LecNumber.Text + "','" + SpecAddTextbox_SpecName.Text + "','" + SpecAddTextbox_StudyName.Text + "'";
                            DBDataOperations.AddData("Specialitys", "SpecID, SpecLecID, SpecName, SpecProg", data);
                            SpecActions.LoadTable(SpecViewGrid, MainControl.SelectedIndex);
                        }
                        else MessageBox.Show("Введiть коректну назву освiтньоi програми (тiльки лiтери!)");
                    }
                    else MessageBox.Show("Введiть коректну назву спецiальностi (тiльки лiтери!)");
                }
                else MessageBox.Show("Введiть коректний номер кафедри (тiльки цифри!)");
            }
            else MessageBox.Show("Введiть коректний номер спецiальностi (тiльки цифри!)");
        }

        private void SpecEditButton_Click(object sender, EventArgs e)
        {
            if (NumRegexCheck(SpecEditTextbox_SpecNumber.Text))
            {
                if (NumRegexCheck(SpecEditTextbox_LecNumber.Text))
                {
                    if (StrRegexCheck(SpecEditTextbox_SpecName.Text))
                    {
                        if (StrRegexCheck(SpecEditTextbox_StudyName.Text))
                        {
                            string data = "SpecID=" + SpecEditTextbox_SpecNumber.Text + ",SpecLecID=" + SpecEditTextbox_LecNumber.Text + ",SpecName='" + SpecEditTextbox_SpecName.Text + "',SpecProg='" + SpecEditTextbox_StudyName.Text + "'";
                            DBDataOperations.EditData("Specialitys", data, "ID=" + SelectedSpec);
                            SpecActions.LoadTable(SpecViewGrid, MainControl.SelectedIndex);
                        }
                        else MessageBox.Show("Введiть коректну назву освiтньоi програми (тiльки лiтери!)");
                    }
                    else MessageBox.Show("Введiть коректну назву спецiальностi (тiльки лiтери!)");
                }
                else MessageBox.Show("Введiть коректний номер кафедри (тiльки цифри!)");
            }
            else MessageBox.Show("Введiть коректний номер спецiальностi (тiльки цифри!)");
        }

        private void SpecDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Пiдтвердiть видалення освiтньоi програми '" + SpecDeleteTextbox_StudyName.Text + "'!", "УВАГА", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBDataOperations.DeleteData("Specialitys", "ID", SelectedSpec);
                SpecActions.LoadTable(SpecViewGrid, MainControl.SelectedIndex);
            }
        }
        #endregion

        #region Groups Activities
        private string SelectedGrp = "";
        private void GrpInsertToTextBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedGrp = GroupsViewGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

                GrpEditTextbox_SpecID.Text = GroupsViewGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                GrpEditTextbox_GrpName.Text = GroupsViewGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                GrpEditDate_StudyDate.Value = Convert.ToDateTime(GroupsViewGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (GroupsViewGrid.Rows[e.RowIndex].Cells[3].Value.ToString() != "True")
                {
                    GrpEditCheckbox_HalfStudy.Checked = false;
                }
                else GrpEditCheckbox_HalfStudy.Checked = true;

                GrpDeleteTextbox_SpecID.Text = GroupsViewGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                GrpDeleteTextbox_GrpName.Text = GroupsViewGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                GrpDeleteDate_StudDate.Value = Convert.ToDateTime(GroupsViewGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (GroupsViewGrid.Rows[e.RowIndex].Cells[3].Value.ToString() != "True")
                {
                    GrpDeleteCheckbox_HalfStudy.Checked = false;
                }
                else GrpDeleteCheckbox_HalfStudy.Checked = true;
            }
        }

        private void GrpAddButton_Click(object sender, EventArgs e)
        {
            if (ComboRegexCheck(GrpAddTextbox_GrpName.Text))
            {
                if (NumRegexCheck(GrpAddTextbox_SpecID.Text))
                {
                    var state = 0;
                    if (GrpAddCheckbox_HalfStudy.Checked) state = 1;
                    string data = "'" + GrpAddTextbox_GrpName.Text + "'," + GrpAddTextbox_SpecID.Text + ",'" + GrpAddDate_StudyDate.Value + "'," + state;

                    DBDataOperations.AddData("Groups", "GrpID, GrpSpecID, GrpYear, GrpState", data);
                    GrpActions.LoadTable(GroupsViewGrid, MainControl.SelectedIndex);
                }
                else MessageBox.Show("Введiть коректний номер освiтньоi програми (тiльки лiтери!)");
            }
            else MessageBox.Show("Введiть коректну назву групи ( ШАБЛОН 525ст2 / 525-ст-2 )");
        }

        private void GrpEditButton_Click(object sender, EventArgs e)
        {
            if (ComboRegexCheck(GrpEditTextbox_GrpName.Text))
            {
                if (NumRegexCheck(GrpEditTextbox_SpecID.Text))
                {
                    var state = 0;
                    if (GrpEditCheckbox_HalfStudy.Checked) state = 1;
                    string data = "GrpID='" + GrpEditTextbox_GrpName.Text + "',GrpSpecID=" + GrpEditTextbox_SpecID.Text + ",GrpYear='" + GrpEditDate_StudyDate.Value + "',GrpState=" + state;

                    DBDataOperations.EditData("Groups", data, "GrpID='" + SelectedGrp + "'");
                    GrpActions.LoadTable(GroupsViewGrid, MainControl.SelectedIndex);
                }
                else MessageBox.Show("Введiть коректний номер освiтньоi програми (тiльки лiтери!)");
            }
            else MessageBox.Show("Введiть коректну назву групи ( ШАБЛОН 525ст2 / 525-ст-2 )");
        }

        private void GrpDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Пiдтвердiть видалення групи '" + GrpDeleteTextbox_GrpName.Text + "'!", "УВАГА", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBDataOperations.DeleteData("Groups", "GrpID", SelectedGrp);
                GrpActions.LoadTable(GroupsViewGrid, MainControl.SelectedIndex);
            }
        }
        #endregion

        #region Students Activities
        private string SelectedStd = "";
        private void StdInsertToTextBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedStd = StudentsViewGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                StdEditTextbox_Course.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                StdEditTextbox_Group.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                StdEditTextbox_LName.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                StdEditTextbox_FName.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                StdEditTextbox_MName.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                StdEditTextbox_TicNumber.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                StdEditTextbox_RecordNumber.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                if (StudentsViewGrid.Rows[e.RowIndex].Cells[8].Value.ToString() != "True")
                {
                    StdEditTextbox_StudyForm.Checked = false;
                }
                else StdEditTextbox_StudyForm.Checked = true;

                StdDeleteTextbox_Course.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                StdDeleteTextbox_Group.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                StdDeleteTextbox_LName.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                StdDeleteTextbox_FName.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                StdDeleteTextbox_MName.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                StdDeleteTextbox_TicNumber.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                StdDeleteTextbox_RecordNumber.Text = StudentsViewGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                if (StudentsViewGrid.Rows[e.RowIndex].Cells[8].Value.ToString() != "True")
                {
                    StdDeleteTextbox_StudyForm.Checked = false;
                }
                else StdDeleteTextbox_StudyForm.Checked = true;
            }
        }

        private void StdAddButton_Click(object sender, EventArgs e)
        {
            //Факультет
            if (NumRegexCheck(StdAddTextbox_Fac.Text))
            {
                //Курс
                if (NumRegexCheck(StdAddTextbox_Course.Text))
                {
                    //Группа
                    if (ComboRegexCheck(StdAddTextbox_Group.Text))
                    {
                        //Фамилия
                        if (StrRegexCheck(StdAddTextbox_LName.Text))
                        {
                            //Имя
                            if (StrRegexCheck(StdAddTextbox_FName.Text))
                            {
                                //Отчество
                                if (StrRegexCheck(StdAddTextbox_MName.Text))
                                {
                                    //Студак
                                    if (TicketRegexCheck(StdAddTextbox_TicNumber.Text))
                                    {
                                        //Зачётка
                                        if (RecordRegexCheck(StdAddTextbox_RecordNumber.Text))
                                        {
                                            var state = 0;
                                            if (StdAddTextbox_StudyForm.Checked) state = 1;
                                            string studentdata = "'" + StdAddTextbox_LName.Text + "','" + StdAddTextbox_FName.Text + "','" + StdAddTextbox_MName.Text + "','" + StdAddTextbox_TicNumber.Text + "'," + StdAddTextbox_RecordNumber.Text + "," + state;

                                            DBDataOperations.AddData("Students", "StdGrpID, StdCourse", "'" + StdAddTextbox_Group.Text + "'," + StdAddTextbox_Course.Text);

                                            int ID = DBDataOperations.GetMaxIndex("StdID", "Students");
                                            string ticketdata = "'" + StdAddTextbox_TicNumber.Text + "'," + ID + "," + StdAddTextbox_Fac.Text + ",'" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "','" + DateTime.Now.AddYears(4).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "'";
                                            DBDataOperations.AddData("Tickets", "TicID, TicStdID, TicFacID, TicGetDate, TicOutDate", ticketdata);

                                            DBDataOperations.AddData("StudentData", "DataLName, DataFName, DataMName, DataTicID, DataRecordBook, DataEducationForm", studentdata);

                                            StdActions.LoadTable(StudentsViewGrid, MainControl.SelectedIndex);
                                        }
                                        else MessageBox.Show("Введiть коректний номер залiковоi книги ( НЕ БIЛЬШЕ 6 ЦИФР )"); //Зачетка
                                    }
                                    else MessageBox.Show("Введiть коректний номер студ. квитка ( ШАБЛОН: ХХ666666 )"); //Студак
                                }
                                else MessageBox.Show("Введiть коректне по батькові (тiльки лiтери!)"); //Отчество
                            }
                            else MessageBox.Show("Введiть коректне ім'я (тiльки лiтери!)"); //Имя
                        }
                        else MessageBox.Show("Введiть коректне прізвище (тiльки лiтери!)"); //Фамилия
                    }
                    else MessageBox.Show("Введiть коректну назву групи ( ШАБЛОН 525ст2 / 525-ст-2 )"); //Група
                }
                else MessageBox.Show("Введiть коректний номер курсу (тiльки цифри!)"); //Курс
            }
            else MessageBox.Show("Введiть коректний номер факультету (тiльки цифри!)"); //Факультет
        }

        private void StdEditButton_Click(object sender, EventArgs e)
        {
            //Курс
            if (NumRegexCheck(StdEditTextbox_Course.Text))
            {
                //Группа
                if (ComboRegexCheck(StdEditTextbox_Group.Text))
                {
                    //Фамилия
                    if (StrRegexCheck(StdEditTextbox_LName.Text))
                    {
                        //Имя
                        if (StrRegexCheck(StdEditTextbox_FName.Text))
                        {
                            //Отчество
                            if (StrRegexCheck(StdEditTextbox_MName.Text))
                            {
                                //Зачётка
                                if (RecordRegexCheck(StdAddTextbox_RecordNumber.Text))
                                {
                                    var state = 0;
                                    if (StdAddTextbox_StudyForm.Checked) state = 1;

                                    DBDataOperations.EditData("Students", "StdGrpID='" + StdEditTextbox_Group.Text
                                                            + "', StdCourse=" + StdEditTextbox_Course.Text, "StdID=" + SelectedStd);

                                    DBDataOperations.EditData("StudentData", "DataLName='" + StdEditTextbox_LName.Text
                                                               + "', DataFName='" + StdEditTextbox_FName.Text
                                                               + "', DataMName='" + StdEditTextbox_MName.Text
                                                               + "', DataEducationForm=" + state, "DataID=" + SelectedStd);

                                    StdActions.LoadTable(StudentsViewGrid, MainControl.SelectedIndex);
                                }
                                //Зачетка
                                else MessageBox.Show("Введiть коректний номер залiковоi книги ( НЕ БIЛЬШЕ 6 ЦИФР )");
                            }
                            //Отчество
                            else MessageBox.Show("Введiть коректне по батькові (тiльки лiтери!)");
                        }
                        //Имя
                        else MessageBox.Show("Введiть коректне ім'я (тiльки лiтери!)");
                    }
                    //Фамилия
                    else MessageBox.Show("Введiть коректне прізвище (тiльки лiтери!)");
                }
                //Група
                else MessageBox.Show("Введiть коректну назву групи (тiльки лiтери!)");
            }
            //Курс
            else MessageBox.Show("Введiть коректний номер курсу (тiльки цифри!)");
        }

        private void StdDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Пiдтвердiть видалення студента '" + StdDeleteTextbox_LName.Text + " " + StdDeleteTextbox_FName.Text + " " + StdDeleteTextbox_MName.Text + "'!", "УВАГА", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBDataOperations.DeleteData("Students", "StdID", SelectedStd);
                DBDataOperations.DeleteData("Tickets", "TicStdID", SelectedStd);
                DBDataOperations.DeleteData("StudentData", "DataID", SelectedStd);
                StdActions.LoadTable(StudentsViewGrid, MainControl.SelectedIndex);
            }
        }
        #endregion
    }
}