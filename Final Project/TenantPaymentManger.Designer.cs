namespace Final_Project
{
    partial class TenantPaymentManger
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
            this.lblNextPayment = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblLastPaymentDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCurrentBalanceAmount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dateRangeEnd = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.lblLastPainted = new System.Windows.Forms.Label();
            this.dateRangeStart = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataTransactions = new System.Windows.Forms.DataGridView();
            this.dataPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPaymentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCreditAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDebitAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.btnPaymentSubmit = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioCredit = new System.Windows.Forms.RadioButton();
            this.radioDebit = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPaymentAmount = new System.Windows.Forms.TextBox();
            this.drpPaymentType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPetCount = new System.Windows.Forms.Label();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNextPayment);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lblLastPaymentDate);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblCurrentBalanceAmount);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(29, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 62);
            this.panel1.TabIndex = 0;
            // 
            // lblNextPayment
            // 
            this.lblNextPayment.AutoSize = true;
            this.lblNextPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPayment.Location = new System.Drawing.Point(954, 19);
            this.lblNextPayment.Name = "lblNextPayment";
            this.lblNextPayment.Size = new System.Drawing.Size(71, 20);
            this.lblNextPayment.TabIndex = 72;
            this.lblNextPayment.Text = "00/00/00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(804, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 20);
            this.label15.TabIndex = 71;
            this.label15.Text = "Next Payment Date:";
            // 
            // lblLastPaymentDate
            // 
            this.lblLastPaymentDate.AutoSize = true;
            this.lblLastPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPaymentDate.Location = new System.Drawing.Point(535, 19);
            this.lblLastPaymentDate.Name = "lblLastPaymentDate";
            this.lblLastPaymentDate.Size = new System.Drawing.Size(71, 20);
            this.lblLastPaymentDate.TabIndex = 70;
            this.lblLastPaymentDate.Text = "00/00/00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(385, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 20);
            this.label13.TabIndex = 69;
            this.label13.Text = "Last Payment Date:";
            // 
            // lblCurrentBalanceAmount
            // 
            this.lblCurrentBalanceAmount.AutoSize = true;
            this.lblCurrentBalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalanceAmount.Location = new System.Drawing.Point(151, 19);
            this.lblCurrentBalanceAmount.Name = "lblCurrentBalanceAmount";
            this.lblCurrentBalanceAmount.Size = new System.Drawing.Size(58, 20);
            this.lblCurrentBalanceAmount.TabIndex = 68;
            this.lblCurrentBalanceAmount.Text = "$00.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 67;
            this.label10.Text = "CurrentBalance:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Controls.Add(this.dateRangeEnd);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.lblLastPainted);
            this.panel3.Controls.Add(this.dateRangeStart);
            this.panel3.Location = new System.Drawing.Point(588, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 69);
            this.panel3.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(419, 24);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(111, 25);
            this.btnFilter.TabIndex = 25;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dateRangeEnd
            // 
            this.dateRangeEnd.AccessibleName = "dateLastPaint";
            this.dateRangeEnd.Checked = false;
            this.dateRangeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRangeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRangeEnd.Location = new System.Drawing.Point(247, 24);
            this.dateRangeEnd.Name = "dateRangeEnd";
            this.dateRangeEnd.ShowCheckBox = true;
            this.dateRangeEnd.Size = new System.Drawing.Size(144, 26);
            this.dateRangeEnd.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(203, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "End";
            // 
            // lblLastPainted
            // 
            this.lblLastPainted.AutoSize = true;
            this.lblLastPainted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPainted.Location = new System.Drawing.Point(3, 29);
            this.lblLastPainted.Name = "lblLastPainted";
            this.lblLastPainted.Size = new System.Drawing.Size(44, 20);
            this.lblLastPainted.TabIndex = 22;
            this.lblLastPainted.Text = "Start";
            // 
            // dateRangeStart
            // 
            this.dateRangeStart.AccessibleName = "dateLastPaint";
            this.dateRangeStart.Checked = false;
            this.dateRangeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRangeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRangeStart.Location = new System.Drawing.Point(53, 24);
            this.dateRangeStart.Name = "dateRangeStart";
            this.dateRangeStart.ShowCheckBox = true;
            this.dateRangeStart.Size = new System.Drawing.Size(144, 26);
            this.dateRangeStart.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataTransactions);
            this.panel4.Location = new System.Drawing.Point(588, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 349);
            this.panel4.TabIndex = 2;
            // 
            // dataTransactions
            // 
            this.dataTransactions.AllowUserToAddRows = false;
            this.dataTransactions.AllowUserToDeleteRows = false;
            this.dataTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataPaymentDate,
            this.dataPaymentDescription,
            this.dataCreditAmount,
            this.dataDebitAmount,
            this.dataBalance});
            this.dataTransactions.Location = new System.Drawing.Point(0, 0);
            this.dataTransactions.Name = "dataTransactions";
            this.dataTransactions.ReadOnly = true;
            this.dataTransactions.Size = new System.Drawing.Size(543, 346);
            this.dataTransactions.TabIndex = 0;
            // 
            // dataPaymentDate
            // 
            this.dataPaymentDate.HeaderText = "Payment Date";
            this.dataPaymentDate.Name = "dataPaymentDate";
            this.dataPaymentDate.ReadOnly = true;
            this.dataPaymentDate.Width = 75;
            // 
            // dataPaymentDescription
            // 
            this.dataPaymentDescription.HeaderText = "Description";
            this.dataPaymentDescription.Name = "dataPaymentDescription";
            this.dataPaymentDescription.ReadOnly = true;
            this.dataPaymentDescription.Width = 125;
            // 
            // dataCreditAmount
            // 
            this.dataCreditAmount.FillWeight = 90F;
            this.dataCreditAmount.HeaderText = "Charges Amount";
            this.dataCreditAmount.Name = "dataCreditAmount";
            this.dataCreditAmount.ReadOnly = true;
            // 
            // dataDebitAmount
            // 
            this.dataDebitAmount.HeaderText = "Payment Amount";
            this.dataDebitAmount.Name = "dataDebitAmount";
            this.dataDebitAmount.ReadOnly = true;
            // 
            // dataBalance
            // 
            this.dataBalance.HeaderText = "Balance";
            this.dataBalance.Name = "dataBalance";
            this.dataBalance.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.dateTransactionDate);
            this.panel5.Controls.Add(this.btnPaymentSubmit);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.textPaymentAmount);
            this.panel5.Controls.Add(this.drpPaymentType);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.textDescription);
            this.panel5.Location = new System.Drawing.Point(29, 297);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(530, 230);
            this.panel5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Date";
            // 
            // dateTransactionDate
            // 
            this.dateTransactionDate.AccessibleName = "dateLastPaint";
            this.dateTransactionDate.Checked = false;
            this.dateTransactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTransactionDate.Location = new System.Drawing.Point(358, 119);
            this.dateTransactionDate.Name = "dateTransactionDate";
            this.dateTransactionDate.ShowCheckBox = true;
            this.dateTransactionDate.Size = new System.Drawing.Size(145, 26);
            this.dateTransactionDate.TabIndex = 32;
            // 
            // btnPaymentSubmit
            // 
            this.btnPaymentSubmit.AccessibleName = "btnNext";
            this.btnPaymentSubmit.Location = new System.Drawing.Point(185, 174);
            this.btnPaymentSubmit.Name = "btnPaymentSubmit";
            this.btnPaymentSubmit.Size = new System.Drawing.Size(156, 41);
            this.btnPaymentSubmit.TabIndex = 31;
            this.btnPaymentSubmit.Text = "Submit";
            this.btnPaymentSubmit.UseVisualStyleBackColor = true;
            this.btnPaymentSubmit.Click += new System.EventHandler(this.btnPaymentSubmit_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radioCredit);
            this.panel6.Controls.Add(this.radioDebit);
            this.panel6.Location = new System.Drawing.Point(25, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 33);
            this.panel6.TabIndex = 30;
            // 
            // radioCredit
            // 
            this.radioCredit.AutoSize = true;
            this.radioCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCredit.Location = new System.Drawing.Point(107, 3);
            this.radioCredit.Name = "radioCredit";
            this.radioCredit.Size = new System.Drawing.Size(79, 24);
            this.radioCredit.TabIndex = 56;
            this.radioCredit.Text = "Charge";
            this.radioCredit.UseVisualStyleBackColor = true;
            // 
            // radioDebit
            // 
            this.radioDebit.AutoSize = true;
            this.radioDebit.Checked = true;
            this.radioDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDebit.Location = new System.Drawing.Point(3, 3);
            this.radioDebit.Name = "radioDebit";
            this.radioDebit.Size = new System.Drawing.Size(89, 24);
            this.radioDebit.TabIndex = 55;
            this.radioDebit.TabStop = true;
            this.radioDebit.Text = "Payment";
            this.radioDebit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Amount";
            // 
            // textPaymentAmount
            // 
            this.textPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPaymentAmount.Location = new System.Drawing.Point(96, 75);
            this.textPaymentAmount.MaxLength = 10;
            this.textPaymentAmount.Name = "textPaymentAmount";
            this.textPaymentAmount.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textPaymentAmount.Size = new System.Drawing.Size(105, 26);
            this.textPaymentAmount.TabIndex = 27;
            this.textPaymentAmount.Text = "000.00";
            // 
            // drpPaymentType
            // 
            this.drpPaymentType.AccessibleName = "drpSQPlan";
            this.drpPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpPaymentType.FormattingEnabled = true;
            this.drpPaymentType.Location = new System.Drawing.Point(358, 75);
            this.drpPaymentType.Name = "drpPaymentType";
            this.drpPaymentType.Size = new System.Drawing.Size(145, 28);
            this.drpPaymentType.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Payment Description";
            // 
            // textDescription
            // 
            this.textDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(28, 34);
            this.textDescription.MaxLength = 40;
            this.textDescription.Name = "textDescription";
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textDescription.Size = new System.Drawing.Size(478, 26);
            this.textDescription.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(29, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 188);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.19157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.80843F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPetCount, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblHouseNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPhoneNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.53489F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.46511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 183);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 38);
            this.label9.TabIndex = 74;
            this.label9.Text = "Pets";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPetCount
            // 
            this.lblPetCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPetCount.AutoSize = true;
            this.lblPetCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetCount.Location = new System.Drawing.Point(264, 145);
            this.lblPetCount.Name = "lblPetCount";
            this.lblPetCount.Size = new System.Drawing.Size(255, 38);
            this.lblPetCount.TabIndex = 75;
            this.lblPetCount.Text = "0";
            this.lblPetCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNumber.Location = new System.Drawing.Point(3, 0);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(255, 27);
            this.lblHouseNumber.TabIndex = 66;
            this.lblHouseNumber.Text = "Firstname:";
            this.lblHouseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(264, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(255, 27);
            this.lblFirstName.TabIndex = 68;
            this.lblFirstName.Text = "John";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(264, 108);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(255, 37);
            this.lblAddress.TabIndex = 73;
            this.lblAddress.Text = "1234 Seasme St";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 42);
            this.label1.TabIndex = 67;
            this.label1.Text = "Lastname";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 37);
            this.label7.TabIndex = 72;
            this.label7.Text = "Address";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(264, 27);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(255, 42);
            this.lblLastName.TabIndex = 69;
            this.lblLastName.Text = "Doe";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(264, 69);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(255, 39);
            this.lblPhoneNumber.TabIndex = 71;
            this.lblPhoneNumber.Text = "(503)123-4567";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 39);
            this.label5.TabIndex = 70;
            this.label5.Text = "Phone Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1165, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "btnBack";
            this.btnBack.Location = new System.Drawing.Point(33, 545);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 39);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TenantPaymentManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 596);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TenantPaymentManger";
            this.Text = "TenantPaymentManger";
            this.Load += new System.EventHandler(this.TenantPaymentManger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPetCount;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNextPayment;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblLastPaymentDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCurrentBalanceAmount;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.Label lblLastPainted;
        private System.Windows.Forms.DateTimePicker dateRangeStart;
        private System.Windows.Forms.DateTimePicker dateRangeEnd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drpPaymentType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPaymentAmount;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioCredit;
        private System.Windows.Forms.RadioButton radioDebit;
        private System.Windows.Forms.Button btnPaymentSubmit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataTransactions;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPaymentDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCreditAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDebitAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTransactionDate;
    }
}