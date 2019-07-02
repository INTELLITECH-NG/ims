namespace CRM
{
    partial class frmInvestment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvestment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcurrency = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.txtCUSIPNumber = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtgoal = new System.Windows.Forms.ComboBox();
            this.txtsector = new System.Windows.Forms.ComboBox();
            this.txtassettype = new System.Windows.Forms.ComboBox();
            this.txtclientname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShares = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtinvestmentType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGetData);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(521, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 189);
            this.panel1.TabIndex = 10;
            // 
            // btnGetData
            // 
            this.btnGetData.BackColor = System.Drawing.Color.Crimson;
            this.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetData.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetData.Location = new System.Drawing.Point(10, 150);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(85, 31);
            this.btnGetData.TabIndex = 4;
            this.btnGetData.Text = "&Get Data";
            this.btnGetData.UseVisualStyleBackColor = false;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(10, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(10, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(10, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(10, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Investment Goal :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Asset Type :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Sector :";
            // 
            // txtcurrency
            // 
            this.txtcurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcurrency.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcurrency.FormattingEnabled = true;
            this.txtcurrency.Items.AddRange(new object[] {
            "AED",
            "AUD",
            "CAD",
            "CHF",
            "EUR",
            "GBP",
            "HKD",
            "ILS",
            "ILS",
            "JMD",
            "JPY",
            "KRW",
            "KWD",
            "MXN",
            "NZD",
            "PKR",
            "RUB",
            "SGD",
            "TWD",
            "USD",
            "ZAR"});
            this.txtcurrency.Location = new System.Drawing.Point(133, 148);
            this.txtcurrency.Name = "txtcurrency";
            this.txtcurrency.Size = new System.Drawing.Size(55, 25);
            this.txtcurrency.TabIndex = 3;
            this.txtcurrency.SelectedIndexChanged += new System.EventHandler(this.txtcurrency_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Currency:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Date :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUserType);
            this.groupBox1.Controls.Add(this.txtCUSIPNumber);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.txtClientID);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txtgoal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtsector);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtassettype);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtcurrency);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtclientname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtShares);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtinvestmentType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 419);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Investment Info";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(418, 133);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(62, 17);
            this.lblUserType.TabIndex = 86;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // txtCUSIPNumber
            // 
            this.txtCUSIPNumber.Location = new System.Drawing.Point(133, 119);
            this.txtCUSIPNumber.Name = "txtCUSIPNumber";
            this.txtCUSIPNumber.Size = new System.Drawing.Size(182, 24);
            this.txtCUSIPNumber.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(430, 116);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 17);
            this.lblUser.TabIndex = 87;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "CUSIP Number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.AllowDrop = true;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(94, 17);
            this.label30.TabIndex = 12;
            this.label30.Text = "Investment ID :";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClientID
            // 
            this.txtClientID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtClientID.FormattingEnabled = true;
            this.txtClientID.Location = new System.Drawing.Point(133, 61);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(182, 25);
            this.txtClientID.TabIndex = 0;
            this.txtClientID.SelectedIndexChanged += new System.EventHandler(this.txtClientID_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(133, 32);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(126, 24);
            this.ID.TabIndex = 11;
            // 
            // txtdate
            // 
            this.txtdate.CustomFormat = "dd/MM/yyyy";
            this.txtdate.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdate.Location = new System.Drawing.Point(133, 178);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(95, 22);
            this.txtdate.TabIndex = 4;
            // 
            // txtgoal
            // 
            this.txtgoal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtgoal.FormattingEnabled = true;
            this.txtgoal.Items.AddRange(new object[] {
            "High Risk",
            "Low Risk",
            "Medium Risk",
            "Growth",
            "Income",
            "Retirement",
            "College",
            "Other"});
            this.txtgoal.Location = new System.Drawing.Point(133, 264);
            this.txtgoal.Name = "txtgoal";
            this.txtgoal.Size = new System.Drawing.Size(182, 25);
            this.txtgoal.TabIndex = 7;
            // 
            // txtsector
            // 
            this.txtsector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtsector.FormattingEnabled = true;
            this.txtsector.Items.AddRange(new object[] {
            "Basic Materials",
            "Consumer Cyclical",
            "Financial Services",
            "Real Estate",
            "Consumer Defensive",
            "Health Care",
            "Utilities",
            "Communication Services",
            "Energy",
            "industrial",
            "Technoogy",
            "Other"});
            this.txtsector.Location = new System.Drawing.Point(133, 293);
            this.txtsector.Name = "txtsector";
            this.txtsector.Size = new System.Drawing.Size(182, 25);
            this.txtsector.TabIndex = 8;
            // 
            // txtassettype
            // 
            this.txtassettype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtassettype.FormattingEnabled = true;
            this.txtassettype.Items.AddRange(new object[] {
            "Large Value",
            "Large Core/Blend",
            "Large Growth",
            "Mid Value",
            "Mid Core/Blend",
            "Mid Growth",
            "Small Value",
            "Small Core/Blend",
            "Small Growth",
            "Other"});
            this.txtassettype.Location = new System.Drawing.Point(133, 235);
            this.txtassettype.Name = "txtassettype";
            this.txtassettype.Size = new System.Drawing.Size(182, 25);
            this.txtassettype.TabIndex = 6;
            // 
            // txtclientname
            // 
            this.txtclientname.Enabled = false;
            this.txtclientname.Location = new System.Drawing.Point(133, 90);
            this.txtclientname.Name = "txtclientname";
            this.txtclientname.Size = new System.Drawing.Size(182, 24);
            this.txtclientname.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Client Name:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(133, 323);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(142, 24);
            this.txtprice.TabIndex = 9;
            this.txtprice.Text = "0";
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Unit Price:";
            // 
            // txtShares
            // 
            this.txtShares.Location = new System.Drawing.Point(133, 352);
            this.txtShares.Name = "txtShares";
            this.txtShares.Size = new System.Drawing.Size(142, 24);
            this.txtShares.TabIndex = 10;
            this.txtShares.Text = "0";
            this.txtShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtShares.TextChanged += new System.EventHandler(this.txtShares_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Shares :";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(133, 381);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(142, 24);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total :";
            // 
            // txtinvestmentType
            // 
            this.txtinvestmentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtinvestmentType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtinvestmentType.FormattingEnabled = true;
            this.txtinvestmentType.Items.AddRange(new object[] {
            "No Load Mutual Fund",
            "Loaded Mutual Fund",
            "Stock ",
            "Bond",
            "Cash",
            "Index",
            "Option",
            "Cash",
            "Exchange Rate",
            "Exchange Traded Fund",
            "Treasury Bill",
            "Annuity",
            "Equity",
            "Future",
            "Other"});
            this.txtinvestmentType.Location = new System.Drawing.Point(133, 206);
            this.txtinvestmentType.Name = "txtinvestmentType";
            this.txtinvestmentType.Size = new System.Drawing.Size(182, 25);
            this.txtinvestmentType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Investment Type :";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(521, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 30;
            this.textBox1.Visible = false;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblHeader.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Location = new System.Drawing.Point(-2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(678, 38);
            this.lblHeader.TabIndex = 98;
            this.lblHeader.Text = "Investment Entry ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInvestment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(673, 459);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInvestment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInvestment_FormClosing);
            this.Load += new System.EventHandler(this.frmInvestment_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnGetData;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox txtcurrency;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker txtdate;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtprice;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtShares;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox txtinvestmentType;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox txtgoal;
        public System.Windows.Forms.ComboBox txtsector;
        public System.Windows.Forms.ComboBox txtassettype;
        public System.Windows.Forms.TextBox txtclientname;
        public System.Windows.Forms.ComboBox txtClientID;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.TextBox ID;
        public System.Windows.Forms.TextBox txtCUSIPNumber;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label lblUserType;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblHeader;
    }
}