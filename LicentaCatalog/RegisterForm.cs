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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtName_Click(sender, e);
            txtName.MaxLength = 25;
            txtSurname.MaxLength = 25;
            txtPass.MaxLength = 25;
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            lblName.ForeColor = Color.White;
            panelName.BackColor = Color.White;
            txtName.ForeColor = Color.White;

            lblPass.ForeColor = Color.FromArgb(86, 86, 86);
            panelPass.BackColor = Color.FromArgb(86, 86, 86);
            txtPass.ForeColor = Color.FromArgb(86, 86, 86);

            lblSurname.ForeColor = Color.FromArgb(86, 86, 86);
            panelSurname.BackColor = Color.FromArgb(86, 86, 86);
            txtSurname.ForeColor = Color.FromArgb(86, 86, 86);
        }

        private void txtSurname_Click(object sender, EventArgs e)
        {
            lblName.ForeColor = Color.FromArgb(86, 86, 86);
            panelName.BackColor = Color.FromArgb(86, 86, 86);
            txtName.ForeColor = Color.FromArgb(86, 86, 86);

            lblPass.ForeColor = Color.FromArgb(86, 86, 86);
            panelPass.BackColor = Color.FromArgb(86, 86, 86);
            txtPass.ForeColor = Color.FromArgb(86, 86, 86);

            lblSurname.ForeColor = Color.White;
            panelSurname.BackColor = Color.White;
            txtSurname.ForeColor = Color.White;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            lblName.ForeColor = Color.FromArgb(86, 86, 86);
            panelName.BackColor = Color.FromArgb(86, 86, 86);
            txtName.ForeColor = Color.FromArgb(86, 86, 86);

            lblPass.ForeColor = Color.White;
            panelPass.BackColor = Color.White;
            txtPass.ForeColor = Color.White;

            lblSurname.ForeColor = Color.FromArgb(86, 86, 86);
            panelSurname.BackColor = Color.FromArgb(86, 86, 86);
            txtSurname.ForeColor = Color.FromArgb(86, 86, 86);
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnRegister.PerformClick();
            }
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                txtSurname.Focus();
                txtSurname_Click(sender, e);
            }
        }

        private void txtSurname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnRegister.PerformClick();
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
                btnRegister.PerformClick();
            }
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                txtName.Focus();
                txtName_Click(sender, e);
            }
        }

        private void txtName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        private void txtSurname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Numele nu a fost completat.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Prenumele nu a fost completat.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Parola nu a fost completata.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BLRegister bl = new BLRegister();
            bl.Registration(txtName.Text, txtSurname.Text, txtPass.Text);
            String username = bl.GetUsername(txtName.Text, txtSurname.Text, txtPass.Text);
            DialogResult dr = MessageBox.Show("Inregistrarea s-a efectuat cu succes.\nNumele dumneavoastra de utilizator este: " + username + "\nVa rugam sa asteptati activarea contului de catre un administrator.", "Inregistrare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
                loginForm.FormClosed += LoginForm_FormClosed;
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
    }
}
