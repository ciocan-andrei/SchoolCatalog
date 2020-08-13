namespace LicentaCatalog
{
    partial class EditTeachersForm
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
            this.gridTeachers = new System.Windows.Forms.DataGridView();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.lblNameFilter = new System.Windows.Forms.Label();
            this.txtNameFilter = new System.Windows.Forms.TextBox();
            this.txtSurnameFilter = new System.Windows.Forms.TextBox();
            this.lblSurnameFilter = new System.Windows.Forms.Label();
            this.lblGroupFilter = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.gridCourses = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.comboBoxSet = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblSet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTeachers
            // 
            this.gridTeachers.AllowUserToAddRows = false;
            this.gridTeachers.AllowUserToDeleteRows = false;
            this.gridTeachers.AllowUserToResizeRows = false;
            this.gridTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTeachers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.gridTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeachers.Location = new System.Drawing.Point(12, 61);
            this.gridTeachers.Name = "gridTeachers";
            this.gridTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTeachers.Size = new System.Drawing.Size(810, 232);
            this.gridTeachers.TabIndex = 0;
            this.gridTeachers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridTeachers_CellMouseClick);
            this.gridTeachers.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridTeachers_CellValidating);
            this.gridTeachers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTeachers_CellValueChanged);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilters.ForeColor = System.Drawing.Color.White;
            this.btnClearFilters.Location = new System.Drawing.Point(435, 28);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(86, 27);
            this.btnClearFilters.TabIndex = 14;
            this.btnClearFilters.Text = "Curata filtre";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click_1);
            // 
            // lblNameFilter
            // 
            this.lblNameFilter.AutoSize = true;
            this.lblNameFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFilter.ForeColor = System.Drawing.Color.White;
            this.lblNameFilter.Location = new System.Drawing.Point(9, 9);
            this.lblNameFilter.Name = "lblNameFilter";
            this.lblNameFilter.Size = new System.Drawing.Size(43, 16);
            this.lblNameFilter.TabIndex = 11;
            this.lblNameFilter.Text = "Nume";
            // 
            // txtNameFilter
            // 
            this.txtNameFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.txtNameFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFilter.ForeColor = System.Drawing.Color.White;
            this.txtNameFilter.Location = new System.Drawing.Point(12, 28);
            this.txtNameFilter.Name = "txtNameFilter";
            this.txtNameFilter.Size = new System.Drawing.Size(135, 27);
            this.txtNameFilter.TabIndex = 8;
            this.txtNameFilter.TextChanged += new System.EventHandler(this.txtNameFilter_TextChanged);
            // 
            // txtSurnameFilter
            // 
            this.txtSurnameFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.txtSurnameFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurnameFilter.ForeColor = System.Drawing.Color.White;
            this.txtSurnameFilter.Location = new System.Drawing.Point(153, 28);
            this.txtSurnameFilter.Name = "txtSurnameFilter";
            this.txtSurnameFilter.Size = new System.Drawing.Size(135, 27);
            this.txtSurnameFilter.TabIndex = 9;
            this.txtSurnameFilter.TextChanged += new System.EventHandler(this.txtSurnameFilter_TextChanged);
            // 
            // lblSurnameFilter
            // 
            this.lblSurnameFilter.AutoSize = true;
            this.lblSurnameFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameFilter.ForeColor = System.Drawing.Color.White;
            this.lblSurnameFilter.Location = new System.Drawing.Point(150, 9);
            this.lblSurnameFilter.Name = "lblSurnameFilter";
            this.lblSurnameFilter.Size = new System.Drawing.Size(59, 16);
            this.lblSurnameFilter.TabIndex = 12;
            this.lblSurnameFilter.Text = "Prenume";
            // 
            // lblGroupFilter
            // 
            this.lblGroupFilter.AutoSize = true;
            this.lblGroupFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupFilter.ForeColor = System.Drawing.Color.White;
            this.lblGroupFilter.Location = new System.Drawing.Point(291, 9);
            this.lblGroupFilter.Name = "lblGroupFilter";
            this.lblGroupFilter.Size = new System.Drawing.Size(54, 16);
            this.lblGroupFilter.TabIndex = 13;
            this.lblGroupFilter.Text = "Catedra";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.comboBoxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDept.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDept.ForeColor = System.Drawing.Color.White;
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Items.AddRange(new object[] {
            "EAII",
            "Telecom",
            "DCAE",
            "TEF"});
            this.comboBoxDept.Location = new System.Drawing.Point(294, 28);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(135, 27);
            this.comboBoxDept.TabIndex = 15;
            this.comboBoxDept.SelectedIndexChanged += new System.EventHandler(this.comboBoxDept_SelectedIndexChanged);
            // 
            // gridCourses
            // 
            this.gridCourses.AllowUserToAddRows = false;
            this.gridCourses.AllowUserToDeleteRows = false;
            this.gridCourses.AllowUserToResizeRows = false;
            this.gridCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gridCourses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.gridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourses.Location = new System.Drawing.Point(17, 334);
            this.gridCourses.Name = "gridCourses";
            this.gridCourses.ReadOnly = true;
            this.gridCourses.RowHeadersVisible = false;
            this.gridCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourses.Size = new System.Drawing.Size(438, 192);
            this.gridCourses.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(461, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Adauga materie";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(461, 447);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Sterge materie";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.comboBoxCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourses.DropDownWidth = 350;
            this.comboBoxCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCourses.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourses.ForeColor = System.Drawing.Color.White;
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Items.AddRange(new object[] {
            "EAII",
            "Telecom",
            "DCAE",
            "TEF"});
            this.comboBoxCourses.Location = new System.Drawing.Point(461, 334);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(191, 22);
            this.comboBoxCourses.TabIndex = 20;
            this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourses_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(17, 315);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(29, 16);
            this.lblInfo.TabIndex = 21;
            this.lblInfo.Text = "Info";
            // 
            // comboBoxSet
            // 
            this.comboBoxSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.comboBoxSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSet.DropDownWidth = 22;
            this.comboBoxSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSet.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSet.ForeColor = System.Drawing.Color.White;
            this.comboBoxSet.FormattingEnabled = true;
            this.comboBoxSet.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboBoxSet.Location = new System.Drawing.Point(461, 378);
            this.comboBoxSet.Name = "comboBoxSet";
            this.comboBoxSet.Size = new System.Drawing.Size(112, 22);
            this.comboBoxSet.TabIndex = 22;
            this.comboBoxSet.SelectedIndexChanged += new System.EventHandler(this.comboBoxSet_SelectedIndexChanged);
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.White;
            this.lblCourse.Location = new System.Drawing.Point(458, 317);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(138, 16);
            this.lblCourse.TabIndex = 23;
            this.lblCourse.Text = "Selectati materia dorita...";
            // 
            // lblSet
            // 
            this.lblSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.ForeColor = System.Drawing.Color.White;
            this.lblSet.Location = new System.Drawing.Point(458, 359);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(88, 16);
            this.lblSet.TabIndex = 24;
            this.lblSet.Text = "Selectati seria...";
            // 
            // EditTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(834, 538);
            this.Controls.Add(this.lblSet);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.comboBoxSet);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.comboBoxCourses);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridCourses);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.lblGroupFilter);
            this.Controls.Add(this.lblSurnameFilter);
            this.Controls.Add(this.lblNameFilter);
            this.Controls.Add(this.txtSurnameFilter);
            this.Controls.Add(this.txtNameFilter);
            this.Controls.Add(this.gridTeachers);
            this.Name = "EditTeachersForm";
            this.Text = "EditTeachersForm";
            this.Load += new System.EventHandler(this.EditTeachersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTeachers;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Label lblNameFilter;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.TextBox txtSurnameFilter;
        private System.Windows.Forms.Label lblSurnameFilter;
        private System.Windows.Forms.Label lblGroupFilter;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.DataGridView gridCourses;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox comboBoxSet;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblSet;
    }
}