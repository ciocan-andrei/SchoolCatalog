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
    public partial class ValidateRequestsForm : Form
    {
        public ValidateRequestsForm()
        {
            InitializeComponent();
        }

        private void ValidateRequestsForm_Load(object sender, EventArgs e)
        {
            gridRequests.BorderStyle = BorderStyle.None;
            gridRequests.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridRequests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridRequests.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridRequests.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridRequests.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridRequests.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridRequests.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridRequests.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridRequests.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridRequests.EnableHeadersVisualStyles = false;
            gridRequests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridRequests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridRequests.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            BLAdmin bl = new BLAdmin();
            gridRequests.DataSource = bl.GetRequests();
            gridRequests.Columns["ExternalId"].Visible = false;
            gridRequests.Columns["StudentId"].Visible = false;
            gridRequests.Columns["ExternalName"].HeaderText = "Nume utilizator extern";
            gridRequests.Columns["StudentName"].HeaderText = "Nume student";
            gridRequests.Columns["StudyGroup"].HeaderText = "Grupa";
            gridRequests.Columns["Reason"].HeaderText = "Motiv";
            gridRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            BLAdmin bl = new BLAdmin();
            if (gridRequests.SelectedRows[0] != null)
            {
                DataGridViewRow row = gridRequests.SelectedRows[0];
                bl.AcceptRequest(Convert.ToInt32(row.Cells["ExternalId"].Value), Convert.ToInt32(row.Cells["StudentId"].Value));
                MessageBox.Show("Cererea a fost acceptata!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable requestsTable = bl.GetRequests();
                gridRequests.DataSource = requestsTable;
            }
            else
            {
                MessageBox.Show("Alegeti cererea pe care doriti sa o aprobati!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            BLAdmin bl = new BLAdmin();
            if (gridRequests.SelectedRows[0] != null)
            {
                DialogResult res = MessageBox.Show("Respingerea cererii implica stergerea totala a acesteia din baza de date.\nContinuati?", "Respingere", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    DataGridViewRow row = gridRequests.SelectedRows[0];
                    bl.DenyRequest(Convert.ToInt32(row.Cells["ExternalId"].Value), Convert.ToInt32(row.Cells["StudentId"].Value));
                    MessageBox.Show("Cererea a fost respinsa!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable requestsTable = bl.GetRequests();
                    gridRequests.DataSource = requestsTable;
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Alegeti cererea pe care doriti sa o respingeti!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
