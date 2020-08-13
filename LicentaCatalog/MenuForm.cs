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
using System.Threading;

namespace LicentaCatalog
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        int idUser, idType;

        public MenuForm(int idUser, int idType)
        {
            InitializeComponent();
            openChildFormInPanel(new HomeForm(idType));
            customizeDesign();
            this.idUser = idUser;
            this.idType = idType;
        }

        private void customizeDesign()
        {
            panelCatalogSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelCatalogSubmenu.Visible == true)
                panelCatalogSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCatalogSubmenu);
        }

        private void btnYear1_Click(object sender, EventArgs e)
        {
            // DOAR PT STUDENTI (_idType = 1)
            openChildFormInPanel(new StudentYearsForm(idUser, 1));
            lblTopPanel.Text = "Anul 1";
            hideSubMenu();
        }

        private void btnYear2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new StudentYearsForm(idUser, 2));
            lblTopPanel.Text = "Anul 2";
            hideSubMenu();
        }

        private void btnYear3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new StudentYearsForm(idUser, 3));
            lblTopPanel.Text = "Anul 3";
            hideSubMenu();
        }

        private void btnYear4_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new StudentYearsForm(idUser, 4));
            lblTopPanel.Text = "Anul 4";
            hideSubMenu();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new HomeForm(idType));
            lblTopPanel.Text = "Acasa";
            hideSubMenu();
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new HomeForm());
            lblTopPanel.Text = "Altele";
            hideSubMenu(); 
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

        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
