namespace LicentaCatalog
{
    partial class ExternalRequestsForm
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
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtGroupFilter = new System.Windows.Forms.TextBox();
            this.txtNameFilter = new System.Windows.Forms.TextBox();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.richTxtReason = new System.Windows.Forms.RichTextBox();
            this.gridAwaitingRequests = new System.Windows.Forms.DataGridView();
            this.gridAcceptedRequests = new System.Windows.Forms.DataGridView();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnInsertRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureFilter = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAwaitingRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAcceptedRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFilter)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilters.ForeColor = System.Drawing.Color.White;
            this.btnClearFilters.Location = new System.Drawing.Point(162, 145);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(122, 23);
            this.btnClearFilters.TabIndex = 15;
            this.btnClearFilters.Text = "Curata filtre";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(172, 10);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(119, 21);
            this.lblFilter.TabIndex = 14;
            this.lblFilter.Text = "Filtrare studenti";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.White;
            this.lblGroup.Location = new System.Drawing.Point(134, 91);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(44, 16);
            this.lblGroup.TabIndex = 12;
            this.lblGroup.Text = "Grupa";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(134, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Nume";
            // 
            // txtGroupFilter
            // 
            this.txtGroupFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.txtGroupFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupFilter.ForeColor = System.Drawing.Color.White;
            this.txtGroupFilter.Location = new System.Drawing.Point(134, 110);
            this.txtGroupFilter.Name = "txtGroupFilter";
            this.txtGroupFilter.Size = new System.Drawing.Size(174, 24);
            this.txtGroupFilter.TabIndex = 10;
            this.txtGroupFilter.TextChanged += new System.EventHandler(this.txtGroupFilter_TextChanged);
            // 
            // txtNameFilter
            // 
            this.txtNameFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.txtNameFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFilter.ForeColor = System.Drawing.Color.White;
            this.txtNameFilter.Location = new System.Drawing.Point(134, 64);
            this.txtNameFilter.Name = "txtNameFilter";
            this.txtNameFilter.Size = new System.Drawing.Size(174, 24);
            this.txtNameFilter.TabIndex = 9;
            this.txtNameFilter.TextChanged += new System.EventHandler(this.txtNameFilter_TextChanged);
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.comboBoxStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudents.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStudents.ForeColor = System.Drawing.Color.White;
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(134, 244);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(174, 24);
            this.comboBoxStudents.TabIndex = 16;
            // 
            // richTxtReason
            // 
            this.richTxtReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.richTxtReason.ForeColor = System.Drawing.Color.White;
            this.richTxtReason.Location = new System.Drawing.Point(15, 294);
            this.richTxtReason.Name = "richTxtReason";
            this.richTxtReason.Size = new System.Drawing.Size(417, 154);
            this.richTxtReason.TabIndex = 18;
            this.richTxtReason.Text = "";
            this.richTxtReason.Click += new System.EventHandler(this.richTxtReason_Click);
            // 
            // gridAwaitingRequests
            // 
            this.gridAwaitingRequests.AllowUserToAddRows = false;
            this.gridAwaitingRequests.AllowUserToDeleteRows = false;
            this.gridAwaitingRequests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.gridAwaitingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAwaitingRequests.Location = new System.Drawing.Point(15, 28);
            this.gridAwaitingRequests.Name = "gridAwaitingRequests";
            this.gridAwaitingRequests.ReadOnly = true;
            this.gridAwaitingRequests.RowHeadersVisible = false;
            this.gridAwaitingRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAwaitingRequests.Size = new System.Drawing.Size(353, 216);
            this.gridAwaitingRequests.TabIndex = 19;
            this.gridAwaitingRequests.SelectionChanged += new System.EventHandler(this.gridAwaitingRequests_SelectionChanged);
            // 
            // gridAcceptedRequests
            // 
            this.gridAcceptedRequests.AllowUserToAddRows = false;
            this.gridAcceptedRequests.AllowUserToDeleteRows = false;
            this.gridAcceptedRequests.AllowUserToResizeRows = false;
            this.gridAcceptedRequests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.gridAcceptedRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAcceptedRequests.Location = new System.Drawing.Point(15, 284);
            this.gridAcceptedRequests.Name = "gridAcceptedRequests";
            this.gridAcceptedRequests.ReadOnly = true;
            this.gridAcceptedRequests.RowHeadersVisible = false;
            this.gridAcceptedRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAcceptedRequests.Size = new System.Drawing.Size(353, 242);
            this.gridAcceptedRequests.TabIndex = 20;
            this.gridAcceptedRequests.SelectionChanged += new System.EventHandler(this.gridAcceptedRequests_SelectionChanged);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.ForeColor = System.Drawing.Color.White;
            this.lblReason.Location = new System.Drawing.Point(12, 275);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(41, 16);
            this.lblReason.TabIndex = 21;
            this.lblReason.Text = "Motiv";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.ForeColor = System.Drawing.Color.White;
            this.lblStudent.Location = new System.Drawing.Point(131, 225);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(105, 16);
            this.lblStudent.TabIndex = 22;
            this.lblStudent.Text = "Alegeti studentul";
            // 
            // btnInsertRequest
            // 
            this.btnInsertRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertRequest.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertRequest.ForeColor = System.Drawing.Color.White;
            this.btnInsertRequest.Location = new System.Drawing.Point(162, 457);
            this.btnInsertRequest.Name = "btnInsertRequest";
            this.btnInsertRequest.Size = new System.Drawing.Size(122, 27);
            this.btnInsertRequest.TabIndex = 23;
            this.btnInsertRequest.Text = "Adaugare";
            this.btnInsertRequest.UseVisualStyleBackColor = true;
            this.btnInsertRequest.Click += new System.EventHandler(this.btnInsertRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cereri in asteptare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cereri acceptate";
            // 
            // pictureFilter
            // 
            this.pictureFilter.Image = global::LicentaCatalog.Properties.Resources.filter_white_15x15;
            this.pictureFilter.Location = new System.Drawing.Point(157, 12);
            this.pictureFilter.Name = "pictureFilter";
            this.pictureFilter.Size = new System.Drawing.Size(15, 15);
            this.pictureFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureFilter.TabIndex = 13;
            this.pictureFilter.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTxtReason);
            this.panel1.Controls.Add(this.txtNameFilter);
            this.panel1.Controls.Add(this.txtGroupFilter);
            this.panel1.Controls.Add(this.btnInsertRequest);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblStudent);
            this.panel1.Controls.Add(this.lblGroup);
            this.panel1.Controls.Add(this.lblReason);
            this.panel1.Controls.Add(this.pictureFilter);
            this.panel1.Controls.Add(this.lblFilter);
            this.panel1.Controls.Add(this.btnClearFilters);
            this.panel1.Controls.Add(this.comboBoxStudents);
            this.panel1.Location = new System.Drawing.Point(374, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 498);
            this.panel1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(371, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cerere noua";
            // 
            // ExternalRequestsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(834, 538);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAcceptedRequests);
            this.Controls.Add(this.gridAwaitingRequests);
            this.Name = "ExternalRequestsForm";
            this.Text = "ExternalRequestsForm";
            this.Load += new System.EventHandler(this.ExternalRequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAwaitingRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAcceptedRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFilter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.PictureBox pictureFilter;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtGroupFilter;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.RichTextBox richTxtReason;
        private System.Windows.Forms.DataGridView gridAwaitingRequests;
        private System.Windows.Forms.DataGridView gridAcceptedRequests;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnInsertRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}