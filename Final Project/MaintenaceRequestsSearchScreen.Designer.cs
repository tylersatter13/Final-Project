namespace Final_Project
{
    partial class MaintenaceRequestsSearchScreen
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
            this.dataAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFloorPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInterriorColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRequestType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLastPaint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCarpetColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCarpetInstallDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTechnicianName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOwner = new System.Windows.Forms.Label();
            this.drpRequestType = new System.Windows.Forms.ComboBox();
            this.textHouseNumber = new System.Windows.Forms.TextBox();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkOpenRequests = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioRequestType = new System.Windows.Forms.RadioButton();
            this.radioLastName = new System.Windows.Forms.RadioButton();
            this.radioHouse = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataHouse)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataHouse
            // 
            this.dataHouse.AllowUserToAddRows = false;
            this.dataHouse.AllowUserToDeleteRows = false;
            this.dataHouse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataIsSelected,
            this.dataAddress,
            this.dataFloorPlan,
            this.dataInterriorColor,
            this.dataRequestType,
            this.dataDateCreated,
            this.dataLastPaint,
            this.dataCarpetColor,
            this.dataCarpetInstallDate,
            this.dataTechnicianName});
            this.dataHouse.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataHouse.Location = new System.Drawing.Point(12, 111);
            this.dataHouse.Name = "dataHouse";
            this.dataHouse.ReadOnly = true;
            this.dataHouse.RowTemplate.ReadOnly = true;
            this.dataHouse.Size = new System.Drawing.Size(1141, 464);
            this.dataHouse.TabIndex = 48;
            this.dataHouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHouse_CellContentClick);
            // 
            // dataIsSelected
            // 
            this.dataIsSelected.HeaderText = "";
            this.dataIsSelected.Name = "dataIsSelected";
            this.dataIsSelected.ReadOnly = true;
            this.dataIsSelected.Width = 50;
            // 
            // dataAddress
            // 
            this.dataAddress.HeaderText = "Address";
            this.dataAddress.Name = "dataAddress";
            this.dataAddress.ReadOnly = true;
            this.dataAddress.Width = 120;
            // 
            // dataFloorPlan
            // 
            this.dataFloorPlan.HeaderText = "Tennat Name";
            this.dataFloorPlan.Name = "dataFloorPlan";
            this.dataFloorPlan.ReadOnly = true;
            // 
            // dataInterriorColor
            // 
            this.dataInterriorColor.HeaderText = "Phone";
            this.dataInterriorColor.Name = "dataInterriorColor";
            this.dataInterriorColor.ReadOnly = true;
            // 
            // dataRequestType
            // 
            this.dataRequestType.HeaderText = "Request Type";
            this.dataRequestType.Name = "dataRequestType";
            this.dataRequestType.ReadOnly = true;
            // 
            // dataDateCreated
            // 
            this.dataDateCreated.HeaderText = "Date Created";
            this.dataDateCreated.Name = "dataDateCreated";
            this.dataDateCreated.ReadOnly = true;
            // 
            // dataLastPaint
            // 
            this.dataLastPaint.HeaderText = "Date Started";
            this.dataLastPaint.Name = "dataLastPaint";
            this.dataLastPaint.ReadOnly = true;
            this.dataLastPaint.Width = 75;
            // 
            // dataCarpetColor
            // 
            this.dataCarpetColor.HeaderText = "Date Completed";
            this.dataCarpetColor.Name = "dataCarpetColor";
            this.dataCarpetColor.ReadOnly = true;
            // 
            // dataCarpetInstallDate
            // 
            this.dataCarpetInstallDate.HeaderText = "Description";
            this.dataCarpetInstallDate.Name = "dataCarpetInstallDate";
            this.dataCarpetInstallDate.ReadOnly = true;
            this.dataCarpetInstallDate.Width = 250;
            // 
            // dataTechnicianName
            // 
            this.dataTechnicianName.HeaderText = "Technician";
            this.dataTechnicianName.Name = "dataTechnicianName";
            this.dataTechnicianName.ReadOnly = true;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(588, 9);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(108, 20);
            this.lblOwner.TabIndex = 53;
            this.lblOwner.Text = "Request Type";
            // 
            // drpRequestType
            // 
            this.drpRequestType.AccessibleName = "drpOwner";
            this.drpRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpRequestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpRequestType.FormattingEnabled = true;
            this.drpRequestType.Location = new System.Drawing.Point(702, 6);
            this.drpRequestType.Name = "drpRequestType";
            this.drpRequestType.Size = new System.Drawing.Size(137, 28);
            this.drpRequestType.TabIndex = 52;
            // 
            // textHouseNumber
            // 
            this.textHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHouseNumber.Location = new System.Drawing.Point(160, 6);
            this.textHouseNumber.MaxLength = 4;
            this.textHouseNumber.Name = "textHouseNumber";
            this.textHouseNumber.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textHouseNumber.Size = new System.Drawing.Size(105, 26);
            this.textHouseNumber.TabIndex = 54;
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNumber.Location = new System.Drawing.Point(38, 9);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(116, 20);
            this.lblHouseNumber.TabIndex = 55;
            this.lblHouseNumber.Text = "House Number";
            // 
            // textLastName
            // 
            this.textLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastName.Location = new System.Drawing.Point(396, 6);
            this.textLastName.MaxLength = 30;
            this.textLastName.Name = "textLastName";
            this.textLastName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textLastName.Size = new System.Drawing.Size(157, 26);
            this.textLastName.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Last Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1034, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 32);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checkOpenRequests
            // 
            this.checkOpenRequests.AutoSize = true;
            this.checkOpenRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOpenRequests.Location = new System.Drawing.Point(873, 59);
            this.checkOpenRequests.Name = "checkOpenRequests";
            this.checkOpenRequests.Size = new System.Drawing.Size(140, 24);
            this.checkOpenRequests.TabIndex = 64;
            this.checkOpenRequests.Text = "Open Requests";
            this.checkOpenRequests.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioRequestType);
            this.panel1.Controls.Add(this.radioLastName);
            this.panel1.Controls.Add(this.radioHouse);
            this.panel1.Controls.Add(this.lblHouseNumber);
            this.panel1.Controls.Add(this.textHouseNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.drpRequestType);
            this.panel1.Controls.Add(this.lblOwner);
            this.panel1.Controls.Add(this.textLastName);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 42);
            this.panel1.TabIndex = 65;
            // 
            // radioRequestType
            // 
            this.radioRequestType.AutoSize = true;
            this.radioRequestType.Location = new System.Drawing.Point(568, 14);
            this.radioRequestType.Name = "radioRequestType";
            this.radioRequestType.Size = new System.Drawing.Size(14, 13);
            this.radioRequestType.TabIndex = 60;
            this.radioRequestType.TabStop = true;
            this.radioRequestType.UseVisualStyleBackColor = true;
            // 
            // radioLastName
            // 
            this.radioLastName.AutoSize = true;
            this.radioLastName.Location = new System.Drawing.Point(284, 14);
            this.radioLastName.Name = "radioLastName";
            this.radioLastName.Size = new System.Drawing.Size(14, 13);
            this.radioLastName.TabIndex = 59;
            this.radioLastName.TabStop = true;
            this.radioLastName.UseVisualStyleBackColor = true;
            // 
            // radioHouse
            // 
            this.radioHouse.AutoSize = true;
            this.radioHouse.Checked = true;
            this.radioHouse.Location = new System.Drawing.Point(18, 14);
            this.radioHouse.Name = "radioHouse";
            this.radioHouse.Size = new System.Drawing.Size(14, 13);
            this.radioHouse.TabIndex = 58;
            this.radioHouse.TabStop = true;
            this.radioHouse.UseVisualStyleBackColor = true;
            this.radioHouse.CheckedChanged += new System.EventHandler(this.radioHouse_CheckedChanged);
            // 
            // MaintenaceRequestsSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkOpenRequests);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataHouse);
            this.Name = "MaintenaceRequestsSearchScreen";
            this.Text = "MaintenaceRequestsSearchScreen";
            this.Load += new System.EventHandler(this.MaintenaceRequestsSearchScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHouse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHouse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataIsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFloorPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInterriorColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRequestType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLastPaint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCarpetColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCarpetInstallDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTechnicianName;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.ComboBox drpRequestType;
        private System.Windows.Forms.TextBox textHouseNumber;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox checkOpenRequests;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioRequestType;
        private System.Windows.Forms.RadioButton radioLastName;
        private System.Windows.Forms.RadioButton radioHouse;
    }
}