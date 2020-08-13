using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace LicentaCatalog
{
    public partial class TeacherCoursesForm : Form
    {
        public TeacherCoursesForm()
        {
            InitializeComponent();
        }

        public TeacherCoursesForm(int idUser)
        {
            InitializeComponent();

            lblFilter.Visible = false;
            lblName.Visible = false;
            lblGroup.Visible = false;
            pictureFilter.Visible = false;
            btnClearFilters.Visible = false;
            txtNameFilter.Visible = false;
            txtGroupFilter.Visible = false;

            BLTeachers bl = new BLTeachers();

            List<TeachersXCoursesXStudySetModel> list = new List<TeachersXCoursesXStudySetModel>();
            list = bl.GetTeacherCourses(idUser);

            gridTeacherCourses.Columns.Add("CourseId", "Curs");
            gridTeacherCourses.Columns.Add("CourseName", "Nume Curs");
            gridTeacherCourses.Columns.Add("StudySet", "Seria");
            gridTeacherCourses.Columns[0].Visible = false;

            foreach(TeachersXCoursesXStudySetModel course in list)
            {
                gridTeacherCourses.Rows.Add(course.Courses.CourseId, course.Courses.CourseName, course.StudySet);
            }

            gridTeacherCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void gridTeacherCourses_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblSelectCourse.Text = "";
            lblFilter.Visible = true;
            lblName.Visible = true;
            lblGroup.Visible = true;
            pictureFilter.Visible = true;
            btnClearFilters.Visible = true;
            txtNameFilter.Visible = true;
            txtGroupFilter.Visible = true;

            gridTeacherStudents.Rows.Clear();
            gridTeacherStudents.Columns.Clear();
            DataGridViewRow row = gridTeacherCourses.SelectedRows[0];
            BLTeachers bl = new BLTeachers();
            List<CatalogInfoModel> list = new List<CatalogInfoModel>();
            list = bl.GetTeacherStudents(Convert.ToInt32(row.Cells["CourseId"].Value), row.Cells["StudySet"].Value.ToString());

            gridTeacherStudents.Columns.Add("EntryId", "EntryId");
            gridTeacherStudents.Columns.Add("StudentId", "StudentId");
            gridTeacherStudents.Columns.Add("StudyGroup", "Grupa");
            gridTeacherStudents.Columns.Add("StudentName", "Nume");
            gridTeacherStudents.Columns.Add("Laboratory", "Laborator");
            gridTeacherStudents.Columns.Add("Seminary", "Seminar");
            gridTeacherStudents.Columns.Add("PartialExam", "Examen partial");
            gridTeacherStudents.Columns.Add("FinalExam", "Examen final");
            gridTeacherStudents.Columns.Add("BonusPoints", "Puncte bonus");
            gridTeacherStudents.Columns.Add("Total", "Total");
            gridTeacherStudents.Columns.Add("LastUpdate", "Ultima actualizare");
            gridTeacherStudents.Columns[0].Visible = false;
            gridTeacherStudents.Columns[1].Visible = false;
            gridTeacherStudents.Columns[2].ReadOnly = true;
            gridTeacherStudents.Columns[3].ReadOnly = true;
            gridTeacherStudents.Columns[9].ReadOnly = true;
            gridTeacherStudents.Columns[10].ReadOnly = true;

            foreach (CatalogInfoModel catalogInfo in list)
            {

                gridTeacherStudents.Rows.Add(catalogInfo.EntryId, catalogInfo.Student.StudentId, catalogInfo.Student.StudyGroup, catalogInfo.Student.StudentName, catalogInfo.Laboratory, catalogInfo.Seminary,
                    catalogInfo.PartialExam, catalogInfo.FinalExam, catalogInfo.BonusPoints, catalogInfo.Total, catalogInfo.LastUpdate);
            }
            gridTeacherStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtNameFilter_TextChanged(object sender, EventArgs e)
        {
            String studentName = txtNameFilter.Text;
            String studyGroup = txtGroupFilter.Text;
            gridTeacherStudents.Rows.Clear();
            gridTeacherStudents.Columns.Clear();
            DataGridViewRow row = gridTeacherCourses.SelectedRows[0];
            BLTeachers bl = new BLTeachers();
            List<CatalogInfoModel> list = new List<CatalogInfoModel>();
            list = bl.GetTeacherStudents(Convert.ToInt32(row.Cells["CourseId"].Value), row.Cells["StudySet"].Value.ToString(), studentName, studyGroup);

            gridTeacherStudents.Columns.Add("EntryId", "EntryId");
            gridTeacherStudents.Columns.Add("StudentId", "StudentId");
            gridTeacherStudents.Columns.Add("StudyGroup", "Grupa");
            gridTeacherStudents.Columns.Add("StudentName", "Nume");
            gridTeacherStudents.Columns.Add("Laboratory", "Laborator");
            gridTeacherStudents.Columns.Add("Seminary", "Seminar");
            gridTeacherStudents.Columns.Add("PartialExam", "Examen partial");
            gridTeacherStudents.Columns.Add("FinalExam", "Examen final");
            gridTeacherStudents.Columns.Add("BonusPoints", "Puncte bonus");
            gridTeacherStudents.Columns.Add("Total", "Total");
            gridTeacherStudents.Columns.Add("LastUpdate", "Ultima actualizare");
            gridTeacherStudents.Columns[0].Visible = false;
            gridTeacherStudents.Columns[1].Visible = false;
            gridTeacherStudents.Columns[2].ReadOnly = true;
            gridTeacherStudents.Columns[3].ReadOnly = true;
            gridTeacherStudents.Columns[9].ReadOnly = true;
            gridTeacherStudents.Columns[10].ReadOnly = true;

            foreach (CatalogInfoModel catalogInfo in list)
            {

                gridTeacherStudents.Rows.Add(catalogInfo.EntryId, catalogInfo.Student.StudentId, catalogInfo.Student.StudyGroup, catalogInfo.Student.StudentName, catalogInfo.Laboratory, catalogInfo.Seminary,
                    catalogInfo.PartialExam, catalogInfo.FinalExam, catalogInfo.BonusPoints, catalogInfo.Total, catalogInfo.LastUpdate);
            }
            gridTeacherStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtGroupFilter_TextChanged(object sender, EventArgs e)
        {
            String studentName = txtNameFilter.Text;
            String studyGroup = txtGroupFilter.Text;
            gridTeacherStudents.Rows.Clear();
            gridTeacherStudents.Columns.Clear();
            DataGridViewRow row = gridTeacherCourses.SelectedRows[0];
            BLTeachers bl = new BLTeachers();
            List<CatalogInfoModel> list = new List<CatalogInfoModel>();
            list = bl.GetTeacherStudents(Convert.ToInt32(row.Cells["CourseId"].Value), row.Cells["StudySet"].Value.ToString(), studentName, studyGroup);

            gridTeacherStudents.Columns.Add("EntryId", "EntryId");
            gridTeacherStudents.Columns.Add("StudentId", "StudentId");
            gridTeacherStudents.Columns.Add("StudyGroup", "Grupa");
            gridTeacherStudents.Columns.Add("StudentName", "Nume");
            gridTeacherStudents.Columns.Add("Laboratory", "Laborator");
            gridTeacherStudents.Columns.Add("Seminary", "Seminar");
            gridTeacherStudents.Columns.Add("PartialExam", "Examen partial");
            gridTeacherStudents.Columns.Add("FinalExam", "Examen final");
            gridTeacherStudents.Columns.Add("BonusPoints", "Puncte bonus");
            gridTeacherStudents.Columns.Add("Total", "Total");
            gridTeacherStudents.Columns.Add("LastUpdate", "Ultima actualizare");
            gridTeacherStudents.Columns[0].Visible = false;
            gridTeacherStudents.Columns[1].Visible = false;
            gridTeacherStudents.Columns[2].ReadOnly = true;
            gridTeacherStudents.Columns[3].ReadOnly = true;
            gridTeacherStudents.Columns[9].ReadOnly = true;
            gridTeacherStudents.Columns[10].ReadOnly = true;

            foreach (CatalogInfoModel catalogInfo in list)
            {

                gridTeacherStudents.Rows.Add(catalogInfo.EntryId, catalogInfo.Student.StudentId, catalogInfo.Student.StudyGroup, catalogInfo.Student.StudentName, catalogInfo.Laboratory, catalogInfo.Seminary,
                    catalogInfo.PartialExam, catalogInfo.FinalExam, catalogInfo.BonusPoints, catalogInfo.Total, catalogInfo.LastUpdate);
            }
            gridTeacherStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnClearFilters_MouseClick(object sender, MouseEventArgs e)
        {
            txtNameFilter.Text = "";
            txtGroupFilter.Text = "";
        }

        private void gridTeacherStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridTeacherStudents.SelectedRows[0];
            int entryId = Convert.ToInt32(row.Cells["EntryId"].Value);
            int partialExam = Convert.ToInt32(row.Cells["PartialExam"].Value == DBNull.Value ? 0 : row.Cells["PartialExam"].Value);
            int finalExam = Convert.ToInt32(row.Cells["FinalExam"].Value == DBNull.Value ? 0 : row.Cells["FinalExam"].Value);
            int laboratory = Convert.ToInt32(row.Cells["Laboratory"].Value == DBNull.Value ? 0 : row.Cells["Laboratory"].Value);
            int seminary = Convert.ToInt32(row.Cells["Seminary"].Value == DBNull.Value ? 0 : row.Cells["Seminary"].Value);
            int bonusPoints = Convert.ToInt32(row.Cells["BonusPoints"].Value == DBNull.Value ? 0 : row.Cells["BonusPoints"].Value);
            BLTeachers bl = new BLTeachers();
            bl.UpdateCatalogInfo(entryId, partialExam, finalExam, laboratory, seminary, bonusPoints);

            String studentName = String.IsNullOrWhiteSpace(txtNameFilter.Text) == true ? "" : txtNameFilter.Text;
            String studyGroup = String.IsNullOrWhiteSpace(txtGroupFilter.Text) == true ? "" : txtGroupFilter.Text;
            gridTeacherStudents.Rows.Clear();
            gridTeacherStudents.Columns.Clear();
            List<CatalogInfoModel> list = new List<CatalogInfoModel>();
            DataGridViewRow row1 = gridTeacherCourses.SelectedRows[0];
            list = bl.GetTeacherStudents(Convert.ToInt32(row1.Cells["CourseId"].Value), row1.Cells["StudySet"].Value.ToString(), studentName, studyGroup);

            gridTeacherStudents.Columns.Add("EntryId", "EntryId");
            gridTeacherStudents.Columns.Add("StudentId", "StudentId");
            gridTeacherStudents.Columns.Add("StudyGroup", "Grupa");
            gridTeacherStudents.Columns.Add("StudentName", "Nume");
            gridTeacherStudents.Columns.Add("Laboratory", "Laborator");
            gridTeacherStudents.Columns.Add("Seminary", "Seminar");
            gridTeacherStudents.Columns.Add("PartialExam", "Examen partial");
            gridTeacherStudents.Columns.Add("FinalExam", "Examen final");
            gridTeacherStudents.Columns.Add("BonusPoints", "Puncte bonus");
            gridTeacherStudents.Columns.Add("Total", "Total");
            gridTeacherStudents.Columns.Add("LastUpdate", "Ultima actualizare");
            gridTeacherStudents.Columns[0].Visible = false;
            gridTeacherStudents.Columns[1].Visible = false;
            gridTeacherStudents.Columns[2].ReadOnly = true;
            gridTeacherStudents.Columns[3].ReadOnly = true;
            gridTeacherStudents.Columns[9].ReadOnly = true;
            gridTeacherStudents.Columns[10].ReadOnly = true;

            foreach (CatalogInfoModel catalogInfo in list)
            {

                gridTeacherStudents.Rows.Add(catalogInfo.EntryId, catalogInfo.Student.StudentId, catalogInfo.Student.StudyGroup, catalogInfo.Student.StudentName, catalogInfo.Laboratory, catalogInfo.Seminary,
                    catalogInfo.PartialExam, catalogInfo.FinalExam, catalogInfo.BonusPoints, catalogInfo.Total, catalogInfo.LastUpdate);
            }
            gridTeacherStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void gridTeacherStudents_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //verifica daca tasta apasata este numar, iar daca e altceva nu scrie nimic
        private void gridTeacherStudents_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(gridTeacherStudents_KeyPress);
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(gridTeacherStudents_KeyPress);
            }
        }

        private void TeacherCoursesForm_Load(object sender, EventArgs e)
        {
            gridTeacherCourses.BorderStyle = BorderStyle.None;
            gridTeacherCourses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridTeacherCourses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridTeacherCourses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridTeacherCourses.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridTeacherCourses.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridTeacherCourses.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridTeacherCourses.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridTeacherCourses.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridTeacherCourses.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridTeacherCourses.EnableHeadersVisualStyles = false;
            gridTeacherCourses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridTeacherCourses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridTeacherCourses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            gridTeacherStudents.BorderStyle = BorderStyle.None;
            gridTeacherStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridTeacherStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridTeacherStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridTeacherStudents.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridTeacherStudents.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridTeacherStudents.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridTeacherStudents.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridTeacherStudents.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridTeacherStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridTeacherStudents.EnableHeadersVisualStyles = false;
            gridTeacherStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridTeacherStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridTeacherStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
