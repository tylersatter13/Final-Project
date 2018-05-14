namespace Final_Project
{
    partial class CreateMaintenaceRequestScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textTennantPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drpRequestType = new System.Windows.Forms.ComboBox();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.drpStreetName = new System.Windows.Forms.ComboBox();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.textHouseNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateJobStarted = new System.Windows.Forms.DateTimePicker();
            this.lblreated = new System.Windows.Forms.Label();
            this.dateJobCreated = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textTenantLast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTenantFirstName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkAppliance = new System.Windows.Forms.CheckBox();
            this.checkPermissionToEnter = new System.Windows.Forms.CheckBox();
            this.lblDogs = new System.Windows.Forms.Label();
            this.lblCats = new System.Windows.Forms.Label();
            this.numericUpDogs = new System.Windows.Forms.NumericUpDown();
            this.numCats = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.radioDishwasher = new System.Windows.Forms.RadioButton();
            this.radioRange = new System.Windows.Forms.RadioButton();
            this.textJobDescsription = new System.Windows.Forms.TextBox();
            this.lblJobDescription = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.textWorkPreformed = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.drpTechnicians = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numJobHours = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.dateJobCompleted = new System.Windows.Forms.DateTimePicker();
            this.lblJobStart = new System.Windows.Forms.Label();
            this.dateJobStart = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioCharge = new System.Windows.Forms.RadioButton();
            this.radioStock = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textPartCost = new System.Windows.Forms.TextBox();
            this.Part = new System.Windows.Forms.Label();
            this.textPartName = new System.Windows.Forms.TextBox();
            this.dataRepairParts = new System.Windows.Forms.DataGridView();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEditbtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.data = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCats)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJobHours)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepairParts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textTennantPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.drpRequestType);
            this.panel1.Controls.Add(this.lblStreetName);
            this.panel1.Controls.Add(this.drpStreetName);
            this.panel1.Controls.Add(this.lblHouseNumber);
            this.panel1.Controls.Add(this.textHouseNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateJobStarted);
            this.panel1.Controls.Add(this.lblreated);
            this.panel1.Controls.Add(this.dateJobCreated);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textTenantLast);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textTenantFirstName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 193);
            this.panel1.TabIndex = 0;
            // 
            // textTennantPhone
            // 
            this.textTennantPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTennantPhone.Location = new System.Drawing.Point(128, 149);
            this.textTennantPhone.Mask = "999-000-0000";
            this.textTennantPhone.Name = "textTennantPhone";
            this.textTennantPhone.Size = new System.Drawing.Size(115, 26);
            this.textTennantPhone.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Type";
            // 
            // drpRequestType
            // 
            this.drpRequestType.AccessibleName = "drpStreetName";
            this.drpRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpRequestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpRequestType.FormattingEnabled = true;
            this.drpRequestType.Location = new System.Drawing.Point(351, 147);
            this.drpRequestType.Name = "drpRequestType";
            this.drpRequestType.Size = new System.Drawing.Size(158, 28);
            this.drpRequestType.TabIndex = 72;
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(249, 104);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(93, 20);
            this.lblStreetName.TabIndex = 71;
            this.lblStreetName.Text = "Streetname";
            // 
            // drpStreetName
            // 
            this.drpStreetName.AccessibleName = "drpStreetName";
            this.drpStreetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpStreetName.FormattingEnabled = true;
            this.drpStreetName.Location = new System.Drawing.Point(351, 101);
            this.drpStreetName.Name = "drpStreetName";
            this.drpStreetName.Size = new System.Drawing.Size(158, 28);
            this.drpStreetName.TabIndex = 70;
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNumber.Location = new System.Drawing.Point(12, 104);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(116, 20);
            this.lblHouseNumber.TabIndex = 69;
            this.lblHouseNumber.Text = "House Number";
            // 
            // textHouseNumber
            // 
            this.textHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHouseNumber.Location = new System.Drawing.Point(136, 101);
            this.textHouseNumber.MaxLength = 4;
            this.textHouseNumber.Name = "textHouseNumber";
            this.textHouseNumber.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textHouseNumber.Size = new System.Drawing.Size(105, 26);
            this.textHouseNumber.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Started";
            // 
            // dateJobStarted
            // 
            this.dateJobStarted.AccessibleName = "dateLastPaint";
            this.dateJobStarted.Checked = false;
            this.dateJobStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateJobStarted.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJobStarted.Location = new System.Drawing.Point(356, 57);
            this.dateJobStarted.Name = "dateJobStarted";
            this.dateJobStarted.ShowCheckBox = true;
            this.dateJobStarted.Size = new System.Drawing.Size(153, 26);
            this.dateJobStarted.TabIndex = 66;
            // 
            // lblreated
            // 
            this.lblreated.AutoSize = true;
            this.lblreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreated.Location = new System.Drawing.Point(12, 62);
            this.lblreated.Name = "lblreated";
            this.lblreated.Size = new System.Drawing.Size(66, 20);
            this.lblreated.TabIndex = 65;
            this.lblreated.Text = "Created";
            // 
            // dateJobCreated
            // 
            this.dateJobCreated.AccessibleName = "dateLastPaint";
            this.dateJobCreated.Checked = false;
            this.dateJobCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateJobCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJobCreated.Location = new System.Drawing.Point(104, 60);
            this.dateJobCreated.Name = "dateJobCreated";
            this.dateJobCreated.ShowCheckBox = true;
            this.dateJobCreated.Size = new System.Drawing.Size(139, 26);
            this.dateJobCreated.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Last Name";
            // 
            // textTenantLast
            // 
            this.textTenantLast.Enabled = false;
            this.textTenantLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenantLast.Location = new System.Drawing.Point(356, 17);
            this.textTenantLast.MaxLength = 20;
            this.textTenantLast.Name = "textTenantLast";
            this.textTenantLast.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textTenantLast.Size = new System.Drawing.Size(153, 26);
            this.textTenantLast.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "First Name";
            // 
            // textTenantFirstName
            // 
            this.textTenantFirstName.Enabled = false;
            this.textTenantFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenantFirstName.Location = new System.Drawing.Point(104, 17);
            this.textTenantFirstName.MaxLength = 20;
            this.textTenantFirstName.Name = "textTenantFirstName";
            this.textTenantFirstName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textTenantFirstName.Size = new System.Drawing.Size(139, 26);
            this.textTenantFirstName.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkAppliance);
            this.panel2.Controls.Add(this.checkPermissionToEnter);
            this.panel2.Controls.Add(this.lblDogs);
            this.panel2.Controls.Add(this.lblCats);
            this.panel2.Controls.Add(this.numericUpDogs);
            this.panel2.Controls.Add(this.numCats);
            this.panel2.Location = new System.Drawing.Point(546, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 96);
            this.panel2.TabIndex = 1;
            // 
            // checkAppliance
            // 
            this.checkAppliance.AutoSize = true;
            this.checkAppliance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAppliance.Location = new System.Drawing.Point(451, 61);
            this.checkAppliance.Name = "checkAppliance";
            this.checkAppliance.Size = new System.Drawing.Size(113, 24);
            this.checkAppliance.TabIndex = 64;
            this.checkAppliance.Text = "Is appliance";
            this.checkAppliance.UseVisualStyleBackColor = true;
            this.checkAppliance.CheckedChanged += new System.EventHandler(this.checkAppliance_CheckedChanged);
            // 
            // checkPermissionToEnter
            // 
            this.checkPermissionToEnter.AutoSize = true;
            this.checkPermissionToEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPermissionToEnter.Location = new System.Drawing.Point(22, 57);
            this.checkPermissionToEnter.Name = "checkPermissionToEnter";
            this.checkPermissionToEnter.Size = new System.Drawing.Size(166, 24);
            this.checkPermissionToEnter.TabIndex = 63;
            this.checkPermissionToEnter.Text = "Permission to Enter";
            this.checkPermissionToEnter.UseVisualStyleBackColor = true;
            // 
            // lblDogs
            // 
            this.lblDogs.AutoSize = true;
            this.lblDogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogs.Location = new System.Drawing.Point(398, 19);
            this.lblDogs.Name = "lblDogs";
            this.lblDogs.Size = new System.Drawing.Size(47, 20);
            this.lblDogs.TabIndex = 62;
            this.lblDogs.Text = "Dogs";
            // 
            // lblCats
            // 
            this.lblCats.AutoSize = true;
            this.lblCats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCats.Location = new System.Drawing.Point(18, 20);
            this.lblCats.Name = "lblCats";
            this.lblCats.Size = new System.Drawing.Size(42, 20);
            this.lblCats.TabIndex = 61;
            this.lblCats.Text = "Cats";
            // 
            // numericUpDogs
            // 
            this.numericUpDogs.Enabled = false;
            this.numericUpDogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDogs.Location = new System.Drawing.Point(451, 17);
            this.numericUpDogs.Name = "numericUpDogs";
            this.numericUpDogs.Size = new System.Drawing.Size(120, 26);
            this.numericUpDogs.TabIndex = 60;
            // 
            // numCats
            // 
            this.numCats.Enabled = false;
            this.numCats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCats.Location = new System.Drawing.Point(66, 17);
            this.numCats.Name = "numCats";
            this.numCats.Size = new System.Drawing.Size(120, 26);
            this.numCats.TabIndex = 59;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.textJobDescsription);
            this.panel3.Controls.Add(this.lblJobDescription);
            this.panel3.Location = new System.Drawing.Point(546, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 197);
            this.panel3.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.radioDishwasher);
            this.panel8.Controls.Add(this.radioRange);
            this.panel8.Location = new System.Drawing.Point(122, 32);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(353, 33);
            this.panel8.TabIndex = 40;
            // 
            // radioDishwasher
            // 
            this.radioDishwasher.AutoSize = true;
            this.radioDishwasher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDishwasher.Location = new System.Drawing.Point(231, 3);
            this.radioDishwasher.Name = "radioDishwasher";
            this.radioDishwasher.Size = new System.Drawing.Size(110, 24);
            this.radioDishwasher.TabIndex = 40;
            this.radioDishwasher.TabStop = true;
            this.radioDishwasher.Text = "Dishwasher";
            this.radioDishwasher.UseVisualStyleBackColor = true;
            // 
            // radioRange
            // 
            this.radioRange.AutoSize = true;
            this.radioRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRange.Location = new System.Drawing.Point(8, 3);
            this.radioRange.Name = "radioRange";
            this.radioRange.Size = new System.Drawing.Size(75, 24);
            this.radioRange.TabIndex = 39;
            this.radioRange.TabStop = true;
            this.radioRange.Text = "Range";
            this.radioRange.UseVisualStyleBackColor = true;
            // 
            // textJobDescsription
            // 
            this.textJobDescsription.Location = new System.Drawing.Point(3, 73);
            this.textJobDescsription.MaxLength = 255;
            this.textJobDescsription.Multiline = true;
            this.textJobDescsription.Name = "textJobDescsription";
            this.textJobDescsription.Size = new System.Drawing.Size(599, 118);
            this.textJobDescsription.TabIndex = 37;
            // 
            // lblJobDescription
            // 
            this.lblJobDescription.AutoSize = true;
            this.lblJobDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDescription.Location = new System.Drawing.Point(230, 4);
            this.lblJobDescription.Name = "lblJobDescription";
            this.lblJobDescription.Size = new System.Drawing.Size(119, 20);
            this.lblJobDescription.TabIndex = 38;
            this.lblJobDescription.Text = "Job Description";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.textWorkPreformed);
            this.panel4.Location = new System.Drawing.Point(546, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(607, 132);
            this.panel4.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(242, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "Work Preformed";
            // 
            // textWorkPreformed
            // 
            this.textWorkPreformed.Location = new System.Drawing.Point(3, 37);
            this.textWorkPreformed.MaxLength = 255;
            this.textWorkPreformed.Multiline = true;
            this.textWorkPreformed.Name = "textWorkPreformed";
            this.textWorkPreformed.Size = new System.Drawing.Size(599, 90);
            this.textWorkPreformed.TabIndex = 38;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.drpTechnicians);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.numJobHours);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.dateJobCompleted);
            this.panel5.Controls.Add(this.lblJobStart);
            this.panel5.Controls.Add(this.dateJobStart);
            this.panel5.Location = new System.Drawing.Point(12, 468);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1141, 57);
            this.panel5.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(837, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 20);
            this.label17.TabIndex = 75;
            this.label17.Text = "Technician";
            // 
            // drpTechnicians
            // 
            this.drpTechnicians.AccessibleName = "drpStreetName";
            this.drpTechnicians.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpTechnicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpTechnicians.FormattingEnabled = true;
            this.drpTechnicians.Location = new System.Drawing.Point(940, 11);
            this.drpTechnicians.Name = "drpTechnicians";
            this.drpTechnicians.Size = new System.Drawing.Size(158, 28);
            this.drpTechnicians.TabIndex = 74;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(604, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 20);
            this.label16.TabIndex = 73;
            this.label16.Text = "Hours Worked";
            // 
            // numJobHours
            // 
            this.numJobHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numJobHours.Location = new System.Drawing.Point(732, 13);
            this.numJobHours.Name = "numJobHours";
            this.numJobHours.Size = new System.Drawing.Size(75, 26);
            this.numJobHours.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(296, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 20);
            this.label14.TabIndex = 71;
            this.label14.Text = "Job Completed";
            // 
            // dateJobCompleted
            // 
            this.dateJobCompleted.AccessibleName = "dateLastPaint";
            this.dateJobCompleted.Checked = false;
            this.dateJobCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateJobCompleted.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJobCompleted.Location = new System.Drawing.Point(419, 13);
            this.dateJobCompleted.Name = "dateJobCompleted";
            this.dateJobCompleted.ShowCheckBox = true;
            this.dateJobCompleted.Size = new System.Drawing.Size(153, 26);
            this.dateJobCompleted.TabIndex = 70;
            // 
            // lblJobStart
            // 
            this.lblJobStart.AutoSize = true;
            this.lblJobStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobStart.Location = new System.Drawing.Point(29, 16);
            this.lblJobStart.Name = "lblJobStart";
            this.lblJobStart.Size = new System.Drawing.Size(92, 20);
            this.lblJobStart.TabIndex = 69;
            this.lblJobStart.Text = "Job Started";
            // 
            // dateJobStart
            // 
            this.dateJobStart.AccessibleName = "dateLastPaint";
            this.dateJobStart.Checked = false;
            this.dateJobStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateJobStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJobStart.Location = new System.Drawing.Point(128, 14);
            this.dateJobStart.Name = "dateJobStart";
            this.dateJobStart.ShowCheckBox = true;
            this.dateJobStart.Size = new System.Drawing.Size(139, 26);
            this.dateJobStart.TabIndex = 68;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnAddPart);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.textPartCost);
            this.panel6.Controls.Add(this.Part);
            this.panel6.Controls.Add(this.textPartName);
            this.panel6.Controls.Add(this.dataRepairParts);
            this.panel6.Location = new System.Drawing.Point(12, 211);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(521, 241);
            this.panel6.TabIndex = 3;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(463, 16);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(46, 31);
            this.btnAddPart.TabIndex = 78;
            this.btnAddPart.Text = "+";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.radioCharge);
            this.panel7.Controls.Add(this.radioStock);
            this.panel7.Location = new System.Drawing.Point(356, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(101, 47);
            this.panel7.TabIndex = 77;
            // 
            // radioCharge
            // 
            this.radioCharge.AutoSize = true;
            this.radioCharge.Location = new System.Drawing.Point(3, 26);
            this.radioCharge.Name = "radioCharge";
            this.radioCharge.Size = new System.Drawing.Size(65, 17);
            this.radioCharge.TabIndex = 1;
            this.radioCharge.TabStop = true;
            this.radioCharge.Text = "Charage";
            this.radioCharge.UseVisualStyleBackColor = true;
            // 
            // radioStock
            // 
            this.radioStock.AutoSize = true;
            this.radioStock.Location = new System.Drawing.Point(3, 3);
            this.radioStock.Name = "radioStock";
            this.radioStock.Size = new System.Drawing.Size(53, 17);
            this.radioStock.TabIndex = 0;
            this.radioStock.TabStop = true;
            this.radioStock.Text = "Stock";
            this.radioStock.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "Cost";
            // 
            // textPartCost
            // 
            this.textPartCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPartCost.Location = new System.Drawing.Point(251, 16);
            this.textPartCost.MaxLength = 20;
            this.textPartCost.Name = "textPartCost";
            this.textPartCost.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textPartCost.Size = new System.Drawing.Size(99, 26);
            this.textPartCost.TabIndex = 75;
            // 
            // Part
            // 
            this.Part.AutoSize = true;
            this.Part.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Part.Location = new System.Drawing.Point(12, 19);
            this.Part.Name = "Part";
            this.Part.Size = new System.Drawing.Size(38, 20);
            this.Part.TabIndex = 74;
            this.Part.Text = "Part";
            // 
            // textPartName
            // 
            this.textPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPartName.Location = new System.Drawing.Point(61, 16);
            this.textPartName.MaxLength = 20;
            this.textPartName.Name = "textPartName";
            this.textPartName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textPartName.Size = new System.Drawing.Size(122, 26);
            this.textPartName.TabIndex = 57;
            // 
            // dataRepairParts
            // 
            this.dataRepairParts.AllowUserToAddRows = false;
            this.dataRepairParts.AllowUserToDeleteRows = false;
            this.dataRepairParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRepairParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataPartName,
            this.dataInventory,
            this.dataCost,
            this.dataEditbtn,
            this.data});
            this.dataRepairParts.Location = new System.Drawing.Point(3, 57);
            this.dataRepairParts.Name = "dataRepairParts";
            this.dataRepairParts.ReadOnly = true;
            this.dataRepairParts.Size = new System.Drawing.Size(524, 183);
            this.dataRepairParts.TabIndex = 0;
            this.dataRepairParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRepairParts_CellContentClick);
            // 
            // btnFinish
            // 
            this.btnFinish.AccessibleName = "btnNext";
            this.btnFinish.Location = new System.Drawing.Point(993, 545);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(156, 39);
            this.btnFinish.TabIndex = 35;
            this.btnFinish.Text = "Create";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "btnBack";
            this.btnBack.Location = new System.Drawing.Point(12, 545);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 39);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Cancel";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataPartName
            // 
            this.dataPartName.FillWeight = 120F;
            this.dataPartName.HeaderText = "Part Name";
            this.dataPartName.Name = "dataPartName";
            this.dataPartName.ReadOnly = true;
            // 
            // dataInventory
            // 
            this.dataInventory.HeaderText = "In Stock";
            this.dataInventory.Name = "dataInventory";
            this.dataInventory.ReadOnly = true;
            // 
            // dataCost
            // 
            this.dataCost.HeaderText = "Cost";
            this.dataCost.Name = "dataCost";
            this.dataCost.ReadOnly = true;
            this.dataCost.Width = 75;
            // 
            // dataEditbtn
            // 
            this.dataEditbtn.HeaderText = "";
            this.dataEditbtn.Name = "dataEditbtn";
            this.dataEditbtn.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // CreateMaintenaceRequestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 596);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CreateMaintenaceRequestScreen";
            this.Text = "CreateMaintenaceRequestScreen";
            this.Load += new System.EventHandler(this.CreateMaintenaceRequestScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCats)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJobHours)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepairParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTenantFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTenantLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateJobStarted;
        private System.Windows.Forms.Label lblreated;
        private System.Windows.Forms.DateTimePicker dateJobCreated;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.TextBox textHouseNumber;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.ComboBox drpStreetName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox drpRequestType;
        private System.Windows.Forms.MaskedTextBox textTennantPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radioCharge;
        private System.Windows.Forms.RadioButton radioStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPartCost;
        private System.Windows.Forms.Label Part;
        private System.Windows.Forms.TextBox textPartName;
        private System.Windows.Forms.DataGridView dataRepairParts;
        private System.Windows.Forms.Label lblDogs;
        private System.Windows.Forms.Label lblCats;
        private System.Windows.Forms.NumericUpDown numericUpDogs;
        private System.Windows.Forms.NumericUpDown numCats;
        private System.Windows.Forms.CheckBox checkAppliance;
        private System.Windows.Forms.CheckBox checkPermissionToEnter;
        private System.Windows.Forms.TextBox textJobDescsription;
        private System.Windows.Forms.Label lblJobDescription;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textWorkPreformed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox drpTechnicians;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numJobHours;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateJobCompleted;
        private System.Windows.Forms.Label lblJobStart;
        private System.Windows.Forms.DateTimePicker dateJobStart;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton radioDishwasher;
        private System.Windows.Forms.RadioButton radioRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCost;
        private System.Windows.Forms.DataGridViewButtonColumn dataEditbtn;
        private System.Windows.Forms.DataGridViewButtonColumn data;
    }
}