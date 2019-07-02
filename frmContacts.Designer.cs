namespace CRM
{
    partial class frmContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContacts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtcompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.ComboBox();
            this.txtpostalcode = new System.Windows.Forms.TextBox();
            this.txtmob = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClientType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnGetData);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(510, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 176);
            this.panel1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-202, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 66;
            this.label10.Text = "Country :";
            // 
            // btnGetData
            // 
            this.btnGetData.BackColor = System.Drawing.Color.Crimson;
            this.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetData.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetData.Location = new System.Drawing.Point(6, 141);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(85, 27);
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
            this.btnSave.Location = new System.Drawing.Point(6, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
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
            this.btnDelete.Location = new System.Drawing.Point(6, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
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
            this.btnUpdate.Location = new System.Drawing.Point(6, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 27);
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
            this.btnNew.Location = new System.Drawing.Point(6, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 27);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 311);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "Contact Notes :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Role :";
            // 
            // txtRole
            // 
            this.txtRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRole.FormattingEnabled = true;
            this.txtRole.Location = new System.Drawing.Point(140, 276);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(182, 25);
            this.txtRole.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTitle.FormattingEnabled = true;
            this.txtTitle.Location = new System.Drawing.Point(140, 245);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(182, 25);
            this.txtTitle.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcompany);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.txtpostalcode);
            this.groupBox1.Controls.Add(this.txtmob);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbClientType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtRole);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 369);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Info";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(520, 283);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(66, 20);
            this.txtID.TabIndex = 69;
            this.txtID.Visible = false;
            // 
            // txtcompany
            // 
            this.txtcompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcompany.FormattingEnabled = true;
            this.txtcompany.Items.AddRange(new object[] {
            "None"});
            this.txtcompany.Location = new System.Drawing.Point(140, 91);
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.Size = new System.Drawing.Size(184, 25);
            this.txtcompany.TabIndex = 65;
            this.txtcompany.SelectedIndexChanged += new System.EventHandler(this.txtcompany_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Company:";
            // 
            // txtState
            // 
            this.txtState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtState.FormattingEnabled = true;
            this.txtState.Location = new System.Drawing.Point(140, 214);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(182, 25);
            this.txtState.TabIndex = 11;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(140, 310);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(205, 44);
            this.txtNotes.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "State :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Postal Code";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(140, 152);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(182, 24);
            this.txtCity.TabIndex = 60;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 17);
            this.label18.TabIndex = 61;
            this.label18.Text = "City :";
            // 
            // txtCountry
            // 
            this.txtCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCountry.FormattingEnabled = true;
            this.txtCountry.Items.AddRange(new object[] {
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
            this.txtCountry.Location = new System.Drawing.Point(140, 183);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(182, 25);
            this.txtCountry.TabIndex = 57;
            // 
            // txtpostalcode
            // 
            this.txtpostalcode.Location = new System.Drawing.Point(140, 123);
            this.txtpostalcode.Name = "txtpostalcode";
            this.txtpostalcode.Size = new System.Drawing.Size(182, 24);
            this.txtpostalcode.TabIndex = 56;
            // 
            // txtmob
            // 
            this.txtmob.Location = new System.Drawing.Point(140, 59);
            this.txtmob.Name = "txtmob";
            this.txtmob.Size = new System.Drawing.Size(182, 24);
            this.txtmob.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "Country :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 57);
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 24);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact Name :";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(533, 349);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(53, 13);
            this.lblUserType.TabIndex = 86;
            this.lblUserType.Text = "UserType";
            this.lblUserType.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(545, 332);
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
            this.lblHeader.Size = new System.Drawing.Size(649, 47);
            this.lblHeader.TabIndex = 95;
            this.lblHeader.Text = "Contacts Entry ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(647, 421);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmContacts_FormClosing);
            this.Load += new System.EventHandler(this.frmContacts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox txtRole;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox txtTitle;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.ComboBox txtCountry;
        public System.Windows.Forms.TextBox txtpostalcode;
        public System.Windows.Forms.TextBox txtmob;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbClientType;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtNotes;
        public System.Windows.Forms.ComboBox txtState;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox txtcompany;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label lblUserType;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblHeader;
    }
}