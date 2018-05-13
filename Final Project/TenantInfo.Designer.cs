namespace Final_Project
{
    partial class TenantInfo
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateRentStart = new System.Windows.Forms.DateTimePicker();
            this.numRent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numChildren = new System.Windows.Forms.NumericUpDown();
            this.textLeadPhone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLeadTenantLast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textLeadTenantFirst = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textTenantPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnAddTenant = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTenantLast = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.textTenantFirst = new System.Windows.Forms.TextBox();
            this.dataTenants = new System.Windows.Forms.DataGridView();
            this.DataGridTennantFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGripPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DataGridDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTenants)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.AccessibleName = "btnNext";
            this.btnNext.Location = new System.Drawing.Point(747, 493);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(156, 39);
            this.btnNext.TabIndex = 46;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "btnBack";
            this.btnBack.Location = new System.Drawing.Point(32, 493);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 39);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateRentStart);
            this.groupBox1.Controls.Add(this.numRent);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numChildren);
            this.groupBox1.Controls.Add(this.textLeadPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textLeadTenantLast);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textLeadTenantFirst);
            this.groupBox1.Location = new System.Drawing.Point(32, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 180);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lead Tenant";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(611, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Rent Start";
            // 
            // dateRentStart
            // 
            this.dateRentStart.AccessibleName = "dateLastPaint";
            this.dateRentStart.Checked = false;
            this.dateRentStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRentStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRentStart.Location = new System.Drawing.Point(703, 88);
            this.dateRentStart.Name = "dateRentStart";
            this.dateRentStart.ShowCheckBox = true;
            this.dateRentStart.Size = new System.Drawing.Size(144, 26);
            this.dateRentStart.TabIndex = 62;
            // 
            // numRent
            // 
            this.numRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRent.Location = new System.Drawing.Point(355, 93);
            this.numRent.MaxLength = 20;
            this.numRent.Name = "numRent";
            this.numRent.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.numRent.Size = new System.Drawing.Size(163, 26);
            this.numRent.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(295, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Rent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Children";
            // 
            // numChildren
            // 
            this.numChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numChildren.Location = new System.Drawing.Point(104, 94);
            this.numChildren.Name = "numChildren";
            this.numChildren.Size = new System.Drawing.Size(120, 26);
            this.numChildren.TabIndex = 58;
            // 
            // textLeadPhone
            // 
            this.textLeadPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLeadPhone.Location = new System.Drawing.Point(703, 26);
            this.textLeadPhone.Mask = "999-000-0000";
            this.textLeadPhone.Name = "textLeadPhone";
            this.textLeadPhone.Size = new System.Drawing.Size(144, 26);
            this.textLeadPhone.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Last Name";
            // 
            // textLeadTenantLast
            // 
            this.textLeadTenantLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLeadTenantLast.Location = new System.Drawing.Point(355, 29);
            this.textLeadTenantLast.MaxLength = 20;
            this.textLeadTenantLast.Name = "textLeadTenantLast";
            this.textLeadTenantLast.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textLeadTenantLast.Size = new System.Drawing.Size(163, 26);
            this.textLeadTenantLast.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "First Name";
            // 
            // textLeadTenantFirst
            // 
            this.textLeadTenantFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLeadTenantFirst.Location = new System.Drawing.Point(102, 32);
            this.textLeadTenantFirst.MaxLength = 20;
            this.textLeadTenantFirst.Name = "textLeadTenantFirst";
            this.textLeadTenantFirst.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textLeadTenantFirst.Size = new System.Drawing.Size(122, 26);
            this.textLeadTenantFirst.TabIndex = 54;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textTenantPhone);
            this.groupBox2.Controls.Add(this.btnAddTenant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textTenantLast);
            this.groupBox2.Controls.Add(this.lblFirstName);
            this.groupBox2.Controls.Add(this.textTenantFirst);
            this.groupBox2.Controls.Add(this.dataTenants);
            this.groupBox2.Location = new System.Drawing.Point(36, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 241);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Tenants";
            // 
            // textTenantPhone
            // 
            this.textTenantPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenantPhone.Location = new System.Drawing.Point(617, 22);
            this.textTenantPhone.Mask = "999-000-0000";
            this.textTenantPhone.Name = "textTenantPhone";
            this.textTenantPhone.Size = new System.Drawing.Size(124, 26);
            this.textTenantPhone.TabIndex = 37;
            // 
            // btnAddTenant
            // 
            this.btnAddTenant.Location = new System.Drawing.Point(768, 25);
            this.btnAddTenant.Name = "btnAddTenant";
            this.btnAddTenant.Size = new System.Drawing.Size(75, 23);
            this.btnAddTenant.TabIndex = 53;
            this.btnAddTenant.Text = "Add";
            this.btnAddTenant.UseVisualStyleBackColor = true;
            this.btnAddTenant.Click += new System.EventHandler(this.btnAddTenant_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Last Name";
            // 
            // textTenantLast
            // 
            this.textTenantLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenantLast.Location = new System.Drawing.Point(327, 22);
            this.textTenantLast.MaxLength = 20;
            this.textTenantLast.Name = "textTenantLast";
            this.textTenantLast.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textTenantLast.Size = new System.Drawing.Size(163, 26);
            this.textTenantLast.TabIndex = 50;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 47;
            this.lblFirstName.Text = "First Name";
            // 
            // textTenantFirst
            // 
            this.textTenantFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenantFirst.Location = new System.Drawing.Point(98, 25);
            this.textTenantFirst.MaxLength = 20;
            this.textTenantFirst.Name = "textTenantFirst";
            this.textTenantFirst.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textTenantFirst.Size = new System.Drawing.Size(122, 26);
            this.textTenantFirst.TabIndex = 48;
            // 
            // dataTenants
            // 
            this.dataTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridTennantFirst,
            this.DataGridLastName,
            this.DataGripPhone,
            this.dataGridEdit,
            this.DataGridDelete});
            this.dataTenants.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataTenants.Location = new System.Drawing.Point(4, 54);
            this.dataTenants.Name = "dataTenants";
            this.dataTenants.RowTemplate.ReadOnly = true;
            this.dataTenants.Size = new System.Drawing.Size(861, 168);
            this.dataTenants.TabIndex = 46;
            this.dataTenants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTenants_CellContentClick);
            this.dataTenants.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataTenants_UserAddedRow);
            // 
            // DataGridTennantFirst
            // 
            this.DataGridTennantFirst.HeaderText = "First Name";
            this.DataGridTennantFirst.Name = "DataGridTennantFirst";
            this.DataGridTennantFirst.Width = 200;
            // 
            // DataGridLastName
            // 
            this.DataGridLastName.HeaderText = "Last Name";
            this.DataGridLastName.Name = "DataGridLastName";
            this.DataGridLastName.Width = 200;
            // 
            // DataGripPhone
            // 
            this.DataGripPhone.FillWeight = 200F;
            this.DataGripPhone.HeaderText = "Phone Number";
            this.DataGripPhone.Name = "DataGripPhone";
            this.DataGripPhone.Width = 200;
            // 
            // dataGridEdit
            // 
            this.dataGridEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dataGridEdit.HeaderText = "";
            this.dataGridEdit.Name = "dataGridEdit";
            this.dataGridEdit.Text = "Edit";
            // 
            // DataGridDelete
            // 
            this.DataGridDelete.HeaderText = "Delete";
            this.DataGridDelete.Name = "DataGridDelete";
            this.DataGridDelete.Text = "Delete";
            // 
            // TenantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Name = "TenantInfo";
            this.Text = "TenantInfo";
            this.Load += new System.EventHandler(this.TenantInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTenants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox textTenantPhone;
        private System.Windows.Forms.Button btnAddTenant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTenantLast;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox textTenantFirst;
        private System.Windows.Forms.DataGridView dataTenants;
        private System.Windows.Forms.TextBox numRent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numChildren;
        private System.Windows.Forms.MaskedTextBox textLeadPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLeadTenantLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLeadTenantFirst;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateRentStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridTennantFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGripPhone;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridEdit;
        private System.Windows.Forms.DataGridViewButtonColumn DataGridDelete;
    }
}