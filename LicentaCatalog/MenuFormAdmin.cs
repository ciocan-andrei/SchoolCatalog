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
    public partial class MenuFormAdmin : Form
    {
        public MenuFormAdmin()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainMenu.Controls.Add(childForm);
            panelMainMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
            loginForm.FormClosed += LoginForm_FormClosed;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnNewAccs_Click(object sender, EventArgs e)
        {
            lblTopPanel.Text = "Validare conturi noi";
            openChildFormInPanel(new ValidateAccountsForm());
        }

        private void btnRequestsView_Click(object sender, EventArgs e)
        {
            lblTopPanel.Text = "Validare cereri ale utilizatorilor externi";
            openChildFormInPanel(new ValidateRequestsForm());
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            lblTopPanel.Text = "Activare/dezactivare conturi";
            openChildFormInPanel(new ManageAccountsForm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblTopPanel.Text = "Acasa";
            openChildFormInPanel(new HomeForm(3));
        }

        private void MenuFormAdmin_Load(object sender, EventArgs e)
        {
            lblTopPanel.Text = "Acasa";
            openChildFormInPanel(new HomeForm(3));
        }

        private void btnChangeStudents_Click(object sender, EventArgs e)
        {
            lblTopPanel.Text = "Modificari studenti";
            openChildFormInPanel(new EditStudentsForm());
        }

        private void btnChangeTeachers_Click(object sender, EventArgs e)
        {
            lblTopPanel.Text = "Modificari profesori";
            openChildFormInPanel(new EditTeachersForm());
        }
    }
}
