namespace project_Ayubo_1
{
    partial class Rent
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
            this.rentEndBox = new System.Windows.Forms.DateTimePicker();
            this.rentStartBox = new System.Windows.Forms.DateTimePicker();
            this.selectedIdText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loadData = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.driverNameBox = new System.Windows.Forms.ComboBox();
            this.vechicleNoBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rentDayBox = new System.Windows.Forms.TextBox();
            this.RentIDTypeBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadData)).BeginInit();
            this.SuspendLayout();
            // 
            // rentEndBox
            // 
            this.rentEndBox.CustomFormat = "yyyy-MM-dd";
            this.rentEndBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentEndBox.Location = new System.Drawing.Point(372, 196);
            this.rentEndBox.Margin = new System.Windows.Forms.Padding(4);
            this.rentEndBox.Name = "rentEndBox";
            this.rentEndBox.Size = new System.Drawing.Size(329, 22);
            this.rentEndBox.TabIndex = 26;
            // 
            // rentStartBox
            // 
            this.rentStartBox.CustomFormat = "yyyy-MM-dd";
            this.rentStartBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentStartBox.Location = new System.Drawing.Point(372, 154);
            this.rentStartBox.Margin = new System.Windows.Forms.Padding(4);
            this.rentStartBox.Name = "rentStartBox";
            this.rentStartBox.Size = new System.Drawing.Size(329, 22);
            this.rentStartBox.TabIndex = 25;
            // 
            // selectedIdText
            // 
            this.selectedIdText.AutoSize = true;
            this.selectedIdText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedIdText.Location = new System.Drawing.Point(107, 375);
            this.selectedIdText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedIdText.Name = "selectedIdText";
            this.selectedIdText.Size = new System.Drawing.Size(16, 17);
            this.selectedIdText.TabIndex = 24;
            this.selectedIdText.Text = "0";
            this.selectedIdText.Click += new System.EventHandler(this.selectedIdText_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "selected Id :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // loadData
            // 
            this.loadData.AllowUserToAddRows = false;
            this.loadData.AllowUserToDeleteRows = false;
            this.loadData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadData.Location = new System.Drawing.Point(16, 399);
            this.loadData.Margin = new System.Windows.Forms.Padding(4);
            this.loadData.Name = "loadData";
            this.loadData.ReadOnly = true;
            this.loadData.Size = new System.Drawing.Size(968, 239);
            this.loadData.TabIndex = 22;
            this.loadData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadData_CellClick);
            this.loadData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadData_CellContentClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(560, 325);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 41);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(436, 325);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(117, 41);
            this.updateBtn.TabIndex = 20;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(304, 325);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(117, 41);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // driverNameBox
            // 
            this.driverNameBox.FormattingEnabled = true;
            this.driverNameBox.Location = new System.Drawing.Point(372, 115);
            this.driverNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.driverNameBox.Name = "driverNameBox";
            this.driverNameBox.Size = new System.Drawing.Size(329, 24);
            this.driverNameBox.TabIndex = 18;
            // 
            // vechicleNoBox
            // 
            this.vechicleNoBox.FormattingEnabled = true;
            this.vechicleNoBox.Location = new System.Drawing.Point(372, 69);
            this.vechicleNoBox.Margin = new System.Windows.Forms.Padding(4);
            this.vechicleNoBox.Name = "vechicleNoBox";
            this.vechicleNoBox.Size = new System.Drawing.Size(329, 24);
            this.vechicleNoBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rent End Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rent Start Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Driver Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vechicle Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 39);
            this.label6.TabIndex = 27;
            this.label6.Text = "Rent Details";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Rent Days :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rentDayBox
            // 
            this.rentDayBox.Location = new System.Drawing.Point(372, 266);
            this.rentDayBox.Margin = new System.Windows.Forms.Padding(4);
            this.rentDayBox.Name = "rentDayBox";
            this.rentDayBox.Size = new System.Drawing.Size(132, 22);
            this.rentDayBox.TabIndex = 29;
            this.rentDayBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RentIDTypeBox
            // 
            this.RentIDTypeBox.FormattingEnabled = true;
            this.RentIDTypeBox.Location = new System.Drawing.Point(372, 231);
            this.RentIDTypeBox.Margin = new System.Windows.Forms.Padding(4);
            this.RentIDTypeBox.Name = "RentIDTypeBox";
            this.RentIDTypeBox.Size = new System.Drawing.Size(329, 24);
            this.RentIDTypeBox.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(249, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Rent Type :";
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.RentIDTypeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rentDayBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rentEndBox);
            this.Controls.Add(this.rentStartBox);
            this.Controls.Add(this.selectedIdText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.driverNameBox);
            this.Controls.Add(this.vechicleNoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker rentEndBox;
        private System.Windows.Forms.DateTimePicker rentStartBox;
        private System.Windows.Forms.Label selectedIdText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView loadData;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.ComboBox driverNameBox;
        private System.Windows.Forms.ComboBox vechicleNoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rentDayBox;
        private System.Windows.Forms.ComboBox RentIDTypeBox;
        private System.Windows.Forms.Label label8;
    }
}