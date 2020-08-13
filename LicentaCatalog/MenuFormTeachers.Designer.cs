namespace LicentaCatalog
{
    partial class MenuFormTeachers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFormTeachers));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnMaterii = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.picCatalogIconMenu = new System.Windows.Forms.PictureBox();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.lblTopPanel = new System.Windows.Forms.Label();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCatalogIconMenu)).BeginInit();
            this.panelTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.panelSideMenu.Controls.Add(this.btnDisconnect);
            this.panelSideMenu.Controls.Add(this.btnMaterii);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.panelTopLeft);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 661);
            this.panelSideMenu.TabIndex = 1;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(94)))));
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnDisconnect.Location = new System.Drawing.Point(0, 611);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDisconnect.Size = new System.Drawing.Size(250, 50);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Deconectare";
            this.btnDisconnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnMaterii
            // 
            this.btnMaterii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.btnMaterii.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterii.FlatAppearance.BorderSize = 0;
            this.btnMaterii.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(94)))));
            this.btnMaterii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterii.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterii.ForeColor = System.Drawing.Color.Silver;
            this.btnMaterii.Location = new System.Drawing.Point(0, 173);
            this.btnMaterii.Name = "btnMaterii";
            this.btnMaterii.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMaterii.Size = new System.Drawing.Size(250, 50);
            this.btnMaterii.TabIndex = 1;
            this.btnMaterii.Text = "Materii";
            this.btnMaterii.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterii.UseVisualStyleBackColor = false;
            this.btnMaterii.Click += new System.EventHandler(this.btnMaterii_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(30)))), ((int)(((byte)(94)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Silver;
            this.btnHome.Location = new System.Drawing.Point(0, 123);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Acasa";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.picCatalogIconMenu);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(250, 123);
            this.panelTopLeft.TabIndex = 0;
            // 
            // picCatalogIconMenu
            // 
            this.picCatalogIconMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.picCatalogIconMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCatalogIconMenu.Image = global::LicentaCatalog.Properties.Resources.catalog_icon_whitegrey;
            this.picCatalogIconMenu.Location = new System.Drawing.Point(0, 0);
            this.picCatalogIconMenu.Name = "picCatalogIconMenu";
            this.picCatalogIconMenu.Size = new System.Drawing.Size(250, 123);
            this.picCatalogIconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCatalogIconMenu.TabIndex = 0;
            this.picCatalogIconMenu.TabStop = false;
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.panelTopMenu.Controls.Add(this.lblTopPanel);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(250, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(834, 123);
            this.panelTopMenu.TabIndex = 2;
            // 
            // lblTopPanel
            // 
            this.lblTopPanel.AutoSize = true;
            this.lblTopPanel.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPanel.ForeColor = System.Drawing.Color.Silver;
            this.lblTopPanel.Location = new System.Drawing.Point(19, 48);
            this.lblTopPanel.Name = "lblTopPanel";
            this.lblTopPanel.Size = new System.Drawing.Size(83, 34);
            this.lblTopPanel.TabIndex = 0;
            this.lblTopPanel.Text = "Acasa";
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(250, 123);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(834, 538);
            this.panelMainMenu.TabIndex = 3;
            // 
            // MenuFormTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelTopMenu);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "MenuFormTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicatie situatie scolara";
            this.panelSideMenu.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCatalogIconMenu)).EndInit();
            this.panelTopMenu.ResumeLayout(false);
            this.panelTopMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnMaterii;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.PictureBox picCatalogIconMenu;
        private System.Windows.Forms.Panel panelTopMenu;
        public System.Windows.Forms.Label lblTopPanel;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button btnDisconnect;
    }
}