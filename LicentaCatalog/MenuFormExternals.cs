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
    public partial class MenuFormExternals : Form
    {
        public MenuFormExternals()
        {
            InitializeComponent();
        }

        int idUser, idType;

        public MenuFormExternals(int idUser, int idType)
        {
            InitializeComponent();
            openChildFormInPanel(new HomeForm(idType));
            this.idUser = idUser;
            this.idType = idType;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblTopPanel.Text = "Acasa";
            openChildFormInPanel(new HomeForm(idType));
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            lblTopPanel.Text = "Cereri";
            openChildFormInPanel(new ExternalRequestsForm(idUser));
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            lblTopPanel.Text = "Catalog";
            openChildFormInPanel(new ExternalsCatalogForm(idUser));
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
    }
}
