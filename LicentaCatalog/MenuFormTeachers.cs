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
    public partial class MenuFormTeachers : Form
    {
        public MenuFormTeachers()
        {
            InitializeComponent();
        }

        int idUser, idType;

        public MenuFormTeachers(int idUser, int idType)
        {
            InitializeComponent();
            openChildFormInPanel(new HomeForm(idType));
            this.idUser = idUser;
            this.idType = idType;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new HomeForm(idType));
            lblTopPanel.Text = "Acasa";
        }

        private void btnMaterii_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new TeacherCoursesForm(idUser));
            lblTopPanel.Text = "Materii";
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new HomeForm());
            lblTopPanel.Text = "Altele";
        }

        private Form activeForm = null;

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
    }
}
