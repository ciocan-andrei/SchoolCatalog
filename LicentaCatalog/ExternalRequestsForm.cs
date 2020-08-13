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
    public partial class ExternalRequestsForm : Form
    {
        public ExternalRequestsForm()
        {
            InitializeComponent();
        }
        int idUser;
        public ExternalRequestsForm(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void ExternalRequestsForm_Load(object sender, EventArgs e)
        {
            gridAwaitingRequests.BorderStyle = BorderStyle.None;
            gridAwaitingRequests.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridAwaitingRequests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridAwaitingRequests.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridAwaitingRequests.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridAwaitingRequests.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridAwaitingRequests.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridAwaitingRequests.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridAwaitingRequests.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridAwaitingRequests.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridAwaitingRequests.EnableHeadersVisualStyles = false;
            gridAwaitingRequests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridAwaitingRequests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridAwaitingRequests.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            gridAcceptedRequests.BorderStyle = BorderStyle.None;
            gridAcceptedRequests.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridAcceptedRequests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridAcceptedRequests.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridAcceptedRequests.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridAcceptedRequests.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridAcceptedRequests.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridAcceptedRequests.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridAcceptedRequests.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridAcceptedRequests.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridAcceptedRequests.EnableHeadersVisualStyles = false;
            gridAcceptedRequests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridAcceptedRequests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridAcceptedRequests.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            BLExternals bl = new BLExternals();
            DataTable dataTable = bl.GetStudents("", "", idUser);
            comboBoxStudents.ValueMember = "StudentId";
            comboBoxStudents.DisplayMember = "StudentInfo";
            comboBoxStudents.DataSource = dataTable;
            comboBoxStudents.SelectedItem = null;

            gridAwaitingRequests.DataSource = bl.GetRequests(idUser);
            gridAwaitingRequests.Columns["StudentName"].HeaderText = "Nume";
            gridAwaitingRequests.Columns["StudyGroup"].HeaderText = "Grupa";
            gridAwaitingRequests.Columns["Reason"].HeaderText = "Motiv";
            gridAwaitingRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridAwaitingRequests.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gridAwaitingRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            gridAcceptedRequests.DataSource = bl.GetAcceptedRequests(idUser);
            gridAcceptedRequests.Columns["StudentName"].HeaderText = "Nume";
            gridAcceptedRequests.Columns["StudyGroup"].HeaderText = "Grupa";
            gridAcceptedRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            richTxtReason.Text = "Va rugam completati un motiv plauzibil (ex. parinte, angajator, pentru practica).\nAdministratorul va aproba sau nu cererea dumneavoastra in functie de acesta.";
            richTxtReason.Font = new Font(richTxtReason.Font, FontStyle.Italic);
            richTxtReason.ForeColor = Color.FromArgb(165, 165, 165);
            richTxtReason.MaxLength = 500;
        }

        private void txtNameFilter_TextChanged(object sender, EventArgs e)
        {
            String name = txtNameFilter.Text;
            String group = txtGroupFilter.Text;
            BLExternals bl = new BLExternals();
            DataTable dataTable = bl.GetStudents(name, group, idUser);
            comboBoxStudents.ValueMember = "StudentId";
            comboBoxStudents.DisplayMember = "StudentInfo";
            comboBoxStudents.DataSource = dataTable;
        }

        private void txtGroupFilter_TextChanged(object sender, EventArgs e)
        {
            String name = txtNameFilter.Text;
            String group = txtGroupFilter.Text;
            BLExternals bl = new BLExternals();
            DataTable dataTable = bl.GetStudents(name, group, idUser);
            comboBoxStudents.ValueMember = "StudentId";
            comboBoxStudents.DisplayMember = "StudentInfo";
            comboBoxStudents.DataSource = dataTable;
        }

        private void btnInsertRequest_Click(object sender, EventArgs e)
        {
            BLExternals bl = new BLExternals();
            if (comboBoxStudents.SelectedItem != null && !String.IsNullOrWhiteSpace(richTxtReason.Text) && 
                richTxtReason.Text != "Va rugam completati un motiv plauzibil (ex. parinte, angajator, pentru practica).\nAdministratorul va aproba sau nu cererea dumneavoastra in functie de acesta.")
            {
                bl.InsertRequests(idUser, Convert.ToInt32(comboBoxStudents.SelectedValue), richTxtReason.Text);
                comboBoxStudents.SelectedItem = null;
                richTxtReason.Text = "";
                MessageBox.Show("Cererea a fost inregistrata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridAwaitingRequests.DataSource = bl.GetRequests(idUser);
                gridAwaitingRequests.Columns["StudentName"].HeaderText = "Nume";
                gridAwaitingRequests.Columns["StudyGroup"].HeaderText = "Grupa";
                gridAwaitingRequests.Columns["Reason"].HeaderText = "Motiv";
                gridAwaitingRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DataTable dataTable = bl.GetStudents("", "", idUser);
                comboBoxStudents.ValueMember = "StudentId";
                comboBoxStudents.DisplayMember = "StudentInfo";
                comboBoxStudents.DataSource = dataTable;

                clearFilter();
            }
            else
            {
                MessageBox.Show("Va rugam alegeti un student si completati motivul pentru care doriti sa ii vizualizati situatia scolara.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearFilter()
        {
            txtNameFilter.Text = "";
            txtGroupFilter.Text = "";
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            clearFilter();
        }

        private void richTxtReason_Click(object sender, EventArgs e)
        {
            if (richTxtReason.Text == "Va rugam completati un motiv plauzibil (ex. parinte, angajator, pentru practica).\nAdministratorul va aproba sau nu cererea dumneavoastra in functie de acesta.")
            {
                richTxtReason.Font = new Font(richTxtReason.Font, FontStyle.Regular);
                richTxtReason.ForeColor = Color.White;
                richTxtReason.Text = "";
            }
        }

        private void gridAwaitingRequests_SelectionChanged(object sender, EventArgs e)
        {
            gridAwaitingRequests.ClearSelection();
        }

        private void gridAcceptedRequests_SelectionChanged(object sender, EventArgs e)
        {
            gridAcceptedRequests.ClearSelection();
        }
    }
}
