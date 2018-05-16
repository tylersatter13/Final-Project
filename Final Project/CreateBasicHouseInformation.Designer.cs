namespace Final_Project
{
    partial class CreateBasicHouseInformation
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
            this.components = new System.ComponentModel.Container();
            this.textHouseNumber = new System.Windows.Forms.TextBox();
            this.gbBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.drpSQPlan = new System.Windows.Forms.ComboBox();
            this.drpOwner = new System.Windows.Forms.ComboBox();
            this.drpStreetName = new System.Windows.Forms.ComboBox();
            this.InterriorColors = new System.Windows.Forms.GroupBox();
            this.lblStainDate = new System.Windows.Forms.Label();
            this.lblVanFInstall = new System.Windows.Forms.Label();
            this.lblInstallDate = new System.Windows.Forms.Label();
            this.lblLastPainted = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWWork = new System.Windows.Forms.Label();
            this.lblFormicaColor = new System.Windows.Forms.Label();
            this.lblCarpetColor = new System.Windows.Forms.Label();
            this.lblPrimaryColor = new System.Windows.Forms.Label();
            this.drpWoodWork = new System.Windows.Forms.ComboBox();
            this.dateBlindReplacement = new System.Windows.Forms.DateTimePicker();
            this.dateVF = new System.Windows.Forms.DateTimePicker();
            this.dateCarpetInstall = new System.Windows.Forms.DateTimePicker();
            this.drpVynl = new System.Windows.Forms.ComboBox();
            this.drpFermica = new System.Windows.Forms.ComboBox();
            this.drpCarpetColor = new System.Windows.Forms.ComboBox();
            this.dateLastPaint = new System.Windows.Forms.DateTimePicker();
            this.drpSecondaryColor = new System.Windows.Forms.ComboBox();
            this.drpPrimaryColor = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.propertyManagerDataSet = new Final_Project.PropertyManagerDataSet();
            this.houseInteriorColorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseInteriorColorsTableAdapter = new Final_Project.PropertyManagerDataSetTableAdapters.HouseInteriorColorsTableAdapter();
            this.gbBasicInfo.SuspendLayout();
            this.InterriorColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseInteriorColorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textHouseNumber
            // 
            this.textHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHouseNumber.Location = new System.Drawing.Point(134, 24);
            this.textHouseNumber.MaxLength = 4;
            this.textHouseNumber.Name = "textHouseNumber";
            this.textHouseNumber.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textHouseNumber.Size = new System.Drawing.Size(105, 26);
            this.textHouseNumber.TabIndex = 0;
            this.textHouseNumber.Text = "0000";
            this.textHouseNumber.TextChanged += new System.EventHandler(this.textHouseNumber_TextChanged);
            this.textHouseNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHouseNumber_KeyPress);
            // 
            // gbBasicInfo
            // 
            this.gbBasicInfo.AccessibleName = "txtHouseNumber";
            this.gbBasicInfo.Controls.Add(this.lblOwner);
            this.gbBasicInfo.Controls.Add(this.lblStreetName);
            this.gbBasicInfo.Controls.Add(this.label4);
            this.gbBasicInfo.Controls.Add(this.lblHouseNumber);
            this.gbBasicInfo.Controls.Add(this.drpSQPlan);
            this.gbBasicInfo.Controls.Add(this.drpOwner);
            this.gbBasicInfo.Controls.Add(this.textHouseNumber);
            this.gbBasicInfo.Controls.Add(this.drpStreetName);
            this.gbBasicInfo.Location = new System.Drawing.Point(24, 34);
            this.gbBasicInfo.Name = "gbBasicInfo";
            this.gbBasicInfo.Size = new System.Drawing.Size(871, 136);
            this.gbBasicInfo.TabIndex = 1;
            this.gbBasicInfo.TabStop = false;
            this.gbBasicInfo.Text = "Basic Information";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(639, 83);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(55, 20);
            this.lblOwner.TabIndex = 27;
            this.lblOwner.Text = "Owner";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(596, 27);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(93, 20);
            this.lblStreetName.TabIndex = 26;
            this.lblStreetName.Text = "Streetname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sqaure Feet";
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNumber.Location = new System.Drawing.Point(10, 27);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(116, 20);
            this.lblHouseNumber.TabIndex = 24;
            this.lblHouseNumber.Text = "House Number";
            // 
            // drpSQPlan
            // 
            this.drpSQPlan.AccessibleName = "drpSQPlan";
            this.drpSQPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpSQPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpSQPlan.FormattingEnabled = true;
            this.drpSQPlan.Location = new System.Drawing.Point(134, 80);
            this.drpSQPlan.Name = "drpSQPlan";
            this.drpSQPlan.Size = new System.Drawing.Size(145, 28);
            this.drpSQPlan.TabIndex = 2;
            this.drpSQPlan.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // drpOwner
            // 
            this.drpOwner.AccessibleName = "drpOwner";
            this.drpOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpOwner.FormattingEnabled = true;
            this.drpOwner.Location = new System.Drawing.Point(708, 80);
            this.drpOwner.Name = "drpOwner";
            this.drpOwner.Size = new System.Drawing.Size(157, 28);
            this.drpOwner.TabIndex = 3;
            this.drpOwner.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // drpStreetName
            // 
            this.drpStreetName.AccessibleName = "drpStreetName";
            this.drpStreetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpStreetName.FormattingEnabled = true;
            this.drpStreetName.Location = new System.Drawing.Point(698, 24);
            this.drpStreetName.Name = "drpStreetName";
            this.drpStreetName.Size = new System.Drawing.Size(167, 28);
            this.drpStreetName.TabIndex = 1;
            this.drpStreetName.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // InterriorColors
            // 
            this.InterriorColors.AccessibleName = "grpInterriorFeatures";
            this.InterriorColors.Controls.Add(this.lblStainDate);
            this.InterriorColors.Controls.Add(this.lblVanFInstall);
            this.InterriorColors.Controls.Add(this.lblInstallDate);
            this.InterriorColors.Controls.Add(this.lblLastPainted);
            this.InterriorColors.Controls.Add(this.label2);
            this.InterriorColors.Controls.Add(this.label1);
            this.InterriorColors.Controls.Add(this.lblWWork);
            this.InterriorColors.Controls.Add(this.lblFormicaColor);
            this.InterriorColors.Controls.Add(this.lblCarpetColor);
            this.InterriorColors.Controls.Add(this.lblPrimaryColor);
            this.InterriorColors.Controls.Add(this.drpWoodWork);
            this.InterriorColors.Controls.Add(this.dateBlindReplacement);
            this.InterriorColors.Controls.Add(this.dateVF);
            this.InterriorColors.Controls.Add(this.dateCarpetInstall);
            this.InterriorColors.Controls.Add(this.drpVynl);
            this.InterriorColors.Controls.Add(this.drpFermica);
            this.InterriorColors.Controls.Add(this.drpCarpetColor);
            this.InterriorColors.Controls.Add(this.dateLastPaint);
            this.InterriorColors.Controls.Add(this.drpSecondaryColor);
            this.InterriorColors.Controls.Add(this.drpPrimaryColor);
            this.InterriorColors.Location = new System.Drawing.Point(24, 176);
            this.InterriorColors.Name = "InterriorColors";
            this.InterriorColors.Size = new System.Drawing.Size(871, 293);
            this.InterriorColors.TabIndex = 2;
            this.InterriorColors.TabStop = false;
            this.InterriorColors.Text = "InterriorFeatures";
            // 
            // lblStainDate
            // 
            this.lblStainDate.AutoSize = true;
            this.lblStainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStainDate.Location = new System.Drawing.Point(512, 243);
            this.lblStainDate.Name = "lblStainDate";
            this.lblStainDate.Size = new System.Drawing.Size(182, 20);
            this.lblStainDate.TabIndex = 23;
            this.lblStainDate.Text = "Blind Replacement Date";
            // 
            // lblVanFInstall
            // 
            this.lblVanFInstall.AutoSize = true;
            this.lblVanFInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVanFInstall.Location = new System.Drawing.Point(604, 175);
            this.lblVanFInstall.Name = "lblVanFInstall";
            this.lblVanFInstall.Size = new System.Drawing.Size(90, 20);
            this.lblVanFInstall.TabIndex = 22;
            this.lblVanFInstall.Text = "Install Date";
            // 
            // lblInstallDate
            // 
            this.lblInstallDate.AutoSize = true;
            this.lblInstallDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallDate.Location = new System.Drawing.Point(604, 102);
            this.lblInstallDate.Name = "lblInstallDate";
            this.lblInstallDate.Size = new System.Drawing.Size(90, 20);
            this.lblInstallDate.TabIndex = 21;
            this.lblInstallDate.Text = "Install Date";
            // 
            // lblLastPainted
            // 
            this.lblLastPainted.AutoSize = true;
            this.lblLastPainted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPainted.Location = new System.Drawing.Point(604, 35);
            this.lblLastPainted.Name = "lblLastPainted";
            this.lblLastPainted.Size = new System.Drawing.Size(98, 20);
            this.lblLastPainted.TabIndex = 20;
            this.lblLastPainted.Text = "Last Painted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vynal Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Secondary Color";
            // 
            // lblWWork
            // 
            this.lblWWork.AutoSize = true;
            this.lblWWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWWork.Location = new System.Drawing.Point(30, 243);
            this.lblWWork.Name = "lblWWork";
            this.lblWWork.Size = new System.Drawing.Size(92, 20);
            this.lblWWork.TabIndex = 17;
            this.lblWWork.Text = "Wood Work";
            // 
            // lblFormicaColor
            // 
            this.lblFormicaColor.AutoSize = true;
            this.lblFormicaColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormicaColor.Location = new System.Drawing.Point(21, 177);
            this.lblFormicaColor.Name = "lblFormicaColor";
            this.lblFormicaColor.Size = new System.Drawing.Size(107, 20);
            this.lblFormicaColor.TabIndex = 16;
            this.lblFormicaColor.Text = "Formica Color";
            // 
            // lblCarpetColor
            // 
            this.lblCarpetColor.AutoSize = true;
            this.lblCarpetColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarpetColor.Location = new System.Drawing.Point(24, 107);
            this.lblCarpetColor.Name = "lblCarpetColor";
            this.lblCarpetColor.Size = new System.Drawing.Size(98, 20);
            this.lblCarpetColor.TabIndex = 15;
            this.lblCarpetColor.Text = "Carpet Color";
            // 
            // lblPrimaryColor
            // 
            this.lblPrimaryColor.AutoSize = true;
            this.lblPrimaryColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryColor.Location = new System.Drawing.Point(24, 38);
            this.lblPrimaryColor.Name = "lblPrimaryColor";
            this.lblPrimaryColor.Size = new System.Drawing.Size(102, 20);
            this.lblPrimaryColor.TabIndex = 14;
            this.lblPrimaryColor.Text = "Primary Color";
            // 
            // drpWoodWork
            // 
            this.drpWoodWork.AccessibleName = "drpWoodWork";
            this.drpWoodWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpWoodWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpWoodWork.FormattingEnabled = true;
            this.drpWoodWork.Location = new System.Drawing.Point(134, 240);
            this.drpWoodWork.Name = "drpWoodWork";
            this.drpWoodWork.Size = new System.Drawing.Size(149, 28);
            this.drpWoodWork.TabIndex = 12;
            this.drpWoodWork.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // dateBlindReplacement
            // 
            this.dateBlindReplacement.AccessibleName = "dateStain";
            this.dateBlindReplacement.Checked = false;
            this.dateBlindReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBlindReplacement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBlindReplacement.Location = new System.Drawing.Point(708, 240);
            this.dateBlindReplacement.Name = "dateBlindReplacement";
            this.dateBlindReplacement.ShowCheckBox = true;
            this.dateBlindReplacement.Size = new System.Drawing.Size(144, 26);
            this.dateBlindReplacement.TabIndex = 13;
            // 
            // dateVF
            // 
            this.dateVF.AccessibleName = "drpVF";
            this.dateVF.Checked = false;
            this.dateVF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVF.Location = new System.Drawing.Point(708, 170);
            this.dateVF.Name = "dateVF";
            this.dateVF.ShowCheckBox = true;
            this.dateVF.Size = new System.Drawing.Size(144, 26);
            this.dateVF.TabIndex = 11;
            // 
            // dateCarpetInstall
            // 
            this.dateCarpetInstall.AccessibleName = "dateCarpetInstall";
            this.dateCarpetInstall.Checked = false;
            this.dateCarpetInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCarpetInstall.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCarpetInstall.Location = new System.Drawing.Point(708, 97);
            this.dateCarpetInstall.Name = "dateCarpetInstall";
            this.dateCarpetInstall.ShowCheckBox = true;
            this.dateCarpetInstall.Size = new System.Drawing.Size(144, 26);
            this.dateCarpetInstall.TabIndex = 8;
            // 
            // drpVynl
            // 
            this.drpVynl.AccessibleName = "drpVynalColor";
            this.drpVynl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpVynl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpVynl.FormattingEnabled = true;
            this.drpVynl.Location = new System.Drawing.Point(421, 173);
            this.drpVynl.Name = "drpVynl";
            this.drpVynl.Size = new System.Drawing.Size(149, 28);
            this.drpVynl.TabIndex = 10;
            this.drpVynl.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // drpFermica
            // 
            this.drpFermica.AccessibleName = "drpFermica";
            this.drpFermica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpFermica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpFermica.FormattingEnabled = true;
            this.drpFermica.Location = new System.Drawing.Point(134, 173);
            this.drpFermica.Name = "drpFermica";
            this.drpFermica.Size = new System.Drawing.Size(149, 28);
            this.drpFermica.TabIndex = 9;
            this.drpFermica.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // drpCarpetColor
            // 
            this.drpCarpetColor.AccessibleName = "drpCarpetColor";
            this.drpCarpetColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpCarpetColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpCarpetColor.FormattingEnabled = true;
            this.drpCarpetColor.Location = new System.Drawing.Point(134, 99);
            this.drpCarpetColor.Name = "drpCarpetColor";
            this.drpCarpetColor.Size = new System.Drawing.Size(149, 28);
            this.drpCarpetColor.TabIndex = 7;
            this.drpCarpetColor.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // dateLastPaint
            // 
            this.dateLastPaint.AccessibleName = "dateLastPaint";
            this.dateLastPaint.Checked = false;
            this.dateLastPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLastPaint.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLastPaint.Location = new System.Drawing.Point(708, 32);
            this.dateLastPaint.Name = "dateLastPaint";
            this.dateLastPaint.ShowCheckBox = true;
            this.dateLastPaint.Size = new System.Drawing.Size(144, 26);
            this.dateLastPaint.TabIndex = 6;
            // 
            // drpSecondaryColor
            // 
            this.drpSecondaryColor.AccessibleName = "drpSecondaryColor";
            this.drpSecondaryColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpSecondaryColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpSecondaryColor.FormattingEnabled = true;
            this.drpSecondaryColor.Location = new System.Drawing.Point(421, 32);
            this.drpSecondaryColor.Name = "drpSecondaryColor";
            this.drpSecondaryColor.Size = new System.Drawing.Size(149, 28);
            this.drpSecondaryColor.TabIndex = 5;
            this.drpSecondaryColor.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // drpPrimaryColor
            // 
            this.drpPrimaryColor.AccessibleName = "";
            this.drpPrimaryColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpPrimaryColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpPrimaryColor.FormattingEnabled = true;
            this.drpPrimaryColor.Location = new System.Drawing.Point(134, 35);
            this.drpPrimaryColor.Name = "drpPrimaryColor";
            this.drpPrimaryColor.Size = new System.Drawing.Size(149, 28);
            this.drpPrimaryColor.TabIndex = 4;
            this.drpPrimaryColor.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "btnBack";
            this.btnBack.Location = new System.Drawing.Point(24, 485);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 39);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.AccessibleName = "btnNext";
            this.btnNext.Location = new System.Drawing.Point(739, 485);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(156, 39);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // propertyManagerDataSet
            // 
            this.propertyManagerDataSet.DataSetName = "PropertyManagerDataSet";
            this.propertyManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // houseInteriorColorsBindingSource
            // 
            this.houseInteriorColorsBindingSource.DataMember = "HouseInteriorColors";
            this.houseInteriorColorsBindingSource.DataSource = this.propertyManagerDataSet;
            // 
            // houseInteriorColorsTableAdapter
            // 
            this.houseInteriorColorsTableAdapter.ClearBeforeFill = true;
            // 
            // CreateBasicHouseInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 554);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.InterriorColors);
            this.Controls.Add(this.gbBasicInfo);
            this.Name = "CreateBasicHouseInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateBasicHouseInformation";
            this.Load += new System.EventHandler(this.CreateBasicHouseInformation_Load);
            this.gbBasicInfo.ResumeLayout(false);
            this.gbBasicInfo.PerformLayout();
            this.InterriorColors.ResumeLayout(false);
            this.InterriorColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseInteriorColorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textHouseNumber;
        private System.Windows.Forms.GroupBox gbBasicInfo;
        private System.Windows.Forms.ComboBox drpOwner;
        private System.Windows.Forms.ComboBox drpStreetName;
        private System.Windows.Forms.ComboBox drpSQPlan;
        private System.Windows.Forms.GroupBox InterriorColors;
        private System.Windows.Forms.ComboBox drpWoodWork;
        private System.Windows.Forms.DateTimePicker dateBlindReplacement;
        private System.Windows.Forms.DateTimePicker dateVF;
        private System.Windows.Forms.DateTimePicker dateCarpetInstall;
        private System.Windows.Forms.ComboBox drpVynl;
        private System.Windows.Forms.ComboBox drpFermica;
        private System.Windows.Forms.ComboBox drpCarpetColor;
        private System.Windows.Forms.DateTimePicker dateLastPaint;
        private System.Windows.Forms.ComboBox drpSecondaryColor;
        private System.Windows.Forms.ComboBox drpPrimaryColor;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCarpetColor;
        private System.Windows.Forms.Label lblPrimaryColor;
        private System.Windows.Forms.Label lblFormicaColor;
        private System.Windows.Forms.Label lblWWork;
        private System.Windows.Forms.Label lblStainDate;
        private System.Windows.Forms.Label lblVanFInstall;
        private System.Windows.Forms.Label lblInstallDate;
        private System.Windows.Forms.Label lblLastPainted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHouseNumber;
        private PropertyManagerDataSet propertyManagerDataSet;
        private System.Windows.Forms.BindingSource houseInteriorColorsBindingSource;
        private PropertyManagerDataSetTableAdapters.HouseInteriorColorsTableAdapter houseInteriorColorsTableAdapter;
    }
}