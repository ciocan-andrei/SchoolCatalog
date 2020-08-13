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
    public partial class ManageAccountsForm : Form
    {
        public ManageAccountsForm()
        {
            InitializeComponent();
        }

        private void ManageAccountsForm_Load(object sender, EventArgs e)
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
            gridAccounts.DataSource = bl.GetAccounts();
            gridAccounts.Columns["UserId"].Visible = false;
            gridAccounts.Columns["UserName"].HeaderText = "Cont";
            gridAccounts.Columns["Name"].HeaderText = "Nume";
            gridAccounts.Columns["IsActive"].HeaderText = "Activat";
            gridAccounts.Columns["UserTypeName"].HeaderText = "Tip utilizator";
            gridAccounts.Columns[1].ReadOnly = true;
            gridAccounts.Columns[2].ReadOnly = true;
            gridAccounts.Columns[3].ReadOnly = true;
            gridAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void gridAccounts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridAccounts.SelectedRows[0];
            BLAdmin bl = new BLAdmin();
            Boolean isActive = Convert.ToBoolean(row.Cells["IsActive"].Value);
            int userId = Convert.ToInt32(row.Cells["Userid"].Value);
            bl.UpdateAccount(userId, isActive);
        }

        private void txtNameFilter_TextChanged(object sender, EventArgs e)
        {
            BLAdmin bl = new BLAdmin();
            gridAccounts.DataSource = bl.GetAccounts(txtNameFilter.Text);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtNameFilter.Text = "";
        }
    }
}
