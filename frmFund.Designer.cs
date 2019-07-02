namespace CRM
{
    partial class frmFund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFund));
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.txtnotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtplatform = new System.Windows.Forms.ComboBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcountry = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClientType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAssetClass = new System.Windows.Forms.ComboBox();
            this.txtFundName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "1-Lead"});
            this.txtStatus.Location = new System.Drawing.Point(155, 184);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(182, 25);
            this.txtStatus.TabIndex = 11;
            // 
            // txtnotes
            // 
            this.txtnotes.Location = new System.Drawing.Point(154, 275);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Size = new System.Drawing.Size(296, 63);
            this.txtnotes.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fund Pipeline Status:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 91);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 17);
            this.label19.TabIndex = 62;
            this.label19.Text = "Platform";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(156, 122);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(182, 24);
            this.txtValue.TabIndex = 60;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtplatform);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtnotes);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtcountry);
            this.groupBox1.Controls.Add(this.comboBox10);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbClientType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtAssetClass);
            this.groupBox1.Controls.Add(this.txtFundName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 381);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fund Info";
            // 
            // txtplatform
            // 
            this.txtplatform.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtplatform.FormattingEnabled = true;
            this.txtplatform.Items.AddRange(new object[] {
            "LongTermEquity",
            "Short Term Equity"});
            this.txtplatform.Location = new System.Drawing.Point(155, 91);
            this.txtplatform.Name = "txtplatform";
            this.txtplatform.Size = new System.Drawing.Size(182, 25);
            this.txtplatform.TabIndex = 66;
            // 
            // txtdate
            // 
            this.txtdate.CustomFormat = "dd/MM/yyyy";
            this.txtdate.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdate.Location = new System.Drawing.Point(156, 246);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(94, 22);
            this.txtdate.TabIndex = 65;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(155, 123);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(182, 24);
            this.textBox6.TabIndex = 60;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 17);
            this.label18.TabIndex = 61;
            this.label18.Text = "Value :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "City :";
            this.label3.Visible = false;
            // 
            // txtcountry
            // 
            this.txtcountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcountry.FormattingEnabled = true;
            this.txtcountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "American Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antarctica",
            "Antigua",
            "Argentina",
            "Armenia",
            "Aruba",
            "Ascension",
            "Australia",
            "Australian External Territories",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Barbuda",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia & Herzegovina",
            "Botswana",
            "Brazil",
            "British Virgin Islands",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde Islands",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chatham Island (New Zealand)",
            "Chile",
            "China (PRC)",
            "Christmas Island",
            "CocosKeeling Islands",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo, Dem. Rep. of (former Zaire)",
            "Cook Islands",
            "Costa Rica",
            "Côte d\'Ivoire (Ivory Coast)",
            "Croatia",
            "Cuba",
            "Cuba (Guantanamo Bay)",
            "Curaçao",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Diego Garcia",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Easter Island",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Ellipso",
            "EMSAT",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Falkland Islands (Malvinas)",
            "Faroe Islands",
            "Fiji Islands",
            "Finland",
            "France",
            "French Antilles",
            "French Guiana",
            "French Polynesia",
            "Gabonese Republic",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Globalstar",
            "Greece",
            "Greenland",
            "Grenada",
            "Guadeloupe",
            "Guam",
            "Guantanamo Bay",
            "Guatemala",
            "GuineaBissau",
            "Guinea",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "ICO Global",
            "Iceland",
            "India",
            "Indonesia",
            "Inmarsat(Atlantic Ocean East)",
            "Inmarsat(Atlantic Ocean West)",
            "Inmarsat(Indian Ocean)",
            "Inmarsat(Pacific Ocean)",
            "Inmarsat SNAC",
            "Iran",
            "Iraq",
            "Ireland",
            "Iridium",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea (North)",
            "Korea (South)",
            "Kuwait",
            "Kyrgyz Republic",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macao",
            "Macedonia (Former Yugoslav Rep of)",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali Republic",
            "Malta",
            "Marshall Islands",
            "Martinique",
            "Mauritania",
            "Mauritius",
            "Mayotte Island",
            "Mexico",
            "Micronesia, (Federal States of)",
            "Midway Island",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "Netherlands Antilles",
            "Nevis",
            "New Caledonia",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Niue",
            "Norfolk Island",
            "Northern Marianas Islands",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestinian Settlements",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Réunion Island",
            "Romania",
            "Russia",
            "Rwandese Republic",
            "St. Helena",
            "St. Kitts/Nevis",
            "St. Lucia",
            "St. Pierre & Miquelon",
            "St. Vincent & Grenadines",
            "Samoa",
            "San Marino",
            "São Tomé and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles Republic",
            "Sierra Leone",
            "Singapore",
            "Slovak Republic",
            "Slovenia",
            "Solomon Islands",
            "Somali Democratic Republic",
            "South Africa",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Thuraya",
            "Timor Leste",
            "Togolese Republic",
            "Tokelau",
            "Tonga Islands",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks and Caicos Islands",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Wake Island",
            "Wallis and Futuna Islands",
            "Yemen",
            "Zambia",
            "Zanzibar",
            "Zimbabwe"});
            this.txtcountry.Location = new System.Drawing.Point(155, 153);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(182, 25);
            this.txtcountry.TabIndex = 57;
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(154, 154);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(182, 25);
            this.comboBox10.TabIndex = 57;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(155, 60);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(182, 24);
            this.txtAccount.TabIndex = 56;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(155, 61);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(182, 24);
            this.textBox8.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Country :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "Account # :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Mobile No :";
            // 
            // cmbClientType
            // 
            this.cmbClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientType.FormattingEnabled = true;
            this.cmbClientType.Location = new System.Drawing.Point(-197, 324);
            this.cmbClientType.Name = "cmbClientType";
            this.cmbClientType.Size = new System.Drawing.Size(182, 25);
            this.cmbClientType.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-317, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Company Type :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "Notes :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Date :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Asset Class:";
            // 
            // txtAssetClass
            // 
            this.txtAssetClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAssetClass.FormattingEnabled = true;
            this.txtAssetClass.Items.AddRange(new object[] {
            "Absolute Return",
            "Private Equity"});
            this.txtAssetClass.Location = new System.Drawing.Point(155, 215);
            this.txtAssetClass.Name = "txtAssetClass";
            this.txtAssetClass.Size = new System.Drawing.Size(182, 25);
            this.txtAssetClass.TabIndex = 11;
            // 
            // txtFundName
            // 
            this.txtFundName.Location = new System.Drawing.Point(155, 30);
            this.txtFundName.Name = "txtFundName";
            this.txtFundName.Size = new System.Drawing.Size(182, 24);
            this.txtFundName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fund Name :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGetData);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(534, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 198);
            this.panel1.TabIndex = 13;
            // 
            // btnGetData
            // 
            this.btnGetData.BackColor = System.Drawing.Color.Crimson;
            this.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetData.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetData.Location = new System.Drawing.Point(6, 154);
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
            this.btnSave.Location = new System.Drawing.Point(6, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 31);
            this.btnSave.TabIndex = 3;
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
            this.btnDelete.Location = new System.Drawing.Point(6, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 31);
            this.btnDelete.TabIndex = 2;
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
            this.btnUpdate.Location = new System.Drawing.Point(6, 81);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 31);
            this.btnUpdate.TabIndex = 1;
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
            this.btnNew.Location = new System.Drawing.Point(6, 8);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(534, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 67;
            this.textBox1.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(581, 337);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(53, 13);
            this.lblUserType.TabIndex = 86;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(593, 320);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 87;
            this.lblUser.Text = "User";
            this.lblUser.Visible = false;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.BackColor = System.Drawing.Color.DarkMagenta;
            this.lblHeader.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Location = new System.Drawing.Point(-1, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(651, 47);
            this.lblHeader.TabIndex = 97;
            this.lblHeader.Text = "Fund Entry ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(647, 438);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fund";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFund_FormClosing);
            this.Load += new System.EventHandler(this.frmFund_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox txtStatus;
        public System.Windows.Forms.TextBox txtnotes;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtValue;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox txtcountry;
        public System.Windows.Forms.ComboBox comboBox10;
        public System.Windows.Forms.TextBox txtAccount;
        public System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbClientType;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox txtAssetClass;
        public System.Windows.Forms.TextBox txtFundName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnGetData;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.DateTimePicker txtdate;
        public System.Windows.Forms.ComboBox txtplatform;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label lblUserType;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblHeader;
    }
}