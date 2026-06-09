namespace Assignment1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            label1 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            cmbState = new ComboBox();
            label5 = new Label();
            txtZipCode = new TextBox();
            label6 = new Label();
            lstEthnicity = new ListBox();
            label7 = new Label();
            chkVeteran = new CheckBox();
            label8 = new Label();
            dtpBirthDate = new DateTimePicker();
            label9 = new Label();
            grpMaritalStatus = new GroupBox();
            rdoSingle = new RadioButton();
            rdoMarried = new RadioButton();
            rdoDivorced = new RadioButton();
            btnSave = new Button();
            btnClear = new Button();
            btnExit = new Button();
            grpMaritalStatus.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(100, 20);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 27);
            txtFirstName.TabIndex = 0;
            txtFirstName.KeyPress += txtFirstName_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(100, 55);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 27);
            txtLastName.TabIndex = 1;
            txtLastName.KeyPress += txtLastName_KeyPress;
            // 
            // label2
            // 
            label2.Location = new Point(15, 55);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(100, 95);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(236, 27);
            txtAddress.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 95);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "Address";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(100, 131);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 27);
            txtCity.TabIndex = 3;
            txtCity.KeyPress += txtCity_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 134);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 4;
            label4.Text = "City";
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            cmbState.Location = new Point(100, 173);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(121, 28);
            cmbState.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 177);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 5;
            label5.Text = "State";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(100, 215);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(100, 27);
            txtZipCode.TabIndex = 5;
            txtZipCode.KeyPress += txtZipCode_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 218);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 7;
            label6.Text = "Zip Code";
            // 
            // lstEthnicity
            // 
            lstEthnicity.FormattingEnabled = true;
            lstEthnicity.Items.AddRange(new object[] { "American Indian or Alaskan Native", "Asian / Pacific Islander", "Black or African American", "Hispanic ", "White / Caucasian" });
            lstEthnicity.Location = new Point(470, 20);
            lstEthnicity.Name = "lstEthnicity";
            lstEthnicity.Size = new Size(251, 124);
            lstEthnicity.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(390, 20);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 8;
            label7.Text = "Ethnicity";
            // 
            // chkVeteran
            // 
            chkVeteran.AutoSize = true;
            chkVeteran.Location = new Point(470, 173);
            chkVeteran.Name = "chkVeteran";
            chkVeteran.Size = new Size(18, 17);
            chkVeteran.TabIndex = 7;
            chkVeteran.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(390, 170);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 10;
            label8.Text = "Veteran";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(470, 215);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(126, 27);
            dtpBirthDate.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(390, 219);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 11;
            label9.Text = "Birth Date";
            // 
            // grpMaritalStatus
            // 
            grpMaritalStatus.Controls.Add(rdoSingle);
            grpMaritalStatus.Controls.Add(rdoMarried);
            grpMaritalStatus.Controls.Add(rdoDivorced);
            grpMaritalStatus.Location = new Point(470, 265);
            grpMaritalStatus.Name = "grpMaritalStatus";
            grpMaritalStatus.Size = new Size(251, 109);
            grpMaritalStatus.TabIndex = 9;
            grpMaritalStatus.TabStop = false;
            grpMaritalStatus.Text = "Marital Status";
            // 
            // rdoSingle
            // 
            rdoSingle.AutoSize = true;
            rdoSingle.Location = new Point(9, 78);
            rdoSingle.Name = "rdoSingle";
            rdoSingle.Size = new Size(71, 24);
            rdoSingle.TabIndex = 2;
            rdoSingle.TabStop = true;
            rdoSingle.Text = "Single";
            rdoSingle.UseVisualStyleBackColor = true;
            // 
            // rdoMarried
            // 
            rdoMarried.AutoSize = true;
            rdoMarried.Location = new Point(9, 51);
            rdoMarried.Name = "rdoMarried";
            rdoMarried.Size = new Size(82, 24);
            rdoMarried.TabIndex = 1;
            rdoMarried.TabStop = true;
            rdoMarried.Text = "Married";
            rdoMarried.UseVisualStyleBackColor = true;
            // 
            // rdoDivorced
            // 
            rdoDivorced.AutoSize = true;
            rdoDivorced.Location = new Point(9, 22);
            rdoDivorced.Name = "rdoDivorced";
            rdoDivorced.Size = new Size(90, 24);
            rdoDivorced.TabIndex = 0;
            rdoDivorced.TabStop = true;
            rdoDivorced.Text = "Divorced";
            rdoDivorced.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(100, 410);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 30);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(300, 410);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 30);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(500, 410);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 30);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(grpMaritalStatus);
            Controls.Add(label9);
            Controls.Add(dtpBirthDate);
            Controls.Add(label8);
            Controls.Add(chkVeteran);
            Controls.Add(label7);
            Controls.Add(lstEthnicity);
            Controls.Add(label6);
            Controls.Add(txtZipCode);
            Controls.Add(label5);
            Controls.Add(cmbState);
            Controls.Add(label4);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Name = "Form1";
            Text = "Student Registration";
            grpMaritalStatus.ResumeLayout(false);
            grpMaritalStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private Label label1;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private ComboBox cmbState;
        private Label label5;
        private TextBox txtZipCode;
        private Label label6;
        private ListBox lstEthnicity;
        private Label label7;
        private CheckBox chkVeteran;
        private Label label8;
        private DateTimePicker dtpBirthDate;
        private Label label9;
        private GroupBox grpMaritalStatus;
        private RadioButton rdoSingle;
        private RadioButton rdoMarried;
        private RadioButton rdoDivorced;
        private Button btnSave;
        private Button btnClear;
        private Button btnExit;
    }
}
