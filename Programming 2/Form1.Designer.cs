namespace Programming_2
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tesx = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSalID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpID = new System.Windows.Forms.ComboBox();
            this.GrpDetails = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textFxLeaves = new System.Windows.Forms.TextBox();
            this.textAllownces = new System.Windows.Forms.TextBox();
            this.textMnthly = new System.Windows.Forms.TextBox();
            this.textOTpay = new System.Windows.Forms.TextBox();
            this.textOtHrs = new System.Windows.Forms.TextBox();
            this.textOTRate = new System.Windows.Forms.TextBox();
            this.textHolidays = new System.Windows.Forms.TextBox();
            this.textAbsents = new System.Windows.Forms.TextBox();
            this.textLeaves = new System.Windows.Forms.TextBox();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBasic = new System.Windows.Forms.TextBox();
            this.grpSal = new System.Windows.Forms.GroupBox();
            this.textGross = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textNopay = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GrpDetails.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.grpSal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Programming_2.Properties.Resources.Graphicloads_100_Flat_2_Arrow_back_256;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(24, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 61);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::Programming_2.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save_256;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(569, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 61);
            this.btnSave.TabIndex = 1;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtBegin
            // 
            this.dtBegin.CustomFormat = "yyyy/MM/dd";
            this.dtBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBegin.Location = new System.Drawing.Point(125, 211);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(198, 30);
            this.dtBegin.TabIndex = 5;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "yyyy/MM/dd";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(574, 206);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(198, 30);
            this.dtEnd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(120, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Begin Date";
            // 
            // tesx
            // 
            this.tesx.AutoSize = true;
            this.tesx.BackColor = System.Drawing.Color.Transparent;
            this.tesx.Font = new System.Drawing.Font("Century", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tesx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tesx.Location = new System.Drawing.Point(12, 9);
            this.tesx.Name = "tesx";
            this.tesx.Size = new System.Drawing.Size(173, 55);
            this.tesx.TabIndex = 9;
            this.tesx.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(569, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "End Date";
            // 
            // textSalID
            // 
            this.textSalID.Location = new System.Drawing.Point(125, 129);
            this.textSalID.Name = "textSalID";
            this.textSalID.Size = new System.Drawing.Size(175, 30);
            this.textSalID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(120, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Salary ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(572, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Employee ID";
            // 
            // cmbEmpID
            // 
            this.cmbEmpID.FormattingEnabled = true;
            this.cmbEmpID.Location = new System.Drawing.Point(577, 129);
            this.cmbEmpID.Name = "cmbEmpID";
            this.cmbEmpID.Size = new System.Drawing.Size(178, 33);
            this.cmbEmpID.TabIndex = 14;
            this.cmbEmpID.SelectedIndexChanged += new System.EventHandler(this.cmbEmpID_SelectedIndexChanged);
            // 
            // GrpDetails
            // 
            this.GrpDetails.BackColor = System.Drawing.Color.Transparent;
            this.GrpDetails.Controls.Add(this.label17);
            this.GrpDetails.Controls.Add(this.cmbMonth);
            this.GrpDetails.Controls.Add(this.btnCalculate);
            this.GrpDetails.Controls.Add(this.label13);
            this.GrpDetails.Controls.Add(this.label12);
            this.GrpDetails.Controls.Add(this.label11);
            this.GrpDetails.Controls.Add(this.label10);
            this.GrpDetails.Controls.Add(this.label9);
            this.GrpDetails.Controls.Add(this.label8);
            this.GrpDetails.Controls.Add(this.label7);
            this.GrpDetails.Controls.Add(this.label6);
            this.GrpDetails.Controls.Add(this.label5);
            this.GrpDetails.Controls.Add(this.textFxLeaves);
            this.GrpDetails.Controls.Add(this.textAllownces);
            this.GrpDetails.Controls.Add(this.textMnthly);
            this.GrpDetails.Controls.Add(this.textOTpay);
            this.GrpDetails.Controls.Add(this.textOtHrs);
            this.GrpDetails.Controls.Add(this.textOTRate);
            this.GrpDetails.Controls.Add(this.textHolidays);
            this.GrpDetails.Controls.Add(this.textAbsents);
            this.GrpDetails.Controls.Add(this.textLeaves);
            this.GrpDetails.Location = new System.Drawing.Point(39, 292);
            this.GrpDetails.Name = "GrpDetails";
            this.GrpDetails.Size = new System.Drawing.Size(864, 234);
            this.GrpDetails.TabIndex = 15;
            this.GrpDetails.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(704, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Month";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "--Select--",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(708, 73);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(130, 33);
            this.cmbMonth.TabIndex = 19;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculate.FlatAppearance.BorderSize = 2;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(723, 134);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 61);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Holidays";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(267, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "OT Pay";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(502, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Leaves";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(477, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Allowance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(477, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Monthly Pay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(267, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "OT Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "OT Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Absents";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Leaves";
            // 
            // textFxLeaves
            // 
            this.textFxLeaves.Location = new System.Drawing.Point(594, 165);
            this.textFxLeaves.Name = "textFxLeaves";
            this.textFxLeaves.Size = new System.Drawing.Size(85, 30);
            this.textFxLeaves.TabIndex = 24;
            // 
            // textAllownces
            // 
            this.textAllownces.Location = new System.Drawing.Point(594, 102);
            this.textAllownces.Name = "textAllownces";
            this.textAllownces.Size = new System.Drawing.Size(85, 30);
            this.textAllownces.TabIndex = 23;
            // 
            // textMnthly
            // 
            this.textMnthly.Location = new System.Drawing.Point(594, 40);
            this.textMnthly.Name = "textMnthly";
            this.textMnthly.Size = new System.Drawing.Size(85, 30);
            this.textMnthly.TabIndex = 22;
            // 
            // textOTpay
            // 
            this.textOTpay.Location = new System.Drawing.Point(364, 168);
            this.textOTpay.Name = "textOTpay";
            this.textOTpay.Size = new System.Drawing.Size(85, 30);
            this.textOTpay.TabIndex = 21;
            // 
            // textOtHrs
            // 
            this.textOtHrs.Location = new System.Drawing.Point(364, 102);
            this.textOtHrs.Name = "textOtHrs";
            this.textOtHrs.Size = new System.Drawing.Size(85, 30);
            this.textOtHrs.TabIndex = 20;
            this.textOtHrs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textOtHrs_MouseClick);
            // 
            // textOTRate
            // 
            this.textOTRate.Location = new System.Drawing.Point(364, 40);
            this.textOTRate.Name = "textOTRate";
            this.textOTRate.Size = new System.Drawing.Size(85, 30);
            this.textOTRate.TabIndex = 19;
            // 
            // textHolidays
            // 
            this.textHolidays.Location = new System.Drawing.Point(129, 168);
            this.textHolidays.Name = "textHolidays";
            this.textHolidays.Size = new System.Drawing.Size(85, 30);
            this.textHolidays.TabIndex = 18;
            this.textHolidays.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textHolidays_MouseClick);
            // 
            // textAbsents
            // 
            this.textAbsents.Location = new System.Drawing.Point(129, 102);
            this.textAbsents.Name = "textAbsents";
            this.textAbsents.Size = new System.Drawing.Size(85, 30);
            this.textAbsents.TabIndex = 17;
            this.textAbsents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textAbsents_MouseClick);
            // 
            // textLeaves
            // 
            this.textLeaves.Location = new System.Drawing.Point(129, 40);
            this.textLeaves.Name = "textLeaves";
            this.textLeaves.Size = new System.Drawing.Size(85, 30);
            this.textLeaves.TabIndex = 16;
            this.textLeaves.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textLeaves_MouseClick);
            // 
            // grpButtons
            // 
            this.grpButtons.BackColor = System.Drawing.Color.Transparent;
            this.grpButtons.Controls.Add(this.btnBack);
            this.grpButtons.Controls.Add(this.btnSave);
            this.grpButtons.Location = new System.Drawing.Point(86, 653);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(748, 112);
            this.grpButtons.TabIndex = 16;
            this.grpButtons.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(42, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "Basic Pay";
            // 
            // textBasic
            // 
            this.textBasic.Location = new System.Drawing.Point(143, 37);
            this.textBasic.Name = "textBasic";
            this.textBasic.Size = new System.Drawing.Size(85, 30);
            this.textBasic.TabIndex = 33;
            // 
            // grpSal
            // 
            this.grpSal.BackColor = System.Drawing.Color.Transparent;
            this.grpSal.Controls.Add(this.textGross);
            this.grpSal.Controls.Add(this.label16);
            this.grpSal.Controls.Add(this.textNopay);
            this.grpSal.Controls.Add(this.label15);
            this.grpSal.Controls.Add(this.textBasic);
            this.grpSal.Controls.Add(this.label14);
            this.grpSal.Location = new System.Drawing.Point(72, 547);
            this.grpSal.Name = "grpSal";
            this.grpSal.Size = new System.Drawing.Size(762, 100);
            this.grpSal.TabIndex = 17;
            this.grpSal.TabStop = false;
            // 
            // textGross
            // 
            this.textGross.Location = new System.Drawing.Point(615, 37);
            this.textGross.Name = "textGross";
            this.textGross.Size = new System.Drawing.Size(85, 30);
            this.textGross.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(512, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "Gross Pay";
            // 
            // textNopay
            // 
            this.textNopay.Location = new System.Drawing.Point(389, 35);
            this.textNopay.Name = "textNopay";
            this.textNopay.Size = new System.Drawing.Size(85, 30);
            this.textNopay.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(288, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "No Pay";
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.Transparent;
            this.btnValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidate.FlatAppearance.BorderSize = 2;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnValidate.Location = new System.Drawing.Point(387, 175);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(115, 61);
            this.btnValidate.TabIndex = 18;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Programming_2.Properties.Resources.Graphicloads_100_Flat_2_Arrow_back8;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(802, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 74);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Programming_2.Properties.Resources.pngtree_maple_autumn_leaves_fall_background_picture_image_629748;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 787);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.grpSal);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.GrpDetails);
            this.Controls.Add(this.cmbEmpID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSalID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tesx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtBegin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.GrpDetails.ResumeLayout(false);
            this.GrpDetails.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.grpSal.ResumeLayout(false);
            this.grpSal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tesx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSalID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpID;
        private System.Windows.Forms.GroupBox GrpDetails;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFxLeaves;
        private System.Windows.Forms.TextBox textAllownces;
        private System.Windows.Forms.TextBox textMnthly;
        private System.Windows.Forms.TextBox textOTpay;
        private System.Windows.Forms.TextBox textOtHrs;
        private System.Windows.Forms.TextBox textOTRate;
        private System.Windows.Forms.TextBox textHolidays;
        private System.Windows.Forms.TextBox textAbsents;
        private System.Windows.Forms.TextBox textLeaves;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBasic;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.GroupBox grpSal;
        private System.Windows.Forms.TextBox textGross;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textNopay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button button1;
    }
}

