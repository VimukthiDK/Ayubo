namespace Ayubo
{
    partial class frmPackage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtVehiType = new System.Windows.Forms.RadioButton();
            this.rbtType = new System.Windows.Forms.RadioButton();
            this.rbtCharges = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCharges = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtMaxKm = new System.Windows.Forms.TextBox();
            this.txtPackType = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVehiType = new System.Windows.Forms.ComboBox();
            this.txtEMaxTime = new System.Windows.Forms.TextBox();
            this.txtEMaxKm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Location = new System.Drawing.Point(495, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 41);
            this.panel2.TabIndex = 62;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 34);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(96, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 34);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToOrderColumns = true;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(34, 78);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(696, 134);
            this.dgvCustomer.TabIndex = 60;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvCustomer.SelectionChanged += new System.EventHandler(this.dgvCustomer_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtVehiType);
            this.groupBox1.Controls.Add(this.rbtType);
            this.groupBox1.Controls.Add(this.rbtCharges);
            this.groupBox1.Location = new System.Drawing.Point(353, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 58);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // rbtVehiType
            // 
            this.rbtVehiType.AutoSize = true;
            this.rbtVehiType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtVehiType.Location = new System.Drawing.Point(235, 18);
            this.rbtVehiType.Name = "rbtVehiType";
            this.rbtVehiType.Size = new System.Drawing.Size(121, 22);
            this.rbtVehiType.TabIndex = 24;
            this.rbtVehiType.Text = "Vehical Type";
            this.rbtVehiType.UseVisualStyleBackColor = true;
            this.rbtVehiType.CheckedChanged += new System.EventHandler(this.rbtVehiType_CheckedChanged);
            // 
            // rbtType
            // 
            this.rbtType.AutoSize = true;
            this.rbtType.Checked = true;
            this.rbtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtType.Location = new System.Drawing.Point(6, 19);
            this.rbtType.Name = "rbtType";
            this.rbtType.Size = new System.Drawing.Size(127, 22);
            this.rbtType.TabIndex = 22;
            this.rbtType.TabStop = true;
            this.rbtType.Text = "Package type";
            this.rbtType.UseVisualStyleBackColor = true;
            // 
            // rbtCharges
            // 
            this.rbtCharges.AutoSize = true;
            this.rbtCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCharges.Location = new System.Drawing.Point(137, 19);
            this.rbtCharges.Name = "rbtCharges";
            this.rbtCharges.Size = new System.Drawing.Size(89, 22);
            this.rbtCharges.TabIndex = 23;
            this.rbtCharges.Text = "Charges";
            this.rbtCharges.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(50, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 41);
            this.panel1.TabIndex = 61;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 34);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(95, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 34);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(186, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 34);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCharges
            // 
            this.txtCharges.BackColor = System.Drawing.Color.White;
            this.txtCharges.Enabled = false;
            this.txtCharges.Location = new System.Drawing.Point(153, 283);
            this.txtCharges.Name = "txtCharges";
            this.txtCharges.Size = new System.Drawing.Size(177, 20);
            this.txtCharges.TabIndex = 56;
            this.txtCharges.Text = "0.0";
            this.txtCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOther
            // 
            this.txtOther.BackColor = System.Drawing.Color.White;
            this.txtOther.Enabled = false;
            this.txtOther.Location = new System.Drawing.Point(153, 366);
            this.txtOther.Multiline = true;
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(177, 55);
            this.txtOther.TabIndex = 57;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.White;
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(153, 339);
            this.txtTime.MaxLength = 10;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(177, 20);
            this.txtTime.TabIndex = 55;
            this.txtTime.Text = "0";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaxKm
            // 
            this.txtMaxKm.BackColor = System.Drawing.Color.White;
            this.txtMaxKm.Enabled = false;
            this.txtMaxKm.Location = new System.Drawing.Point(153, 310);
            this.txtMaxKm.Name = "txtMaxKm";
            this.txtMaxKm.Size = new System.Drawing.Size(177, 20);
            this.txtMaxKm.TabIndex = 54;
            this.txtMaxKm.Text = "0";
            this.txtMaxKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPackType
            // 
            this.txtPackType.BackColor = System.Drawing.Color.White;
            this.txtPackType.Enabled = false;
            this.txtPackType.Location = new System.Drawing.Point(475, 227);
            this.txtPackType.Multiline = true;
            this.txtPackType.Name = "txtPackType";
            this.txtPackType.Size = new System.Drawing.Size(196, 45);
            this.txtPackType.TabIndex = 53;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(89, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 20);
            this.txtSearch.TabIndex = 52;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Other";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Charges";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Max Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Max Km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Package Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Search";
            // 
            // txtPNo
            // 
            this.txtPNo.BackColor = System.Drawing.Color.White;
            this.txtPNo.Enabled = false;
            this.txtPNo.Location = new System.Drawing.Point(153, 226);
            this.txtPNo.Name = "txtPNo";
            this.txtPNo.Size = new System.Drawing.Size(177, 20);
            this.txtPNo.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Package No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Vehical Type";
            // 
            // cmbVehiType
            // 
            this.cmbVehiType.BackColor = System.Drawing.Color.White;
            this.cmbVehiType.Enabled = false;
            this.cmbVehiType.FormattingEnabled = true;
            this.cmbVehiType.Location = new System.Drawing.Point(153, 253);
            this.cmbVehiType.Name = "cmbVehiType";
            this.cmbVehiType.Size = new System.Drawing.Size(177, 21);
            this.cmbVehiType.TabIndex = 66;
            // 
            // txtEMaxTime
            // 
            this.txtEMaxTime.BackColor = System.Drawing.Color.White;
            this.txtEMaxTime.Enabled = false;
            this.txtEMaxTime.Location = new System.Drawing.Point(557, 334);
            this.txtEMaxTime.MaxLength = 10;
            this.txtEMaxTime.Name = "txtEMaxTime";
            this.txtEMaxTime.Size = new System.Drawing.Size(177, 20);
            this.txtEMaxTime.TabIndex = 70;
            this.txtEMaxTime.Text = "0.0";
            this.txtEMaxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEMaxKm
            // 
            this.txtEMaxKm.BackColor = System.Drawing.Color.White;
            this.txtEMaxKm.Enabled = false;
            this.txtEMaxKm.Location = new System.Drawing.Point(556, 305);
            this.txtEMaxKm.Name = "txtEMaxKm";
            this.txtEMaxKm.Size = new System.Drawing.Size(177, 20);
            this.txtEMaxKm.TabIndex = 69;
            this.txtEMaxKm.Text = "0.0";
            this.txtEMaxKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(367, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "ExtraCharges Per Hour";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "ExtraCharges Per Km";
            // 
            // frmPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 503);
            this.Controls.Add(this.txtEMaxTime);
            this.Controls.Add(this.txtEMaxKm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbVehiType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCharges);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtMaxKm);
            this.Controls.Add(this.txtPackType);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package";
            this.Load += new System.EventHandler(this.frmPackage_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtType;
        private System.Windows.Forms.RadioButton rbtCharges;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCharges;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtMaxKm;
        private System.Windows.Forms.TextBox txtPackType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtVehiType;
        private System.Windows.Forms.TextBox txtPNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVehiType;
        private System.Windows.Forms.TextBox txtEMaxTime;
        private System.Windows.Forms.TextBox txtEMaxKm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}