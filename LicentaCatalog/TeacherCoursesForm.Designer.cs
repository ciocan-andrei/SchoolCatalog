namespace LicentaCatalog
{
    partial class TeacherCoursesForm
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
            this.gridTeacherCourses = new System.Windows.Forms.DataGridView();
            this.gridTeacherStudents = new System.Windows.Forms.DataGridView();
            this.txtNameFilter = new System.Windows.Forms.TextBox();
            this.txtGroupFilter = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.pictureFilter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeacherCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeacherStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTeacherCourses
            // 
            this.gridTeacherCourses.AllowUserToAddRows = false;
            this.gridTeacherCourses.AllowUserToDeleteRows = false;
            this.gridTeacherCourses.AllowUserToResizeRows = false;
            this.gridTeacherCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTeacherCourses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.gridTeacherCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeacherCourses.Location = new System.Drawing.Point(12, 21);
            this.gridTeacherCourses.MultiSelect = false;
            this.gridTeacherCourses.Name = "gridTeacherCourses";
            this.gridTeacherCourses.ReadOnly = true;
            this.gridTeacherCourses.RowHeadersVisible = false;
            this.gridTeacherCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTeacherCourses.Size = new System.Drawing.Size(810, 132);
            this.gridTeacherCourses.TabIndex = 0;
            this.gridTeacherCourses.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridTeacherCourses_CellMouseClick);
            // 
            // gridTeacherStudents
            // 
            this.gridTeacherStudents.AllowUserToAddRows = false;
            this.gridTeacherStudents.AllowUserToDeleteRows = false;
            this.gridTeacherStudents.AllowUserToResizeRows = false;
            this.gridTeacherStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTeacherStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.gridTeacherStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeacherStudents.Location = new System.Drawing.Point(13, 209);
            this.gridTeacherStudents.MultiSelect = false;
            this.gridTeacherStudents.Name = "gridTeacherStudents";
            this.gridTeacherStudents.RowHeadersVisible = false;
            this.gridTeacherStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTeacherStudents.Size = new System.Drawing.Size(809, 317);
            this.gridTeacherStudents.TabIndex = 1;
            this.gridTeacherStudents.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTeacherStudents_CellValueChanged);
            this.gridTeacherStudents.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridTeacherStudents_EditingControlShowing);
            this.gridTeacherStudents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridTeacherStudents_KeyPress);
            // 
            // txtNameFilter
            // 
            this.txtNameFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.txtNameFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFilter.ForeColor = System.Drawing.Color.White;
            this.txtNameFilter.Location = new System.Drawing.Point(89, 180);
            this.txtNameFilter.Name = "txtNameFilter";
            this.txtNameFilter.Size = new System.Drawing.Size(124, 24);
            this.txtNameFilter.TabIndex = 2;
            this.txtNameFilter.TextChanged += new System.EventHandler(this.txtNameFilter_TextChanged);
            // 
            // txtGroupFilter
            // 
            this.txtGroupFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.txtGroupFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupFilter.ForeColor = System.Drawing.Color.White;
            this.txtGroupFilter.Location = new System.Drawing.Point(222, 180);
            this.txtGroupFilter.Name = "txtGroupFilter";
            this.txtGroupFilter.Size = new System.Drawing.Size(124, 24);
            this.txtGroupFilter.TabIndex = 3;
            this.txtGroupFilter.TextChanged += new System.EventHandler(this.txtGroupFilter_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(88, 165);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nume";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.White;
            this.lblGroup.Location = new System.Drawing.Point(219, 165);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(44, 16);
            this.lblGroup.TabIndex = 5;
            this.lblGroup.Text = "Grupa";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(28, 182);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(59, 21);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Filtrare";
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilters.ForeColor = System.Drawing.Color.White;
            this.btnClearFilters.Location = new System.Drawing.Point(352, 180);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(81, 23);
            this.btnClearFilters.TabIndex = 8;
            this.btnClearFilters.Text = "Curata filtre";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClearFilters_MouseClick);
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.ForeColor = System.Drawing.Color.White;
            this.lblSelectCourse.Location = new System.Drawing.Point(11, 5);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(103, 16);
            this.lblSelectCourse.TabIndex = 9;
            this.lblSelectCourse.Text = "Selectati cursul...";
            // 
            // pictureFilter
            // 
            this.pictureFilter.Image = global::LicentaCatalog.Properties.Resources.filter_white_15x15;
            this.pictureFilter.Location = new System.Drawing.Point(14, 184);
            this.pictureFilter.Name = "pictureFilter";
            this.pictureFilter.Size = new System.Drawing.Size(15, 15);
            this.pictureFilter.TabIndex = 6;
            this.pictureFilter.TabStop = false;
            // 
            // TeacherCoursesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(834, 538);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.pictureFilter);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtGroupFilter);
            this.Controls.Add(this.txtNameFilter);
            this.Controls.Add(this.gridTeacherStudents);
            this.Controls.Add(this.gridTeacherCourses);
            this.Name = "TeacherCoursesForm";
            this.Text = "TeacherCoursesForm";
            this.Load += new System.EventHandler(this.TeacherCoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTeacherCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeacherStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTeacherCourses;
        private System.Windows.Forms.DataGridView gridTeacherStudents;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.TextBox txtGroupFilter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.PictureBox pictureFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Label lblSelectCourse;
    }
}