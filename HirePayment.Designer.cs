namespace project_Ayubo_1
{
    partial class HirePayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.selectedIdText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LoadData = new System.Windows.Forms.DataGridView();
            this.hireOtherChargeBox = new System.Windows.Forms.TextBox();
            this.DriverNameBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HireIDBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hirePaymentBasicCharge = new System.Windows.Forms.TextBox();
            this.BasciChargeBox = new System.Windows.Forms.Label();
            this.PaymentTypeBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.StartReadingBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.EndReadingBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CustomerNameBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HirePaymentDateBox = new System.Windows.Forms.DateTimePicker();
            this.endTimeBox = new System.Windows.Forms.TextBox();
            this.tourTypeBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.noOfHourBox = new System.Windows.Forms.TextBox();
            this.extraKMBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NoOfDaysBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoadData)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(308, 460);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(87, 36);
            this.deleteBtn.TabIndex = 37;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(415, 458);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(87, 38);
            this.updateBtn.TabIndex = 36;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(518, 460);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 37);
            this.saveBtn.TabIndex = 35;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // selectedIdText
            // 
            this.selectedIdText.AutoSize = true;
            this.selectedIdText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedIdText.Location = new System.Drawing.Point(100, 479);
            this.selectedIdText.Name = "selectedIdText";
            this.selectedIdText.Size = new System.Drawing.Size(16, 17);
            this.selectedIdText.TabIndex = 34;
            this.selectedIdText.Text = "0";
            this.selectedIdText.Click += new System.EventHandler(this.selectedIdText_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "selected Id :";
            // 
            // LoadData
            // 
            this.LoadData.AllowUserToAddRows = false;
            this.LoadData.AllowUserToDeleteRows = false;
            this.LoadData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LoadData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoadData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoadData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.LoadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoadData.Location = new System.Drawing.Point(12, 510);
            this.LoadData.Name = "LoadData";
            this.LoadData.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadData.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LoadData.Size = new System.Drawing.Size(976, 130);
            this.LoadData.TabIndex = 32;
            this.LoadData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadData_CellClick);
            this.LoadData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadData_CellContentClick);
            // 
            // hireOtherChargeBox
            // 
            this.hireOtherChargeBox.Location = new System.Drawing.Point(160, 308);
            this.hireOtherChargeBox.Name = "hireOtherChargeBox";
            this.hireOtherChargeBox.Size = new System.Drawing.Size(219, 25);
            this.hireOtherChargeBox.TabIndex = 29;
            // 
            // DriverNameBox
            // 
            this.DriverNameBox.FormattingEnabled = true;
            this.DriverNameBox.Location = new System.Drawing.Point(160, 263);
            this.DriverNameBox.Name = "DriverNameBox";
            this.DriverNameBox.Size = new System.Drawing.Size(219, 25);
            this.DriverNameBox.TabIndex = 28;
            this.DriverNameBox.SelectedIndexChanged += new System.EventHandler(this.hireIdBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Driver Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Customer Name :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hire Other Charge :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "Hire Payment Details ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Payment Type :";
            // 
            // HireIDBox
            // 
            this.HireIDBox.FormattingEnabled = true;
            this.HireIDBox.Location = new System.Drawing.Point(160, 133);
            this.HireIDBox.Name = "HireIDBox";
            this.HireIDBox.Size = new System.Drawing.Size(219, 25);
            this.HireIDBox.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Hire ID :";
            // 
            // hirePaymentBasicCharge
            // 
            this.hirePaymentBasicCharge.Location = new System.Drawing.Point(160, 175);
            this.hirePaymentBasicCharge.Name = "hirePaymentBasicCharge";
            this.hirePaymentBasicCharge.Size = new System.Drawing.Size(219, 25);
            this.hirePaymentBasicCharge.TabIndex = 46;
            // 
            // BasciChargeBox
            // 
            this.BasciChargeBox.AutoSize = true;
            this.BasciChargeBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasciChargeBox.Location = new System.Drawing.Point(46, 178);
            this.BasciChargeBox.Name = "BasciChargeBox";
            this.BasciChargeBox.Size = new System.Drawing.Size(108, 17);
            this.BasciChargeBox.TabIndex = 45;
            this.BasciChargeBox.Text = "Basic Amount :";
            // 
            // PaymentTypeBox
            // 
            this.PaymentTypeBox.Location = new System.Drawing.Point(544, 335);
            this.PaymentTypeBox.Name = "PaymentTypeBox";
            this.PaymentTypeBox.Size = new System.Drawing.Size(219, 25);
            this.PaymentTypeBox.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(396, 375);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 17);
            this.label15.TabIndex = 54;
            this.label15.Text = "Hire Payment Date :";
            // 
            // StartReadingBox
            // 
            this.StartReadingBox.Location = new System.Drawing.Point(544, 178);
            this.StartReadingBox.Name = "StartReadingBox";
            this.StartReadingBox.Size = new System.Drawing.Size(219, 25);
            this.StartReadingBox.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(432, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 17);
            this.label16.TabIndex = 56;
            this.label16.Text = "Start Reading :";
            // 
            // EndReadingBox
            // 
            this.EndReadingBox.Location = new System.Drawing.Point(544, 220);
            this.EndReadingBox.Name = "EndReadingBox";
            this.EndReadingBox.Size = new System.Drawing.Size(219, 25);
            this.EndReadingBox.TabIndex = 59;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(437, 220);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 17);
            this.label17.TabIndex = 58;
            this.label17.Text = "End Reading :";
            // 
            // CustomerNameBox
            // 
            this.CustomerNameBox.FormattingEnabled = true;
            this.CustomerNameBox.Location = new System.Drawing.Point(160, 221);
            this.CustomerNameBox.Name = "CustomerNameBox";
            this.CustomerNameBox.Size = new System.Drawing.Size(219, 25);
            this.CustomerNameBox.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "startTime :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 66;
            this.label9.Text = "EndTime :";
            // 
            // HirePaymentDateBox
            // 
            this.HirePaymentDateBox.CustomFormat = "yyyy-MM-dd";
            this.HirePaymentDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HirePaymentDateBox.Location = new System.Drawing.Point(544, 375);
            this.HirePaymentDateBox.Name = "HirePaymentDateBox";
            this.HirePaymentDateBox.Size = new System.Drawing.Size(219, 25);
            this.HirePaymentDateBox.TabIndex = 55;
            // 
            // endTimeBox
            // 
            this.endTimeBox.Location = new System.Drawing.Point(160, 349);
            this.endTimeBox.Name = "endTimeBox";
            this.endTimeBox.Size = new System.Drawing.Size(219, 25);
            this.endTimeBox.TabIndex = 69;
            // 
            // tourTypeBox
            // 
            this.tourTypeBox.Location = new System.Drawing.Point(160, 392);
            this.tourTypeBox.Name = "tourTypeBox";
            this.tourTypeBox.Size = new System.Drawing.Size(219, 25);
            this.tourTypeBox.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(437, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 72;
            this.label12.Text = "No Of Hour :";
            // 
            // noOfHourBox
            // 
            this.noOfHourBox.Location = new System.Drawing.Point(544, 300);
            this.noOfHourBox.Name = "noOfHourBox";
            this.noOfHourBox.Size = new System.Drawing.Size(219, 25);
            this.noOfHourBox.TabIndex = 73;
            // 
            // extraKMBox
            // 
            this.extraKMBox.Location = new System.Drawing.Point(544, 261);
            this.extraKMBox.Name = "extraKMBox";
            this.extraKMBox.Size = new System.Drawing.Size(219, 25);
            this.extraKMBox.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Extra KM Charge :";
            // 
            // NoOfDaysBox
            // 
            this.NoOfDaysBox.Location = new System.Drawing.Point(544, 136);
            this.NoOfDaysBox.Name = "NoOfDaysBox";
            this.NoOfDaysBox.Size = new System.Drawing.Size(219, 25);
            this.NoOfDaysBox.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(432, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 76;
            this.label11.Text = "No Of Days :";
            // 
            // HirePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.NoOfDaysBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.extraKMBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noOfHourBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tourTypeBox);
            this.Controls.Add(this.endTimeBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerNameBox);
            this.Controls.Add(this.EndReadingBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.StartReadingBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.HirePaymentDateBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PaymentTypeBox);
            this.Controls.Add(this.hirePaymentBasicCharge);
            this.Controls.Add(this.BasciChargeBox);
            this.Controls.Add(this.HireIDBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.selectedIdText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.hireOtherChargeBox);
            this.Controls.Add(this.DriverNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HirePayment";
            this.Text = "HirePayment";
            this.Load += new System.EventHandler(this.HirePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label selectedIdText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView LoadData;
        private System.Windows.Forms.TextBox hireOtherChargeBox;
        private System.Windows.Forms.ComboBox DriverNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox HireIDBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox hirePaymentBasicCharge;
        private System.Windows.Forms.Label BasciChargeBox;
        private System.Windows.Forms.TextBox PaymentTypeBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox StartReadingBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox EndReadingBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CustomerNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker HirePaymentDateBox;
        private System.Windows.Forms.TextBox endTimeBox;
        private System.Windows.Forms.TextBox tourTypeBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox noOfHourBox;
        private System.Windows.Forms.TextBox extraKMBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoOfDaysBox;
        private System.Windows.Forms.Label label11;
    }
}