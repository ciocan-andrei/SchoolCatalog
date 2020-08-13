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
    public partial class ValidateAccountsForm : Form
    {
        public ValidateAccountsForm()
        {
            InitializeComponent();
        }

        private void ValidateAccountsForm_Load(object sender, EventArgs e)
        {
            gridAccounts.BorderStyle = BorderStyle.None;
            gridAccounts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridAccounts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridAccounts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridAccounts.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridAccounts.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridAccounts.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridAccounts.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridAccounts.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridAccounts.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridAccounts.EnableHeadersVisualStyles = false;
            gridAccounts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridAccounts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridAccounts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            BLAdmin bl = new BLAdmin();
            DataTable accountsTable = bl.GetInactiveExternals();
            gridAccounts.DataSource = accountsTable;
            gridAccounts.Columns["UserId"].Visible = false;
            gridAccounts.Columns["ExternalId"].Visible = false;
            gridAccounts.Columns["UserName"].HeaderText = "Cont utilizator";
            gridAccounts.Columns["ExternalName"].HeaderText = "Nume utilizator";
            gridAccounts.Columns["RegisterDate"].HeaderText = "Data inregistrarii";
            gridAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            BLAdmin bl = new BLAdmin();
            if (gridAccounts.SelectedRows[0] != null)
            {
                DataGridViewRow row = gridAccounts.SelectedRows[0];
                bl.SetUserActive(Convert.ToInt32(row.Cells["UserId"].Value));
                MessageBox.Show("Contul a fost activat cu succes!", "Succes", MessageBoxButtons.OK);
                DataTable accountsTable = bl.GetInactiveExternals();
                gridAccounts.DataSource = accountsTable;
            }
            else
            {
                MessageBox.Show("Alegeti utilizatorul pe care doriti sa il activati!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            BLAdmin bl = new BLAdmin();
            if(gridAccounts.SelectedRows[0] != null)
            {
                DialogResult res = MessageBox.Show("Respingerea utilizatorului implica stergerea atat a contului cat si a datelor furnizate.\nContinuati?", "Respingere", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    DataGridViewRow row = gridAccounts.SelectedRows[0];
                    bl.DenyUser(Convert.ToInt32(row.Cells["UserId"].Value), Convert.ToInt32(row.Cells["ExternalId"].Value));
                    MessageBox.Show("Contul a fost sters cu succes!", "Succes", MessageBoxButtons.OK);
                    DataTable accountsTable = bl.GetInactiveExternals();
                    gridAccounts.DataSource = accountsTable;
                }
                else return;
            }
            else
            {
                MessageBox.Show("Alegeti utilizatorul pe care doriti sa il stergeti!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
