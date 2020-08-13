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
    public partial class EditTeachersForm : Form
    {
        public EditTeachersForm()
        {
            InitializeComponent();
        }

        private void btnClearFilters_Click_1(object sender, EventArgs e)
        {
            txtNameFilter.Text = "";
            txtSurnameFilter.Text = "";
            comboBoxDept.SelectedItem = null;
        }

        private void txtNameFilter_TextChanged(object sender, EventArgs e)
        {
            BLAdmin bl = new BLAdmin();
            gridTeachers.DataSource = bl.GetTeachers(txtNameFilter.Text, txtSurnameFilter.Text, comboBoxDept.GetItemText(comboBoxDept.SelectedItem));
        }

        private void txtSurnameFilter_TextChanged(object sender, EventArgs e)
        {
            BLAdmin bl = new BLAdmin();
            gridTeachers.DataSource = bl.GetTeachers(txtNameFilter.Text, txtSurnameFilter.Text, comboBoxDept.GetItemText(comboBoxDept.SelectedItem));
        }

        private void comboBoxDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLAdmin bl = new BLAdmin();
            gridTeachers.DataSource = bl.GetTeachers(txtNameFilter.Text, txtSurnameFilter.Text, comboBoxDept.GetItemText(comboBoxDept.SelectedItem));
        }

        private void EditTeachersForm_Load(object sender, EventArgs e)
        {
            gridTeachers.BorderStyle = BorderStyle.None;
            gridTeachers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridTeachers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridTeachers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridTeachers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridTeachers.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridTeachers.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridTeachers.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridTeachers.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridTeachers.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridTeachers.EnableHeadersVisualStyles = false;
            gridTeachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridTeachers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridTeachers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            gridCourses.BorderStyle = BorderStyle.None;
            gridCourses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridCourses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCourses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridCourses.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridCourses.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridCourses.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridCourses.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridCourses.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridCourses.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridCourses.EnableHeadersVisualStyles = false;
            gridCourses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridCourses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridCourses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            BLAdmin bl = new BLAdmin();
            gridTeachers.DataSource = bl.GetTeachers("", "", "");
            gridTeachers.Columns["TeacherId"].Visible = false;
            gridTeachers.Columns["TeacherName"].HeaderText = "Nume";
            gridTeachers.Columns["TeacherSurname"].HeaderText = "Prenume";
            gridTeachers.Columns["Department"].HeaderText = "Catedra";
            gridTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblInfo.Visible = false;
            lblCourse.Visible = false;
            lblSet.Visible = false;
            gridCourses.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            comboBoxCourses.Visible = false;
            comboBoxSet.Visible = false;
        }
        private void gridTeachers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = gridTeachers.SelectedRows[0];
            int teacherId = Convert.ToInt32(row.Cells["TeacherId"].Value);
            String name = row.Cells["TeacherName"].Value.ToString();
            String surname = row.Cells["TeacherSurname"].Value.ToString();
            String dept = row.Cells["Department"].Value.ToString();

            BLAdmin bl = new BLAdmin();
            bl.UpdateTeacher(teacherId, name, surname, dept);
            gridTeachers.DataSource = bl.GetTeachers(txtNameFilter.Text, txtSurnameFilter.Text, comboBoxDept.GetItemText(comboBoxDept.SelectedItem));

        }

        private void gridTeachers_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                gridTeachers.Rows[e.RowIndex].ErrorText = "Niciun camp nu poate fi lasat necompletat";
                e.Cancel = true;
            }
            if (gridTeachers.Columns[e.ColumnIndex].Name == "Department")
            { 
                if (e.FormattedValue.ToString() != "DCAE" && e.FormattedValue.ToString() != "Telecom" && e.FormattedValue.ToString() != "TEF" && e.FormattedValue.ToString() != "EAII"){
                    gridTeachers.Rows[e.RowIndex].ErrorText = "Completati un departament valid (DCAE/Telecom/TEF/EAII)";
                    e.Cancel = true;
                }
            }
        }

        private void gridTeachers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = gridTeachers.SelectedRows[0];
            BLAdmin bl = new BLAdmin();
            gridCourses.DataSource = bl.GetCourses(Convert.ToInt32(row.Cells["TeacherId"].Value));
            gridCourses.Columns["CourseId"].Visible = false;
            gridCourses.Columns["CourseName"].HeaderText = "Materie";
            gridCourses.Columns["StudySet"].HeaderText = "Serie";
            gridCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataTable tableCourses = bl.GetListOfCourses(Convert.ToInt32(row.Cells["TeacherId"].Value));
            comboBoxCourses.ValueMember = "CourseId";
            comboBoxCourses.DisplayMember = "CourseName";
            comboBoxCourses.DataSource = tableCourses;
            comboBoxCourses.SelectedItem = null;

            lblCourse.Visible = true;
            lblSet.Visible = true;
            gridCourses.Visible = true;
            btnAdd.Visible = true;
            btnDelete.Visible = true;
            comboBoxCourses.Visible = true;
            comboBoxSet.Visible = true;
            lblInfo.Visible = true;
            lblInfo.Text = "Lista materiilor predate de " + row.Cells["TeacherName"].Value.ToString() + " " + row.Cells["TeacherSurname"].Value.ToString() + ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxCourses.SelectedItem == null)
            {
                MessageBox.Show("Alegeti cursul pe care doriti sa il adaugati profesorului.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxSet.SelectedItem == null)
            {
                MessageBox.Show("Alegeti seria la care doriti sa adaugati cursul.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow row = gridTeachers.SelectedRows[0];
                BLAdmin bl = new BLAdmin();
                bl.AddTeacherCourse(Convert.ToInt32(row.Cells["TeacherId"].Value), Convert.ToInt32(comboBoxCourses.SelectedValue), comboBoxSet.GetItemText(comboBoxSet.SelectedItem));
                MessageBox.Show("Cursul a fost adaugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridCourses.DataSource = bl.GetCourses(Convert.ToInt32(row.Cells["TeacherId"].Value));
                DataTable tableCourses = bl.GetListOfCourses(Convert.ToInt32(row.Cells["TeacherId"].Value));
                comboBoxCourses.ValueMember = "CourseId";
                comboBoxCourses.DisplayMember = "CourseName";
                comboBoxCourses.DataSource = tableCourses;
                comboBoxCourses.SelectedItem = null;
                comboBoxSet.SelectedItem = null;
                lblCourse.Visible = true;
                lblSet.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gridCourses.SelectedRows[0] == null)
            {
                MessageBox.Show("Alegeti materia pe care doriti sa o stergeti.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow rowTeacher = gridTeachers.SelectedRows[0];
                DataGridViewRow rowCourse = gridCourses.SelectedRows[0];
                DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti " + rowCourse.Cells["CourseName"].Value.ToString() + " din lista de materii predate de " + rowTeacher.Cells["TeacherName"].Value.ToString() + " " + rowTeacher.Cells["TeacherSurname"].Value.ToString() + "?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BLAdmin bl = new BLAdmin();
                    bl.DeleteTeacherCourse(Convert.ToInt32(rowTeacher.Cells["TeacherId"].Value), Convert.ToInt32(rowCourse.Cells["CourseId"].Value));
                    MessageBox.Show("Cursul a fost sters cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridCourses.DataSource = bl.GetCourses(Convert.ToInt32(rowTeacher.Cells["TeacherId"].Value));
                    DataTable tableCourses = bl.GetListOfCourses(Convert.ToInt32(rowTeacher.Cells["TeacherId"].Value));
                    comboBoxCourses.ValueMember = "CourseId";
                    comboBoxCourses.DisplayMember = "CourseName";
                    comboBoxCourses.DataSource = tableCourses;
                    comboBoxCourses.SelectedItem = null;
                }
                else return;
            }
        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCourse.Visible = false;
        }

        private void comboBoxSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSet.Visible = false;
        }
    }
}