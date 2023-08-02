namespace PassengerCodeApp
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
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            groupBoxGender = new GroupBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            comboBoxMeals = new ComboBox();
            label3 = new Label();
            comboBoxTravelClass = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            listBoxFlyingFrom = new ListBox();
            listBoxFlyingTo = new ListBox();
            textBox2 = new TextBox();
            label6 = new Label();
            dateTimePickerDepartingDate = new DateTimePicker();
            label7 = new Label();
            buttonReceivePassengerCode = new Button();
            dateTimePickerBirthday = new DateTimePicker();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelWrongEmail = new Label();
            groupBoxGender.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 192);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(132, 23);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(154, 192);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(132, 23);
            textBoxEmail.TabIndex = 1;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // groupBoxGender
            // 
            groupBoxGender.Controls.Add(radioButtonFemale);
            groupBoxGender.Controls.Add(radioButtonMale);
            groupBoxGender.Location = new Point(12, 234);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(132, 74);
            groupBoxGender.TabIndex = 2;
            groupBoxGender.TabStop = false;
            groupBoxGender.Text = "Gender";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(6, 47);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(63, 19);
            radioButtonFemale.TabIndex = 1;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            radioButtonFemale.CheckedChanged += radioButtonFemale_CheckedChanged;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(6, 22);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(51, 19);
            radioButtonMale.TabIndex = 0;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            radioButtonMale.CheckedChanged += radioButtonMale_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 174);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 234);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Birthday";
            // 
            // comboBoxMeals
            // 
            comboBoxMeals.FormattingEnabled = true;
            comboBoxMeals.Location = new Point(311, 252);
            comboBoxMeals.Name = "comboBoxMeals";
            comboBoxMeals.Size = new Size(121, 23);
            comboBoxMeals.TabIndex = 5;
            comboBoxMeals.SelectedIndexChanged += comboBoxMeals_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 234);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Meals";
            // 
            // comboBoxTravelClass
            // 
            comboBoxTravelClass.FormattingEnabled = true;
            comboBoxTravelClass.Location = new Point(311, 192);
            comboBoxTravelClass.Name = "comboBoxTravelClass";
            comboBoxTravelClass.Size = new Size(121, 23);
            comboBoxTravelClass.TabIndex = 7;
            comboBoxTravelClass.SelectedIndexChanged += comboBoxTravelClass_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 174);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "Travel class";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 9;
            label5.Text = "Flying from";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBoxFlyingFrom
            // 
            listBoxFlyingFrom.FormattingEnabled = true;
            listBoxFlyingFrom.ItemHeight = 15;
            listBoxFlyingFrom.Location = new Point(12, 46);
            listBoxFlyingFrom.Name = "listBoxFlyingFrom";
            listBoxFlyingFrom.Size = new Size(132, 94);
            listBoxFlyingFrom.TabIndex = 11;
            listBoxFlyingFrom.Visible = false;
            // 
            // listBoxFlyingTo
            // 
            listBoxFlyingTo.FormattingEnabled = true;
            listBoxFlyingTo.ItemHeight = 15;
            listBoxFlyingTo.Location = new Point(154, 46);
            listBoxFlyingTo.Name = "listBoxFlyingTo";
            listBoxFlyingTo.Size = new Size(132, 94);
            listBoxFlyingTo.TabIndex = 12;
            listBoxFlyingTo.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(154, 9);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 14;
            label6.Text = "Flying to";
            // 
            // dateTimePickerDepartingDate
            // 
            dateTimePickerDepartingDate.Location = new Point(311, 27);
            dateTimePickerDepartingDate.Name = "dateTimePickerDepartingDate";
            dateTimePickerDepartingDate.Size = new Size(153, 23);
            dateTimePickerDepartingDate.TabIndex = 15;
            dateTimePickerDepartingDate.ValueChanged += dateTimePickerDepartingDate_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(311, 9);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 16;
            label7.Text = "Departing";
            // 
            // buttonReceivePassengerCode
            // 
            buttonReceivePassengerCode.Location = new Point(12, 342);
            buttonReceivePassengerCode.Name = "buttonReceivePassengerCode";
            buttonReceivePassengerCode.Size = new Size(132, 42);
            buttonReceivePassengerCode.TabIndex = 17;
            buttonReceivePassengerCode.Text = "Get passenger code";
            buttonReceivePassengerCode.UseVisualStyleBackColor = true;
            buttonReceivePassengerCode.Click += buttonReceivePassengerCode_Click;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(154, 252);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(132, 23);
            dateTimePickerBirthday.TabIndex = 15;
            dateTimePickerBirthday.ValueChanged += dateTimePickerBirthday_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(154, 174);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 4;
            label8.Text = "E-mail";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(311, 56);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(153, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // labelWrongEmail
            // 
            labelWrongEmail.AutoSize = true;
            labelWrongEmail.ForeColor = Color.Red;
            labelWrongEmail.Location = new Point(154, 218);
            labelWrongEmail.Name = "labelWrongEmail";
            labelWrongEmail.Size = new Size(135, 15);
            labelWrongEmail.TabIndex = 4;
            labelWrongEmail.Text = "please enter valid e-mail";
            labelWrongEmail.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 396);
            Controls.Add(buttonReceivePassengerCode);
            Controls.Add(label7);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePickerDepartingDate);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(listBoxFlyingTo);
            Controls.Add(listBoxFlyingFrom);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxTravelClass);
            Controls.Add(label3);
            Controls.Add(comboBoxMeals);
            Controls.Add(labelWrongEmail);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBoxGender);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxGender.ResumeLayout(false);
            groupBoxGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private GroupBox groupBoxGender;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxMeals;
        private Label label3;
        private ComboBox comboBoxTravelClass;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private ListBox listBoxFlyingFrom;
        private ListBox listBoxFlyingTo;
        private TextBox textBox2;
        private Label label6;
        private DateTimePicker dateTimePickerDepartingDate;
        private Label label7;
        private Button buttonReceivePassengerCode;
        private DateTimePicker dateTimePickerBirthday;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label labelWrongEmail;
    }
}