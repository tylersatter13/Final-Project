namespace Final_Project
{
    partial class Menu
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
            this.btnHouse = new System.Windows.Forms.Button();
            this.btnTenants = new System.Windows.Forms.Button();
            this.btnMaintenace = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateHouse = new System.Windows.Forms.ToolStripMenuItem();
            this.createHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewHouse = new System.Windows.Forms.ToolStripMenuItem();
            this.tenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btntenantSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenaceRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchMaintenace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHouse
            // 
            this.btnHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHouse.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnHouse.Location = new System.Drawing.Point(448, 82);
            this.btnHouse.Name = "btnHouse";
            this.btnHouse.Size = new System.Drawing.Size(269, 93);
            this.btnHouse.TabIndex = 0;
            this.btnHouse.Text = "Manage Houses";
            this.btnHouse.UseVisualStyleBackColor = false;
            this.btnHouse.Visible = false;
            this.btnHouse.Click += new System.EventHandler(this.btnHouse_Click);
            // 
            // btnTenants
            // 
            this.btnTenants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnTenants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTenants.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnTenants.Location = new System.Drawing.Point(448, 226);
            this.btnTenants.Name = "btnTenants";
            this.btnTenants.Size = new System.Drawing.Size(269, 93);
            this.btnTenants.TabIndex = 1;
            this.btnTenants.Text = "Manage Tenants";
            this.btnTenants.UseVisualStyleBackColor = false;
            this.btnTenants.Visible = false;
            this.btnTenants.Click += new System.EventHandler(this.btnTenants_Click);
            // 
            // btnMaintenace
            // 
            this.btnMaintenace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnMaintenace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenace.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.btnMaintenace.Location = new System.Drawing.Point(448, 358);
            this.btnMaintenace.Name = "btnMaintenace";
            this.btnMaintenace.Size = new System.Drawing.Size(269, 93);
            this.btnMaintenace.TabIndex = 2;
            this.btnMaintenace.Text = "Manage Maintenace ";
            this.btnMaintenace.UseVisualStyleBackColor = false;
            this.btnMaintenace.Visible = false;
            this.btnMaintenace.Click += new System.EventHandler(this.btnMaintenace_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(63)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.btnCreateHouse,
            this.tenantToolStripMenuItem,
            this.maintenaceRequestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(102, 36);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnCreateHouse
            // 
            this.btnCreateHouse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createHouseToolStripMenuItem,
            this.btnViewHouse});
            this.btnCreateHouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateHouse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateHouse.Name = "btnCreateHouse";
            this.btnCreateHouse.Size = new System.Drawing.Size(66, 36);
            this.btnCreateHouse.Text = "House";
            // 
            // createHouseToolStripMenuItem
            // 
            this.createHouseToolStripMenuItem.Name = "createHouseToolStripMenuItem";
            this.createHouseToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.createHouseToolStripMenuItem.Text = "Create House";
            this.createHouseToolStripMenuItem.Click += new System.EventHandler(this.createHouseToolStripMenuItem_Click);
            // 
            // btnViewHouse
            // 
            this.btnViewHouse.Name = "btnViewHouse";
            this.btnViewHouse.Size = new System.Drawing.Size(205, 26);
            this.btnViewHouse.Text = "View/ Edit Houses";
            this.btnViewHouse.Click += new System.EventHandler(this.houseSearchToolStripMenuItem_Click);
            // 
            // tenantToolStripMenuItem
            // 
            this.tenantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btntenantSearch});
            this.tenantToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenantToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tenantToolStripMenuItem.Name = "tenantToolStripMenuItem";
            this.tenantToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.tenantToolStripMenuItem.Text = "Tenant";
            // 
            // btntenantSearch
            // 
            this.btntenantSearch.Name = "btntenantSearch";
            this.btntenantSearch.Size = new System.Drawing.Size(180, 26);
            this.btntenantSearch.Text = "Tenant Search";
            this.btntenantSearch.Click += new System.EventHandler(this.btntenantSearch_Click);
            // 
            // maintenaceRequestToolStripMenuItem
            // 
            this.maintenaceRequestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateRequest,
            this.btnSearchMaintenace});
            this.maintenaceRequestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenaceRequestToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maintenaceRequestToolStripMenuItem.Name = "maintenaceRequestToolStripMenuItem";
            this.maintenaceRequestToolStripMenuItem.Size = new System.Drawing.Size(162, 36);
            this.maintenaceRequestToolStripMenuItem.Text = "Maintenace Request";
            // 
            // btnCreateRequest
            // 
            this.btnCreateRequest.Name = "btnCreateRequest";
            this.btnCreateRequest.Size = new System.Drawing.Size(213, 26);
            this.btnCreateRequest.Text = "Create Request";
            this.btnCreateRequest.Click += new System.EventHandler(this.btnCreateRequest_Click);
            // 
            // btnSearchMaintenace
            // 
            this.btnSearchMaintenace.Name = "btnSearchMaintenace";
            this.btnSearchMaintenace.Size = new System.Drawing.Size(213, 26);
            this.btnSearchMaintenace.Text = "View/Edit Requests";
            this.btnSearchMaintenace.Click += new System.EventHandler(this.btnSearchMaintenace_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1165, 606);
            this.Controls.Add(this.btnMaintenace);
            this.Controls.Add(this.btnTenants);
            this.Controls.Add(this.btnHouse);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHouse;
        private System.Windows.Forms.Button btnTenants;
        private System.Windows.Forms.Button btnMaintenace;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCreateHouse;
        private System.Windows.Forms.ToolStripMenuItem createHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnViewHouse;
        private System.Windows.Forms.ToolStripMenuItem tenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btntenantSearch;
        private System.Windows.Forms.ToolStripMenuItem maintenaceRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCreateRequest;
        private System.Windows.Forms.ToolStripMenuItem btnSearchMaintenace;
    }
}