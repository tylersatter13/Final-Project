namespace Final_Project
{
    partial class FinalizeHouse
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
            this.Roofing = new System.Windows.Forms.GroupBox();
            this.textPrevKey = new System.Windows.Forms.TextBox();
            this.txtCurrentKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datePrevKey = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRoofMaterial = new System.Windows.Forms.Label();
            this.dateCurrentKey = new System.Windows.Forms.DateTimePicker();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textMiscellaneous = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drpPetType = new System.Windows.Forms.ComboBox();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.checkPetFee = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPetRent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPetFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPetBread = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dataPets = new System.Windows.Forms.DataGridView();
            this.dataPetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPetBread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPetFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPetFeePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPetRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Roofing.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPets)).BeginInit();
            this.SuspendLayout();
            // 
            // Roofing
            // 
            this.Roofing.Controls.Add(this.textPrevKey);
            this.Roofing.Controls.Add(this.txtCurrentKey);
            this.Roofing.Controls.Add(this.label3);
            this.Roofing.Controls.Add(this.datePrevKey);
            this.Roofing.Controls.Add(this.label1);
            this.Roofing.Controls.Add(this.label2);
            this.Roofing.Controls.Add(this.lblRoofMaterial);
            this.Roofing.Controls.Add(this.dateCurrentKey);
            this.Roofing.Location = new System.Drawing.Point(23, 280);
            this.Roofing.Name = "Roofing";
            this.Roofing.Size = new System.Drawing.Size(871, 103);
            this.Roofing.TabIndex = 20;
            this.Roofing.TabStop = false;
            this.Roofing.Text = "Keys";
            // 
            // textPrevKey
            // 
            this.textPrevKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrevKey.Location = new System.Drawing.Point(122, 63);
            this.textPrevKey.MaxLength = 6;
            this.textPrevKey.Name = "textPrevKey";
            this.textPrevKey.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textPrevKey.Size = new System.Drawing.Size(143, 26);
            this.textPrevKey.TabIndex = 31;
            this.textPrevKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentKey_KeyPress);
            // 
            // txtCurrentKey
            // 
            this.txtCurrentKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentKey.Location = new System.Drawing.Point(122, 22);
            this.txtCurrentKey.MaxLength = 6;
            this.txtCurrentKey.Name = "txtCurrentKey";
            this.txtCurrentKey.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCurrentKey.Size = new System.Drawing.Size(143, 26);
            this.txtCurrentKey.TabIndex = 30;
            this.txtCurrentKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentKey_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Previous Key";
            // 
            // datePrevKey
            // 
            this.datePrevKey.AccessibleName = "dateLastPaint";
            this.datePrevKey.Checked = false;
            this.datePrevKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePrevKey.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePrevKey.Location = new System.Drawing.Point(705, 71);
            this.datePrevKey.Name = "datePrevKey";
            this.datePrevKey.ShowCheckBox = true;
            this.datePrevKey.Size = new System.Drawing.Size(144, 26);
            this.datePrevKey.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Set Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Set Date";
            // 
            // lblRoofMaterial
            // 
            this.lblRoofMaterial.AutoSize = true;
            this.lblRoofMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoofMaterial.Location = new System.Drawing.Point(28, 28);
            this.lblRoofMaterial.Name = "lblRoofMaterial";
            this.lblRoofMaterial.Size = new System.Drawing.Size(86, 18);
            this.lblRoofMaterial.TabIndex = 24;
            this.lblRoofMaterial.Text = "Current Key";
            // 
            // dateCurrentKey
            // 
            this.dateCurrentKey.AccessibleName = "dateLastPaint";
            this.dateCurrentKey.Checked = false;
            this.dateCurrentKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCurrentKey.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCurrentKey.Location = new System.Drawing.Point(705, 20);
            this.dateCurrentKey.Name = "dateCurrentKey";
            this.dateCurrentKey.ShowCheckBox = true;
            this.dateCurrentKey.Size = new System.Drawing.Size(144, 26);
            this.dateCurrentKey.TabIndex = 23;
            // 
            // btnFinish
            // 
            this.btnFinish.AccessibleName = "btnNext";
            this.btnFinish.Location = new System.Drawing.Point(738, 503);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(156, 39);
            this.btnFinish.TabIndex = 33;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "btnBack";
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.Location = new System.Drawing.Point(23, 503);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 39);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textMiscellaneous);
            this.groupBox1.Location = new System.Drawing.Point(17, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 76);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miscellaneous";
            // 
            // textMiscellaneous
            // 
            this.textMiscellaneous.Location = new System.Drawing.Point(16, 15);
            this.textMiscellaneous.MaxLength = 255;
            this.textMiscellaneous.Multiline = true;
            this.textMiscellaneous.Name = "textMiscellaneous";
            this.textMiscellaneous.Size = new System.Drawing.Size(841, 55);
            this.textMiscellaneous.TabIndex = 0;
            this.textMiscellaneous.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMiscellaneous_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drpPetType);
            this.groupBox2.Controls.Add(this.btnAddPet);
            this.groupBox2.Controls.Add(this.checkPetFee);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textPetRent);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textPetFee);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textPetBread);
            this.groupBox2.Controls.Add(this.lblFirstName);
            this.groupBox2.Controls.Add(this.dataPets);
            this.groupBox2.Location = new System.Drawing.Point(33, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 240);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pets";
            // 
            // drpPetType
            // 
            this.drpPetType.AccessibleName = "drpOwner";
            this.drpPetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpPetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpPetType.FormattingEnabled = true;
            this.drpPetType.Location = new System.Drawing.Point(83, 37);
            this.drpPetType.Name = "drpPetType";
            this.drpPetType.Size = new System.Drawing.Size(157, 28);
            this.drpPetType.TabIndex = 61;
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(705, 81);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(111, 27);
            this.btnAddPet.TabIndex = 60;
            this.btnAddPet.Text = "Add";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // checkPetFee
            // 
            this.checkPetFee.AutoSize = true;
            this.checkPetFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPetFee.Location = new System.Drawing.Point(362, 81);
            this.checkPetFee.Name = "checkPetFee";
            this.checkPetFee.Size = new System.Drawing.Size(119, 24);
            this.checkPetFee.TabIndex = 59;
            this.checkPetFee.Text = "Pet Fee Paid";
            this.checkPetFee.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(617, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Pet Rent";
            // 
            // textPetRent
            // 
            this.textPetRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPetRent.Location = new System.Drawing.Point(705, 34);
            this.textPetRent.MaxLength = 20;
            this.textPetRent.Name = "textPetRent";
            this.textPetRent.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textPetRent.Size = new System.Drawing.Size(111, 26);
            this.textPetRent.TabIndex = 58;
            this.textPetRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericKeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Pet Fee";
            // 
            // textPetFee
            // 
            this.textPetFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPetFee.Location = new System.Drawing.Point(83, 85);
            this.textPetFee.MaxLength = 20;
            this.textPetFee.Name = "textPetFee";
            this.textPetFee.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textPetFee.Size = new System.Drawing.Size(111, 26);
            this.textPetFee.TabIndex = 56;
            this.textPetFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericKeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Pet Breed";
            // 
            // textPetBread
            // 
            this.textPetBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPetBread.Location = new System.Drawing.Point(362, 34);
            this.textPetBread.MaxLength = 20;
            this.textPetBread.Name = "textPetBread";
            this.textPetBread.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textPetBread.Size = new System.Drawing.Size(131, 26);
            this.textPetBread.TabIndex = 54;
            this.textPetBread.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterKeyPress);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(71, 20);
            this.lblFirstName.TabIndex = 51;
            this.lblFirstName.Text = "Pet Type";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dataPets
            // 
            this.dataPets.AllowUserToAddRows = false;
            this.dataPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataPetType,
            this.dataPetBread,
            this.dataPetFee,
            this.dataPetFeePaid,
            this.dataPetRent,
            this.dataBtnEdit,
            this.dataBtnDelete});
            this.dataPets.Location = new System.Drawing.Point(0, 121);
            this.dataPets.Name = "dataPets";
            this.dataPets.Size = new System.Drawing.Size(855, 115);
            this.dataPets.TabIndex = 47;
            this.dataPets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPets_CellContentClick);
            // 
            // dataPetType
            // 
            this.dataPetType.HeaderText = "PetType";
            this.dataPetType.Name = "dataPetType";
            this.dataPetType.Width = 140;
            // 
            // dataPetBread
            // 
            this.dataPetBread.HeaderText = "Pet Bread";
            this.dataPetBread.Name = "dataPetBread";
            this.dataPetBread.Width = 150;
            // 
            // dataPetFee
            // 
            this.dataPetFee.HeaderText = "Pet Fee";
            this.dataPetFee.Name = "dataPetFee";
            this.dataPetFee.Width = 110;
            // 
            // dataPetFeePaid
            // 
            this.dataPetFeePaid.HeaderText = "Pet Fee Paid";
            this.dataPetFeePaid.Name = "dataPetFeePaid";
            this.dataPetFeePaid.Width = 110;
            // 
            // dataPetRent
            // 
            this.dataPetRent.HeaderText = "Pet Rent";
            this.dataPetRent.Name = "dataPetRent";
            // 
            // dataBtnEdit
            // 
            this.dataBtnEdit.HeaderText = "";
            this.dataBtnEdit.Name = "dataBtnEdit";
            // 
            // dataBtnDelete
            // 
            this.dataBtnDelete.HeaderText = "";
            this.dataBtnDelete.Name = "dataBtnDelete";
            // 
            // FinalizeHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.Roofing);
            this.Name = "FinalizeHouse";
            this.Text = "FinalizeHouse";
            this.Load += new System.EventHandler(this.FinalizeHouse_Load);
            this.Roofing.ResumeLayout(false);
            this.Roofing.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Roofing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePrevKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRoofMaterial;
        private System.Windows.Forms.DateTimePicker dateCurrentKey;
        private System.Windows.Forms.TextBox textPrevKey;
        private System.Windows.Forms.TextBox txtCurrentKey;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textMiscellaneous;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataPets;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.CheckBox checkPetFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPetRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPetFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPetBread;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPetBread;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPetFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPetFeePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPetRent;
        private System.Windows.Forms.DataGridViewButtonColumn dataBtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dataBtnDelete;
        private System.Windows.Forms.ComboBox drpPetType;
    }
}