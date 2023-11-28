namespace Group22_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            DisplayFlightsBtn = new Button();
            FlightList = new RichTextBox();
            label5 = new Label();
            AllFlightsCheckBox = new CheckBox();
            panel6 = new Panel();
            delCustomerBtn = new Button();
            customerIDbox = new TextBox();
            label13 = new Label();
            label14 = new Label();
            ListCustomerBtn = new Button();
            panel2 = new Panel();
            AddPassBtn = new Button();
            AddCustPhoneText = new TextBox();
            AddCustLNameText = new TextBox();
            AddCustFNameText = new TextBox();
            AddCustFlightNumText = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            DelFlightNum = new Button();
            DelFlightText = new TextBox();
            label12 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            AddFlightBtn = new Button();
            MaxPassText = new TextBox();
            label11 = new Label();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            panel5 = new Panel();
            ResultsList = new RichTextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, -2);
            label1.Name = "label1";
            label1.Size = new Size(290, 32);
            label1.TabIndex = 1;
            label1.Text = "Display Flight Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(DisplayFlightsBtn);
            panel1.Controls.Add(FlightList);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(AllFlightsCheckBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(439, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 256);
            panel1.TabIndex = 2;
            // 
            // DisplayFlightsBtn
            // 
            DisplayFlightsBtn.Location = new Point(114, 199);
            DisplayFlightsBtn.Name = "DisplayFlightsBtn";
            DisplayFlightsBtn.Size = new Size(83, 39);
            DisplayFlightsBtn.TabIndex = 9;
            DisplayFlightsBtn.Text = "Display Flights";
            DisplayFlightsBtn.UseVisualStyleBackColor = true;
            DisplayFlightsBtn.Click += button1_Click;
            // 
            // FlightList
            // 
            FlightList.ForeColor = Color.Black;
            FlightList.Location = new Point(26, 101);
            FlightList.Name = "FlightList";
            FlightList.Size = new Size(255, 70);
            FlightList.TabIndex = 5;
            FlightList.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 68);
            label5.Name = "label5";
            label5.Size = new Size(171, 30);
            label5.TabIndex = 4;
            label5.Text = "Flight Number(s)  \r\nEnter Comma Separated Values";
            // 
            // AllFlightsCheckBox
            // 
            AllFlightsCheckBox.AutoSize = true;
            AllFlightsCheckBox.Location = new Point(26, 177);
            AllFlightsCheckBox.Name = "AllFlightsCheckBox";
            AllFlightsCheckBox.Size = new Size(78, 19);
            AllFlightsCheckBox.TabIndex = 2;
            AllFlightsCheckBox.Text = "All Flights";
            AllFlightsCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gainsboro;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(delCustomerBtn);
            panel6.Controls.Add(customerIDbox);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label14);
            panel6.Location = new Point(-1, 286);
            panel6.Name = "panel6";
            panel6.Size = new Size(319, 200);
            panel6.TabIndex = 10;
            // 
            // delCustomerBtn
            // 
            delCustomerBtn.Location = new Point(105, 107);
            delCustomerBtn.Name = "delCustomerBtn";
            delCustomerBtn.Size = new Size(83, 39);
            delCustomerBtn.TabIndex = 7;
            delCustomerBtn.Text = "Delete Customer";
            delCustomerBtn.UseVisualStyleBackColor = true;
            delCustomerBtn.Click += delCustomerBtn_Click;
            // 
            // customerIDbox
            // 
            customerIDbox.Location = new Point(182, 67);
            customerIDbox.Name = "customerIDbox";
            customerIDbox.Size = new Size(100, 23);
            customerIDbox.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 70);
            label13.Name = "label13";
            label13.Size = new Size(73, 15);
            label13.TabIndex = 6;
            label13.Text = "Customer ID";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(55, 10);
            label14.Name = "label14";
            label14.Size = new Size(204, 32);
            label14.TabIndex = 1;
            label14.Text = "Delete Customers";
            // 
            // ListCustomerBtn
            // 
            ListCustomerBtn.Location = new Point(21, 213);
            ListCustomerBtn.Name = "ListCustomerBtn";
            ListCustomerBtn.Size = new Size(114, 40);
            ListCustomerBtn.TabIndex = 8;
            ListCustomerBtn.Text = "List Customers";
            ListCustomerBtn.UseVisualStyleBackColor = true;
            ListCustomerBtn.Click += ListCustomerBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ListCustomerBtn);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(AddPassBtn);
            panel2.Controls.Add(AddCustPhoneText);
            panel2.Controls.Add(AddCustLNameText);
            panel2.Controls.Add(AddCustFNameText);
            panel2.Controls.Add(AddCustFlightNumText);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(818, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 487);
            panel2.TabIndex = 3;
            // 
            // AddPassBtn
            // 
            AddPassBtn.Location = new Point(193, 214);
            AddPassBtn.Name = "AddPassBtn";
            AddPassBtn.Size = new Size(83, 39);
            AddPassBtn.TabIndex = 9;
            AddPassBtn.Text = "Add Passenger";
            AddPassBtn.UseVisualStyleBackColor = true;
            AddPassBtn.Click += button4_Click;
            // 
            // AddCustPhoneText
            // 
            AddCustPhoneText.Location = new Point(158, 174);
            AddCustPhoneText.Name = "AddCustPhoneText";
            AddCustPhoneText.Size = new Size(120, 23);
            AddCustPhoneText.TabIndex = 9;
            // 
            // AddCustLNameText
            // 
            AddCustLNameText.Location = new Point(158, 134);
            AddCustLNameText.Name = "AddCustLNameText";
            AddCustLNameText.Size = new Size(120, 23);
            AddCustLNameText.TabIndex = 8;
            // 
            // AddCustFNameText
            // 
            AddCustFNameText.Location = new Point(158, 96);
            AddCustFNameText.Name = "AddCustFNameText";
            AddCustFNameText.Size = new Size(120, 23);
            AddCustFNameText.TabIndex = 7;
            // 
            // AddCustFlightNumText
            // 
            AddCustFlightNumText.Location = new Point(158, 59);
            AddCustFlightNumText.Name = "AddCustFlightNumText";
            AddCustFlightNumText.Size = new Size(120, 23);
            AddCustFlightNumText.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 177);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 5;
            label9.Text = "Phone Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 62);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 4;
            label8.Text = "Flight Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 137);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 3;
            label7.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 99);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 2;
            label6.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, -1);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 1;
            label2.Text = "Add Customer";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(DelFlightNum);
            panel3.Controls.Add(DelFlightText);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 232);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 233);
            panel3.TabIndex = 5;
            // 
            // DelFlightNum
            // 
            DelFlightNum.Location = new Point(106, 144);
            DelFlightNum.Name = "DelFlightNum";
            DelFlightNum.Size = new Size(83, 39);
            DelFlightNum.TabIndex = 7;
            DelFlightNum.Text = "Delete Flight";
            DelFlightNum.UseVisualStyleBackColor = true;
            DelFlightNum.Click += button3_Click;
            // 
            // DelFlightText
            // 
            DelFlightText.Location = new Point(174, 97);
            DelFlightText.Name = "DelFlightText";
            DelFlightText.Size = new Size(100, 23);
            DelFlightText.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 100);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 6;
            label12.Text = "Flight Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 32);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 1;
            label3.Text = "Delete Flight";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(AddFlightBtn);
            panel4.Controls.Add(MaxPassText);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(68, 153);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 466);
            panel4.TabIndex = 4;
            // 
            // AddFlightBtn
            // 
            AddFlightBtn.Location = new Point(101, 139);
            AddFlightBtn.Name = "AddFlightBtn";
            AddFlightBtn.Size = new Size(83, 39);
            AddFlightBtn.TabIndex = 8;
            AddFlightBtn.Text = "Add Flight";
            AddFlightBtn.UseVisualStyleBackColor = true;
            AddFlightBtn.Click += button2_Click;
            // 
            // MaxPassText
            // 
            MaxPassText.Location = new Point(169, 82);
            MaxPassText.Name = "MaxPassText";
            MaxPassText.Size = new Size(100, 23);
            MaxPassText.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 85);
            label11.Name = "label11";
            label11.Size = new Size(123, 15);
            label11.TabIndex = 2;
            label11.Text = "Maximum Passengers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(89, 9);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 1;
            label4.Text = "Add Flight";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.MidnightBlue;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(81, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1444, 88);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "GBC Airlings Booking Information System (GABIS)";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(ResultsList);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(68, 625);
            panel5.Name = "panel5";
            panel5.Size = new Size(1069, 272);
            panel5.TabIndex = 5;
            // 
            // ResultsList
            // 
            ResultsList.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ResultsList.ForeColor = SystemColors.HotTrack;
            ResultsList.Location = new Point(249, 28);
            ResultsList.Name = "ResultsList";
            ResultsList.Size = new Size(791, 215);
            ResultsList.TabIndex = 10;
            ResultsList.Text = "";
            ResultsList.TextChanged += ResultsList_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(58, 100);
            label10.Name = "label10";
            label10.Size = new Size(137, 50);
            label10.TabIndex = 1;
            label10.Text = "Results";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1214, 928);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(richTextBox1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1230, 967);
            MinimumSize = new Size(1230, 967);
            Name = "Form1";
            Text = "GBC Airlines Booking Information System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private RichTextBox richTextBox1;
        private CheckBox AllFlightsCheckBox;
        private Label label5;
        private RichTextBox FlightList;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox AddCustPhoneText;
        private TextBox AddCustLNameText;
        private TextBox AddCustFNameText;
        private TextBox AddCustFlightNumText;
        private Label label9;
        private Panel panel5;
        private Label label10;
        private Label label11;
        private TextBox MaxPassText;
        private Button DelFlightNum;
        private TextBox DelFlightText;
        private Label label12;
        private Button AddFlightBtn;
        private Button DisplayFlightsBtn;
        private Button AddPassBtn;
        private RichTextBox ResultsList;
        private Panel panel6;
        private Button delCustomerBtn;
        private TextBox customerIDbox;
        private Label label13;
        private Label label14;
        private Button ListCustomerBtn;
        private Label label15;
    }
}