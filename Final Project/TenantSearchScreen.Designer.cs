namespace Final_Project
{
    partial class TenantSearchScreen
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
            this.dataTenant = new System.Windows.Forms.DataGridView();
            this.dataIsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFloorPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInterriorColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLastPaint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchLatePayments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTenant)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTenant
            // 
            this.dataTenant.AllowUserToAddRows = false;
            this.dataTenant.AllowUserToDeleteRows = false;
            this.dataTenant.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTenant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataIsSelected,
            this.dataOwner,
            this.dataAddress,
            this.dataTenantName,
            this.dataFloorPlan,
            this.dataInterriorColor,
            this.dataRent,
            this.dataLastPaint,
            this.dataBalance,
            this.dataPeople,
            this.dataPets});
            this.dataTenant.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataTenant.Location = new System.Drawing.Point(12, 68);
            this.dataTenant.Name = "dataTenant";
            this.dataTenant.ReadOnly = true;
            this.dataTenant.RowTemplate.ReadOnly = true;
            this.dataTenant.Size = new System.Drawing.Size(1141, 454);
            this.dataTenant.TabIndex = 49;
            this.dataTenant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTenant_CellContentClick);
            this.dataTenant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTenant_CellContentClick_1);
            // 
            // dataIsSelected
            // 
            this.dataIsSelected.HeaderText = "";
            this.dataIsSelected.Name = "dataIsSelected";
            this.dataIsSelected.ReadOnly = true;
            this.dataIsSelected.Width = 50;
            // 
            // dataOwner
            // 
            this.dataOwner.HeaderText = "Owner";
            this.dataOwner.Name = "dataOwner";
            this.dataOwner.ReadOnly = true;
            // 
            // dataAddress
            // 
            this.dataAddress.HeaderText = "Address";
            this.dataAddress.Name = "dataAddress";
            this.dataAddress.ReadOnly = true;
            this.dataAddress.Width = 150;
            // 
            // dataTenantName
            // 
            this.dataTenantName.HeaderText = "Tennat Name";
            this.dataTenantName.Name = "dataTenantName";
            this.dataTenantName.ReadOnly = true;
            this.dataTenantName.Width = 150;
            // 
            // dataFloorPlan
            // 
            this.dataFloorPlan.HeaderText = "Floor Plan";
            this.dataFloorPlan.Name = "dataFloorPlan";
            this.dataFloorPlan.ReadOnly = true;
            // 
            // dataInterriorColor
            // 
            this.dataInterriorColor.HeaderText = "Phone";
            this.dataInterriorColor.Name = "dataInterriorColor";
            this.dataInterriorColor.ReadOnly = true;
            // 
            // dataRent
            // 
            this.dataRent.HeaderText = "Monthly Rent";
            this.dataRent.Name = "dataRent";
            this.dataRent.ReadOnly = true;
            // 
            // dataLastPaint
            // 
            this.dataLastPaint.HeaderText = "Date Started";
            this.dataLastPaint.Name = "dataLastPaint";
            this.dataLastPaint.ReadOnly = true;
            this.dataLastPaint.Width = 75;
            // 
            // dataBalance
            // 
            this.dataBalance.HeaderText = "Balance";
            this.dataBalance.Name = "dataBalance";
            this.dataBalance.ReadOnly = true;
            // 
            // dataPeople
            // 
            this.dataPeople.HeaderText = "People";
            this.dataPeople.Name = "dataPeople";
            this.dataPeople.ReadOnly = true;
            this.dataPeople.Width = 50;
            // 
            // dataPets
            // 
            this.dataPets.HeaderText = "Pets";
            this.dataPets.Name = "dataPets";
            this.dataPets.ReadOnly = true;
            this.dataPets.Width = 50;
            // 
            // textLastName
            // 
            this.textLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastName.Location = new System.Drawing.Point(105, 13);
            this.textLastName.MaxLength = 30;
            this.textLastName.Name = "textLastName";
            this.textLastName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textLastName.Size = new System.Drawing.Size(105, 26);
            this.textLastName.TabIndex = 50;
            this.textLastName.Text = "Arnold";
            this.textLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterKeyPress);
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(13, 10);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 33);
            this.lblLastName.TabIndex = 51;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblLastName);
            this.flowLayoutPanel1.Controls.Add(this.textLastName);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(383, 50);
            this.flowLayoutPanel1.TabIndex = 52;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(216, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 27);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchLatePayments
            // 
            this.btnSearchLatePayments.Location = new System.Drawing.Point(979, 12);
            this.btnSearchLatePayments.Name = "btnSearchLatePayments";
            this.btnSearchLatePayments.Size = new System.Drawing.Size(174, 40);
            this.btnSearchLatePayments.TabIndex = 62;
            this.btnSearchLatePayments.Text = "Late Payment Search";
            this.btnSearchLatePayments.UseVisualStyleBackColor = true;
            this.btnSearchLatePayments.Click += new System.EventHandler(this.btnSearchLatePayments_Click);
            // 
            // TenantSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1177, 567);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataTenant);
            this.Controls.Add(this.btnSearchLatePayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TenantSearchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TenantSearchScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TenantSearchScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTenant)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTenant;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchLatePayments;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataIsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFloorPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInterriorColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLastPaint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPets;
    }
}