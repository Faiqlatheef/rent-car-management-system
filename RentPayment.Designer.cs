namespace project_Ayubo_1
{
    partial class RentPayment
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
            this.rentPaymentDateBox = new System.Windows.Forms.DateTimePicker();
            this.selectedIdText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadDate = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.RPDriverChargeBox = new System.Windows.Forms.TextBox();
            this.rpBasicChargeBox = new System.Windows.Forms.TextBox();
            this.customerNameBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RentIdBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RentTypeBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rpTypeBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoadDate)).BeginInit();
            this.SuspendLayout();
            // 
            // rentPaymentDateBox
            // 
            this.rentPaymentDateBox.CustomFormat = "yyyy-MM-dd";
            this.rentPaymentDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentPaymentDateBox.Location = new System.Drawing.Point(551, 200);
            this.rentPaymentDateBox.Name = "rentPaymentDateBox";
            this.rentPaymentDateBox.Size = new System.Drawing.Size(191, 25);
            this.rentPaymentDateBox.TabIndex = 28;
            // 
            // selectedIdText
            // 
            this.selectedIdText.AutoSize = true;
            this.selectedIdText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedIdText.Location = new System.Drawing.Point(98, 397);
            this.selectedIdText.Name = "selectedIdText";
            this.selectedIdText.Size = new System.Drawing.Size(16, 17);
            this.selectedIdText.TabIndex = 27;
            this.selectedIdText.Text = "0";
            this.selectedIdText.Click += new System.EventHandler(this.selectedIdText_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "selected Id :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LoadDate
            // 
            this.LoadDate.AllowUserToAddRows = false;
            this.LoadDate.AllowUserToDeleteRows = false;
            this.LoadDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LoadDate.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoadDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoadDate.Location = new System.Drawing.Point(12, 417);
            this.LoadDate.Name = "LoadDate";
            this.LoadDate.ReadOnly = true;
            this.LoadDate.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.LoadDate.Size = new System.Drawing.Size(714, 207);
            this.LoadDate.TabIndex = 25;
            this.LoadDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadDate_CellClick);
            this.LoadDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadDate_CellContentClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(501, 342);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 33);
            this.saveBtn.TabIndex = 24;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(396, 342);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(88, 33);
            this.updateBtn.TabIndex = 23;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(285, 342);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(88, 33);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // RPDriverChargeBox
            // 
            this.RPDriverChargeBox.Location = new System.Drawing.Point(148, 238);
            this.RPDriverChargeBox.Name = "RPDriverChargeBox";
            this.RPDriverChargeBox.Size = new System.Drawing.Size(244, 25);
            this.RPDriverChargeBox.TabIndex = 21;
            // 
            // rpBasicChargeBox
            // 
            this.rpBasicChargeBox.Location = new System.Drawing.Point(148, 157);
            this.rpBasicChargeBox.Name = "rpBasicChargeBox";
            this.rpBasicChargeBox.Size = new System.Drawing.Size(244, 25);
            this.rpBasicChargeBox.TabIndex = 20;
            this.rpBasicChargeBox.TextChanged += new System.EventHandler(this.rentChargeBox_TextChanged);
            // 
            // customerNameBox
            // 
            this.customerNameBox.FormattingEnabled = true;
            this.customerNameBox.Location = new System.Drawing.Point(551, 122);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(191, 25);
            this.customerNameBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "RP Driver Charge :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rent Payment Date :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rent basic Charge :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customer  Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 39);
            this.label6.TabIndex = 29;
            this.label6.Text = "Rent Payment Details";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Rent ID :";
            // 
            // RentIdBox
            // 
            this.RentIdBox.FormattingEnabled = true;
            this.RentIdBox.Location = new System.Drawing.Point(148, 119);
            this.RentIdBox.Name = "RentIdBox";
            this.RentIdBox.Size = new System.Drawing.Size(244, 25);
            this.RentIdBox.TabIndex = 33;
            this.RentIdBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Rent Type :";
            // 
            // RentTypeBox
            // 
            this.RentTypeBox.FormattingEnabled = true;
            this.RentTypeBox.Items.AddRange(new object[] {
            "driver"});
            this.RentTypeBox.Location = new System.Drawing.Point(148, 197);
            this.RentTypeBox.Name = "RentTypeBox";
            this.RentTypeBox.Size = new System.Drawing.Size(244, 25);
            this.RentTypeBox.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Payment Type :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rpTypeBox
            // 
            this.rpTypeBox.Location = new System.Drawing.Point(551, 162);
            this.rpTypeBox.Name = "rpTypeBox";
            this.rpTypeBox.Size = new System.Drawing.Size(191, 25);
            this.rpTypeBox.TabIndex = 39;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(551, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 25);
            this.textBox1.TabIndex = 41;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(411, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "RP Driver Charge :";
            // 
            // RentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rpTypeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RentTypeBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RentIdBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rentPaymentDateBox);
            this.Controls.Add(this.selectedIdText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoadDate);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.RPDriverChargeBox);
            this.Controls.Add(this.rpBasicChargeBox);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentPayment";
            this.Text = "RentPayment";
            this.Load += new System.EventHandler(this.RentPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker rentPaymentDateBox;
        private System.Windows.Forms.Label selectedIdText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView LoadDate;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox RPDriverChargeBox;
        private System.Windows.Forms.TextBox rpBasicChargeBox;
        private System.Windows.Forms.ComboBox customerNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox RentIdBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RentTypeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rpTypeBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
    }
}