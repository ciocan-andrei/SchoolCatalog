using BusinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCatalog
{
    public partial class EditStudentsForm : Form
    {
        public EditStudentsForm()
        {
            InitializeComponent();
        }

        private void EditStudentsForm_Load(object sender, EventArgs e)
        {
            gridStudents.BorderStyle = BorderStyle.None;
            gridStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridStudents.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridStudents.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridStudents.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridStudents.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridStudents.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridStudents.EnableHeadersVisualStyles = false;
            gridStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridStudents.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);

            BLAdmin bl = new BLAdmin();
            List<StudentsModel> studentsModels = bl.GetStudents("", "", "");
            gridStudents.Columns.Add("StudentId", "StudentId");
            gridStudents.Columns.Add("StudentName", "Nume");
            gridStudents.Columns.Add("StudentSurname", "Prenume");
            gridStudents.Columns.Add("StudyYear", "An");
            gridStudents.Columns.Add("StudyGroup", "Grupa");
            gridStudents.Columns.Add("StudySet", "Seria");
            gridStudents.Columns[0].Visible = false;

            foreach (StudentsModel student in studentsModels)
            {
                gridStudents.Rows.Add(student.StudentId, student.StudentName, student.StudentSurname, student.StudyYear, student.StudyGroup, student.StudySet);
            }
            gridStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void gridStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridStudents.SelectedRows[0];
            int studentId = Convert.ToInt32(row.Cells["StudentId"].Value);
            int year = Convert.ToInt32(row.Cells["StudyYear"].Value);
            String name = row.Cells["StudentName"].Value.ToString();
            String surname = row.Cells["StudentSurname"].Value.ToString();
            String group = row.Cells["StudyGroup"].Value.ToString();
            String set = row.Cells["StudySet"].Value.ToString();

            BLAdmin bl = new BLAdmin();
            bl.UpdateStudent(studentId, name, surname, year, group, set);

            gridStudents.Rows.Clear();
            gridStudents.Columns.Clear();
            List<StudentsModel> studentsModels = bl.GetStudents(txtNameFilter.Text, txtSurnameFilter.Text, txtGroupFilter.Text);
            gridStudents.Columns.Add("StudentId", "StudentId");
            gridStudents.Columns.Add("StudentName", "Nume");
            gridStudents.Columns.Add("StudentSurname", "Prenume");
            gridStudents.Columns.Add("StudyYear", "An");
            gridStudents.Columns.Add("StudyGroup", "Grupa");
            gridStudents.Columns.Add("StudySet", "Seria");
            gridStudents.Columns[0].Visible = false;

            foreach (StudentsModel student in studentsModels)
            {
                gridStudents.Rows.Add(student.StudentId, student.StudentName, student.StudentSurname, student.StudyYear, student.StudyGroup, student.StudySet);
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtGroupFilter.Text = "";
            txtNameFilter.Text = "";
            txtSurnameFilter.Text = "";
        }

        private void txtNameFilter_TextChanged(object sender, EventArgs e)
        {
            BLAdmin bl = new BLAdmin();
            gridStudents.Rows.Clear();
            gridStudents.Columns.Clear();
            List<StudentsModel> studentsModels = bl.GetStudents(txtNameFilter.Text, txtSurnameFilter.Text, txtGroupFilter.Text);
            gridStudents.Columns.Add("StudentId", "StudentId");
            gridStudents.Columns.Add("StudentName", "Nume");
            gridStudents.Columns.Add("StudentSurname", "Prenume");
            gridStudents.Columns.Add("StudyYear", "An");
            gridStudents.Columns.Add("StudyGroup", "Grupa");
            gridStudents.Columns.Add("StudySet", "Seria");
            gridStudents.Columns[0].Visible = false;

            foreach (StudentsModel student in studentsModels)
            {
                gridStudents.Rows.Add(student.StudentId, student.StudentName, student.StudentSurname, student.StudyYear, student.StudyGroup, student.StudySet);
            }
        }

        private void txtSurnameFilter_TextChanged(object sender, EventArgs e)
        {
            BLAdmin bl = new BLAdmin();
            gridStudents.Rows.Clear();
            gridStudents.Columns.Clear();
            List<StudentsModel> studentsModels = bl.GetStudents(txtNameFilter.Text, txtSurnameFilter.Text, txtGroupFilter.Text);
            gridStudents.Columns.Add("StudentId", "StudentId");
            gridStudents.Columns.Add("StudentName", "Nume");
            gridStudents.Columns.Add("StudentSurname", "Prenume");
            gridStudents.Columns.Add("StudyYear", "An");
            gridStudents.Columns.Add("StudyGroup", "Grupa");
            gridStudents.Columns.Add("StudySet", "Seria");
            gridStudents.Columns[0].Visible = false;

            foreach (StudentsModel student in studentsModels)
            {
                gridStudents.Rows.Add(student.StudentId, student.StudentName, student.StudentSurname, student.StudyYear, student.StudyGroup, student.StudySet);
            }
        }

        private void txtGroupFilter_TextChanged(object sender, EventArgs e)
        {
            BLAdmin bl = new BLAdmin();
            gridStudents.Rows.Clear();
            gridStudents.Columns.Clear();
            List<StudentsModel> studentsModels = bl.GetStudents(txtNameFilter.Text, txtSurnameFilter.Text, txtGroupFilter.Text);
            gridStudents.Columns.Add("StudentId", "StudentId");
            gridStudents.Columns.Add("StudentName", "Nume");
            gridStudents.Columns.Add("StudentSurname", "Prenume");
            gridStudents.Columns.Add("StudyYear", "An");
            gridStudents.Columns.Add("StudyGroup", "Grupa");
            gridStudents.Columns.Add("StudySet", "Seria");
            gridStudents.Columns[0].Visible = false;

            foreach (StudentsModel student in studentsModels)
            {
                gridStudents.Rows.Add(student.StudentId, student.StudentName, student.StudentSurname, student.StudyYear, student.StudyGroup, student.StudySet);
            }
        }

        private void gridStudents_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                gridStudents.Rows[e.RowIndex].ErrorText = "Niciun camp nu poate fi lasat necompletat";
                e.Cancel = true;
            }

        }
    }
}
