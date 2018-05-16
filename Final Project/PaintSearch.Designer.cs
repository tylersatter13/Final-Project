namespace Final_Project
{
    partial class PaintSearch 
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
            this.dataHouse = new System.Windows.Forms.DataGridView();
            this.dataIsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFloorPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInterriorColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLastPaint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCarpetColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCarpetInstallDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExterriorPaint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTrimColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSiding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExteriorPaintDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBlindRepalcement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.textHouseNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioExterrior = new System.Windows.Forms.RadioButton();
            this.radioInterrior = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.drpInterriorColor = new System.Windows.Forms.ComboBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.drpExteriorColor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataHouse)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataHouse
            // 
            this.dataHouse.AllowUserToAddRows = false;
            this.dataHouse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataIsSelected,
            this.dataOwner,
            this.dataAddress,
            this.dataFloorPlan,
            this.dataInterriorColor,
            this.dataLastPaint,
            this.dataCarpetColor,
            this.dataCarpetInstallDate,
            this.dataExterriorPaint,
            this.dataTrimColor,
            this.dataSiding,
            this.dataExteriorPaintDate,
            this.dataBlindRepalcement});
            this.dataHouse.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataHouse.Location = new System.Drawing.Point(12, 82);
            this.dataHouse.Name = "dataHouse";
            this.dataHouse.RowTemplate.ReadOnly = true;
            this.dataHouse.Size = new System.Drawing.Size(1141, 489);
            this.dataHouse.TabIndex = 47;
            this.dataHouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHouse_CellClick);
            // 
            // dataIsSelected
            // 
            this.dataIsSelected.HeaderText = "";
            this.dataIsSelected.Name = "dataIsSelected";
            this.dataIsSelected.Width = 50;
            // 
            // dataOwner
            // 
            this.dataOwner.HeaderText = "Owner";
            this.dataOwner.Name = "dataOwner";
            this.dataOwner.Width = 50;
            // 
            // dataAddress
            // 
            this.dataAddress.HeaderText = "Address";
            this.dataAddress.Name = "dataAddress";
            this.dataAddress.Width = 120;
            // 
            // dataFloorPlan
            // 
            this.dataFloorPlan.HeaderText = "Floor Plan";
            this.dataFloorPlan.Name = "dataFloorPlan";
            this.dataFloorPlan.Width = 75;
            // 
            // dataInterriorColor
            // 
            this.dataInterriorColor.HeaderText = "Interrior Color";
            this.dataInterriorColor.Name = "dataInterriorColor";
            // 
            // dataLastPaint
            // 
            this.dataLastPaint.HeaderText = "Last Painted";
            this.dataLastPaint.Name = "dataLastPaint";
            this.dataLastPaint.Width = 75;
            // 
            // dataCarpetColor
            // 
            this.dataCarpetColor.HeaderText = "Carpet Color";
            this.dataCarpetColor.Name = "dataCarpetColor";
            // 
            // dataCarpetInstallDate
            // 
            this.dataCarpetInstallDate.HeaderText = "Carpet Installed";
            this.dataCarpetInstallDate.Name = "dataCarpetInstallDate";
            this.dataCarpetInstallDate.Width = 75;
            // 
            // dataExterriorPaint
            // 
            this.dataExterriorPaint.HeaderText = "Exterrior Color";
            this.dataExterriorPaint.Name = "dataExterriorPaint";
            // 
            // dataTrimColor
            // 
            this.dataTrimColor.HeaderText = "Trim Color";
            this.dataTrimColor.Name = "dataTrimColor";
            // 
            // dataSiding
            // 
            this.dataSiding.HeaderText = "Siding";
            this.dataSiding.Name = "dataSiding";
            // 
            // dataExteriorPaintDate
            // 
            this.dataExteriorPaintDate.HeaderText = "Last Painted";
            this.dataExteriorPaintDate.Name = "dataExteriorPaintDate";
            this.dataExteriorPaintDate.Width = 75;
            // 
            // dataBlindRepalcement
            // 
            this.dataBlindRepalcement.HeaderText = "Blind Replacement";
            this.dataBlindRepalcement.Name = "dataBlindRepalcement";
            this.dataBlindRepalcement.Width = 75;
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNumber.Location = new System.Drawing.Point(16, 21);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(116, 20);
            this.lblHouseNumber.TabIndex = 49;
            this.lblHouseNumber.Text = "House Number";
            // 
            // textHouseNumber
            // 
            this.textHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHouseNumber.Location = new System.Drawing.Point(138, 18);
            this.textHouseNumber.MaxLength = 4;
            this.textHouseNumber.Name = "textHouseNumber";
            this.textHouseNumber.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textHouseNumber.Size = new System.Drawing.Size(105, 26);
            this.textHouseNumber.TabIndex = 48;
            this.textHouseNumber.Text = "4588";
            this.textHouseNumber.TextChanged += new System.EventHandler(this.textHouseNumber_TextChanged);
            this.textHouseNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHouseNumber_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1014, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 30);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.drpInterriorColor);
            this.groupBox1.Controls.Add(this.lblOwner);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.drpExteriorColor);
            this.groupBox1.Controls.Add(this.textHouseNumber);
            this.groupBox1.Controls.Add(this.lblHouseNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1141, 64);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioExterrior);
            this.panel1.Controls.Add(this.radioInterrior);
            this.panel1.Location = new System.Drawing.Point(896, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 46);
            this.panel1.TabIndex = 52;
            // 
            // radioExterrior
            // 
            this.radioExterrior.AutoSize = true;
            this.radioExterrior.Location = new System.Drawing.Point(11, 26);
            this.radioExterrior.Name = "radioExterrior";
            this.radioExterrior.Size = new System.Drawing.Size(90, 17);
            this.radioExterrior.TabIndex = 55;
            this.radioExterrior.Text = "Exterrior Color";
            this.radioExterrior.UseVisualStyleBackColor = true;
            // 
            // radioInterrior
            // 
            this.radioInterrior.AutoSize = true;
            this.radioInterrior.Checked = true;
            this.radioInterrior.Location = new System.Drawing.Point(11, 7);
            this.radioInterrior.Name = "radioInterrior";
            this.radioInterrior.Size = new System.Drawing.Size(87, 17);
            this.radioInterrior.TabIndex = 54;
            this.radioInterrior.TabStop = true;
            this.radioInterrior.Text = "Interrior Color";
            this.radioInterrior.UseVisualStyleBackColor = true;
            this.radioInterrior.CheckedChanged += new System.EventHandler(this.radioInterrior_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Interrior Color";
            // 
            // drpInterriorColor
            // 
            this.drpInterriorColor.AccessibleName = "drpOwner";
            this.drpInterriorColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpInterriorColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpInterriorColor.FormattingEnabled = true;
            this.drpInterriorColor.Location = new System.Drawing.Point(438, 21);
            this.drpInterriorColor.Name = "drpInterriorColor";
            this.drpInterriorColor.Size = new System.Drawing.Size(157, 28);
            this.drpInterriorColor.TabIndex = 52;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(601, 26);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(109, 20);
            this.lblOwner.TabIndex = 51;
            this.lblOwner.Text = "Exterrior Color";
            // 
            // drpExteriorColor
            // 
            this.drpExteriorColor.AccessibleName = "drpOwner";
            this.drpExteriorColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpExteriorColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpExteriorColor.FormattingEnabled = true;
            this.drpExteriorColor.Location = new System.Drawing.Point(726, 21);
            this.drpExteriorColor.Name = "drpExteriorColor";
            this.drpExteriorColor.Size = new System.Drawing.Size(157, 28);
            this.drpExteriorColor.TabIndex = 50;
            // 
            // PaintSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataHouse);
            this.Name = "PaintSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaintSearch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaintSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHouse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHouse;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.TextBox textHouseNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox drpExteriorColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpInterriorColor;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataIsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFloorPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInterriorColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLastPaint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCarpetColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCarpetInstallDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExterriorPaint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTrimColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSiding;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExteriorPaintDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBlindRepalcement;
        private System.Windows.Forms.RadioButton radioInterrior;
        private System.Windows.Forms.RadioButton radioExterrior;
        private System.Windows.Forms.Panel panel1;
    }
}