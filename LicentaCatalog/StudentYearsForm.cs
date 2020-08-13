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

namespace LicentaCatalog
{
    public partial class StudentYearsForm : Form
    {
        public StudentYearsForm()
        {
            InitializeComponent();
        }
        int idUser, studyYear;
        public StudentYearsForm( int idUser, int studyYear )
        {
            InitializeComponent();
            this.idUser = idUser;
            this.studyYear = studyYear;
        }

        private void StudentYearsForm_Load(object sender, EventArgs e)
        {
            gridGradesSem1.BorderStyle = BorderStyle.None;
            gridGradesSem1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridGradesSem1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridGradesSem1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridGradesSem1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridGradesSem1.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridGradesSem1.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridGradesSem1.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridGradesSem1.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridGradesSem1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridGradesSem1.EnableHeadersVisualStyles = false;
            gridGradesSem1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridGradesSem1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridGradesSem1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            gridGradesSem2.BorderStyle = BorderStyle.None;
            gridGradesSem2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridGradesSem2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridGradesSem2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridGradesSem2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridGradesSem2.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridGradesSem2.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridGradesSem2.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridGradesSem2.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridGradesSem2.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridGradesSem2.EnableHeadersVisualStyles = false;
            gridGradesSem2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridGradesSem2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridGradesSem2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            BLStudents bl = new BLStudents();
            gridGradesSem1.DataSource = bl.GetCatalogInfoS1(idUser, studyYear);
            gridGradesSem1.Columns["EntryId"].Visible = false;
            gridGradesSem1.Columns["CourseId"].Visible = false;
            gridGradesSem1.Columns["StudentId"].Visible = false;
            gridGradesSem1.Columns["StudentName"].Visible = false;
            gridGradesSem1.Columns["StudentSurname"].Visible = false;
            gridGradesSem1.Columns["StudyGroup"].Visible = false;
            gridGradesSem1.Columns["StudySet"].Visible = false;
            gridGradesSem1.Columns["CourseName"].HeaderText = "Materie";
            gridGradesSem1.Columns["CourseShortName"].Visible = false;
            gridGradesSem1.Columns["PartialExam"].HeaderText = "Partial";
            gridGradesSem1.Columns["FinalExam"].HeaderText = "Final";
            gridGradesSem1.Columns["Laboratory"].HeaderText = "Laborator";
            gridGradesSem1.Columns["Seminary"].HeaderText = "Seminar";
            gridGradesSem1.Columns["BonusPoints"].HeaderText = "Puncte bonus";
            gridGradesSem1.Columns["Total"].HeaderText = "Total";
            gridGradesSem1.Columns["LastUpdate"].HeaderText = "Ultima actualizare";
            gridGradesSem1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            gridGradesSem2.DataSource = bl.GetCatalogInfoS2(idUser, studyYear);
            gridGradesSem2.Columns["EntryId"].Visible = false;
            gridGradesSem2.Columns["CourseId"].Visible = false;
            gridGradesSem2.Columns["StudentId"].Visible = false;
            gridGradesSem2.Columns["StudentName"].Visible = false;
            gridGradesSem2.Columns["StudentSurname"].Visible = false;
            gridGradesSem2.Columns["StudyGroup"].Visible = false;
            gridGradesSem2.Columns["StudySet"].Visible = false;
            gridGradesSem2.Columns["CourseName"].HeaderText = "Materie";
            gridGradesSem2.Columns["CourseShortName"].Visible = false;
            gridGradesSem2.Columns["PartialExam"].HeaderText = "Partial";
            gridGradesSem2.Columns["FinalExam"].HeaderText = "Final";
            gridGradesSem2.Columns["Laboratory"].HeaderText = "Laborator";
            gridGradesSem2.Columns["Seminary"].HeaderText = "Seminar";
            gridGradesSem2.Columns["BonusPoints"].HeaderText = "Puncte bonus";
            gridGradesSem2.Columns["Total"].HeaderText = "Total";
            gridGradesSem2.Columns["LastUpdate"].HeaderText = "Ultima actualizare";
            gridGradesSem2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
