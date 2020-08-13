namespace LicentaCatalog
{
    partial class EditStudentsForm
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
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.txtNameFilter = new System.Windows.Forms.TextBox();
            this.txtSurnameFilter = new System.Windows.Forms.TextBox();
            this.txtGroupFilter = new System.Windows.Forms.TextBox();
            this.lblNameFilter = new System.Windows.Forms.Label();
            this.lblSurnameFilter = new System.Windows.Forms.Label();
            this.lblGroupFilter = new System.Windows.Forms.Label();
            this.btnClearFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStudents
            // 
            this.gridStudents.AllowUserToAddRows = false;
            this.gridStudents.AllowUserToDeleteRows = false;
            this.gridStudents.AllowUserToResizeRows = false;
            this.gridStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Location = new System.Drawing.Point(12, 61);
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudents.Size = new System.Drawing.Size(810, 465);
            this.gridStudents.TabIndex = 0;
            this.gridStudents.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridStudents_CellValidating);
            this.gridStudents.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStudents_CellValueChanged);
            // 
            // txtNameFilter
            // 
            this.txtNameFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.txtNameFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFilter.ForeColor = System.Drawing.Color.White;
            this.txtNameFilter.Location = new System.Drawing.Point(12, 28);
            this.txtNameFilter.Name = "txtNameFilter";
            this.txtNameFilter.Size = new System.Drawing.Size(135, 27);
            this.txtNameFilter.TabIndex = 1;
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
            this.txtSurnameFilter.TabIndex = 2;
            this.txtSurnameFilter.TextChanged += new System.EventHandler(this.txtSurnameFilter_TextChanged);
            // 
            // txtGroupFilter
            // 
            this.txtGroupFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.txtGroupFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupFilter.ForeColor = System.Drawing.Color.White;
            this.txtGroupFilter.Location = new System.Drawing.Point(294, 28);
            this.txtGroupFilter.Name = "txtGroupFilter";
            this.txtGroupFilter.Size = new System.Drawing.Size(135, 27);
            this.txtGroupFilter.TabIndex = 3;
            this.txtGroupFilter.TextChanged += new System.EventHandler(this.txtGroupFilter_TextChanged);
            // 
            // lblNameFilter
            // 
            this.lblNameFilter.AutoSize = true;
            this.lblNameFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFilter.ForeColor = System.Drawing.Color.White;
            this.lblNameFilter.Location = new System.Drawing.Point(9, 9);
            this.lblNameFilter.Name = "lblNameFilter";
            this.lblNameFilter.Size = new System.Drawing.Size(43, 16);
            this.lblNameFilter.TabIndex = 4;
            this.lblNameFilter.Text = "Nume";
            // 
            // lblSurnameFilter
            // 
            this.lblSurnameFilter.AutoSize = true;
            this.lblSurnameFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameFilter.ForeColor = System.Drawing.Color.White;
            this.lblSurnameFilter.Location = new System.Drawing.Point(150, 9);
            this.lblSurnameFilter.Name = "lblSurnameFilter";
            this.lblSurnameFilter.Size = new System.Drawing.Size(59, 16);
            this.lblSurnameFilter.TabIndex = 5;
            this.lblSurnameFilter.Text = "Prenume";
            // 
            // lblGroupFilter
            // 
            this.lblGroupFilter.AutoSize = true;
            this.lblGroupFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupFilter.ForeColor = System.Drawing.Color.White;
            this.lblGroupFilter.Location = new System.Drawing.Point(291, 9);
            this.lblGroupFilter.Name = "lblGroupFilter";
            this.lblGroupFilter.Size = new System.Drawing.Size(44, 16);
            this.lblGroupFilter.TabIndex = 6;
            this.lblGroupFilter.Text = "Grupa";
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilters.ForeColor = System.Drawing.Color.White;
            this.btnClearFilters.Location = new System.Drawing.Point(435, 28);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(86, 27);
            this.btnClearFilters.TabIndex = 7;
            this.btnClearFilters.Text = "Curata filtre";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // EditStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(834, 538);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.lblGroupFilter);
            this.Controls.Add(this.lblSurnameFilter);
            this.Controls.Add(this.lblNameFilter);
            this.Controls.Add(this.txtGroupFilter);
            this.Controls.Add(this.txtSurnameFilter);
            this.Controls.Add(this.txtNameFilter);
            this.Controls.Add(this.gridStudents);
            this.Name = "EditStudentsForm";
            this.Text = "EditStudentsForm";
            this.Load += new System.EventHandler(this.EditStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.TextBox txtSurnameFilter;
        private System.Windows.Forms.TextBox txtGroupFilter;
        private System.Windows.Forms.Label lblNameFilter;
        private System.Windows.Forms.Label lblSurnameFilter;
        private System.Windows.Forms.Label lblGroupFilter;
        private System.Windows.Forms.Button btnClearFilters;
    }
}