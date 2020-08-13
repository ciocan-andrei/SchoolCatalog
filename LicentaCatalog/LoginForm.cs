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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser_Click(sender, e);
            txtUser.MaxLength = 25;
            txtPass.MaxLength = 25;
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            picUser.Image = Properties.Resources.user_white;
            lblUser.ForeColor = Color.White;
            panelUser.BackColor = Color.White;
            txtUser.ForeColor = Color.White;

            picPass.Image = Properties.Resources.lock_grey;
            lblPass.ForeColor = Color.FromArgb(86, 86, 86);
            panelPass.BackColor = Color.FromArgb(86, 86, 86);
            txtPass.ForeColor = Color.FromArgb(86, 86, 86);
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            picPass.Image = Properties.Resources.lock_white;
            lblPass.ForeColor = Color.White;
            panelPass.BackColor = Color.White;
            txtPass.ForeColor = Color.White;

            picUser.Image = Properties.Resources.user_grey;
            lblUser.ForeColor = Color.FromArgb(86, 86, 86);
            panelUser.BackColor = Color.FromArgb(86, 86, 86);
            txtUser.ForeColor = Color.FromArgb(86, 86, 86);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picExit_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(picExit, "Inchide");
        }

        private void picExit_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(picExit, "Inchide");
        }

        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(picMinimize, "Minimizeaza");
        }

        private void picMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(picMinimize, "Minimizeaza");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Numele de utilizator nu a fost completat.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Parola nu a fost completata.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BLLogin bl = new BLLogin();
            UserModel userModel = bl.CheckUser(txtUser.Text, txtPass.Text, out int status, out Boolean isActive);
            if (status == 2)
            {
                if (isActive == true)
                {
                    if (userModel.UserTypeId == 1)
                    {
                        MenuForm menuForm = new MenuForm(userModel.UserInfoId, userModel.UserTypeId);
                        menuForm.Show();
                        this.Hide();
                        menuForm.FormClosed += Menu_FormClosed;
                    }
                    else if (userModel.UserTypeId == 0)
                    {
                        MenuFormTeachers menuFormTeachers = new MenuFormTeachers(userModel.UserInfoId, userModel.UserTypeId);
                        menuFormTeachers.Show();
                        this.Hide();
                        menuFormTeachers.FormClosed += Menu_FormClosed;
                    }
                    else if (userModel.UserTypeId == 2)
                    {
                        MenuFormExternals menuFormExternals = new MenuFormExternals(userModel.UserInfoId, userModel.UserTypeId);
                        menuFormExternals.Show();
                        this.Hide();
                        menuFormExternals.FormClosed += Menu_FormClosed;
                    }
                    else if (userModel.UserTypeId == 3)
                    {
                        MenuFormAdmin menuFormAdmin = new MenuFormAdmin();
                        menuFormAdmin.Show();
                        this.Hide();
                        menuFormAdmin.FormClosed += Menu_FormClosed;
                    }
                }
                else
                {
                    MessageBox.Show("Utilizatorul nu este activ.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                if (status == 0)
                {
                    MessageBox.Show("Parola introdusa este incorecta", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtUser.Clear();
                    txtPass.Clear();

                    return;
                }
                else
                {
                    MessageBox.Show("Numele de utilizator introdus este gresit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Clear();
                    //txtPass.Clear();
                    return;
                }
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        /* e.SuppressKeyPress e folosit pt a scoate sunetul de pe Enter/Tab */
        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true; 
                txtPass.Focus();
                txtPass_Click(sender, e);
            }

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                txtUser.Focus();
                txtUser_Click(sender, e);
            }

        }
        /* PreviewKeyDown este folosit pt ca in mod normal tasta TAB nu poate fi folosită ca să genereze event-uri */
        private void txtUser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        private void txtPass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        bool drag = false;
        Point start_point = new Point(0, 0);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
            registerForm.FormClosed += RegisterForm_FormClosed;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
