namespace project_Ayubo_1
{
    partial class Hire
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.selectedIdText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.loadData = new System.Windows.Forms.DataGridView();
            this.hireEndBox = new System.Windows.Forms.DateTimePicker();
            this.hireStartBox = new System.Windows.Forms.DateTimePicker();
            this.driverNameBox = new System.Windows.Forms.ComboBox();
            this.vechicleTypeBox = new System.Windows.Forms.ComboBox();
            this.hpNameBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.noOfDaysBox = new System.Windows.Forms.TextBox();
            this.TourTypeBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.HOCNameBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadData)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(546, 377);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 41);
            this.saveBtn.TabIndex = 30;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(408, 377);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(117, 41);
            this.updateBtn.TabIndex = 31;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(264, 377);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(117, 41);
            this.deleteBtn.TabIndex = 32;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // selectedIdText
            // 
            this.selectedIdText.AutoSize = true;
            this.selectedIdText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedIdText.Location = new System.Drawing.Point(105, 432);
            this.selectedIdText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedIdText.Name = "selectedIdText";
            this.selectedIdText.Size = new System.Drawing.Size(16, 17);
            this.selectedIdText.TabIndex = 29;
            this.selectedIdText.Text = "0";
            this.selectedIdText.Click += new System.EventHandler(this.selectedIdText_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 432);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "selected Id :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // loadData
            // 
            this.loadData.AllowUserToAddRows = false;
            this.loadData.AllowUserToDeleteRows = false;
            this.loadData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadData.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.loadData.Location = new System.Drawing.Point(16, 453);
            this.loadData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadData.Name = "loadData";
            this.loadData.ReadOnly = true;
            this.loadData.Size = new System.Drawing.Size(968, 184);
            this.loadData.TabIndex = 27;
            this.loadData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadData_CellClick);
            this.loadData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadData_CellContentClick);
            // 
            // hireEndBox
            // 
            this.hireEndBox.CustomFormat = "yyyy-MM-dd";
            this.hireEndBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hireEndBox.Location = new System.Drawing.Point(657, 223);
            this.hireEndBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hireEndBox.Name = "hireEndBox";
            this.hireEndBox.Size = new System.Drawing.Size(209, 22);
            this.hireEndBox.TabIndex = 26;
            // 
            // hireStartBox
            // 
            this.hireStartBox.CustomFormat = "yyyy-MM-dd";
            this.hireStartBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hireStartBox.Location = new System.Drawing.Point(657, 185);
            this.hireStartBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hireStartBox.Name = "hireStartBox";
            this.hireStartBox.Size = new System.Drawing.Size(209, 22);
            this.hireStartBox.TabIndex = 25;
            // 
            // driverNameBox
            // 
            this.driverNameBox.FormattingEnabled = true;
            this.driverNameBox.Location = new System.Drawing.Point(196, 263);
            this.driverNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.driverNameBox.Name = "driverNameBox";
            this.driverNameBox.Size = new System.Drawing.Size(305, 24);
            this.driverNameBox.TabIndex = 24;
            // 
            // vechicleTypeBox
            // 
            this.vechicleTypeBox.FormattingEnabled = true;
            this.vechicleTypeBox.Location = new System.Drawing.Point(196, 143);
            this.vechicleTypeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vechicleTypeBox.Name = "vechicleTypeBox";
            this.vechicleTypeBox.Size = new System.Drawing.Size(305, 24);
            this.vechicleTypeBox.TabIndex = 23;
            // 
            // hpNameBox
            // 
            this.hpNameBox.FormattingEnabled = true;
            this.hpNameBox.Location = new System.Drawing.Point(196, 182);
            this.hpNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hpNameBox.Name = "hpNameBox";
            this.hpNameBox.Size = new System.Drawing.Size(305, 24);
            this.hpNameBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hire End Date :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hire Start Date :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Driver Name :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "vechicle_Type :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hire Package Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 39);
            this.label6.TabIndex = 33;
            this.label6.Text = "Hire Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "No of Days :";
            // 
            // noOfDaysBox
            // 
            this.noOfDaysBox.Location = new System.Drawing.Point(657, 263);
            this.noOfDaysBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noOfDaysBox.Name = "noOfDaysBox";
            this.noOfDaysBox.Size = new System.Drawing.Size(208, 22);
            this.noOfDaysBox.TabIndex = 35;
            // 
            // TourTypeBox
            // 
            this.TourTypeBox.FormattingEnabled = true;
            this.TourTypeBox.Location = new System.Drawing.Point(657, 145);
            this.TourTypeBox.Margin = new System.Windows.Forms.Padding(4);
            this.TourTypeBox.Name = "TourTypeBox";
            this.TourTypeBox.Size = new System.Drawing.Size(208, 24);
            this.TourTypeBox.TabIndex = 37;
            this.TourTypeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(565, 147);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Tour Type :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // HOCNameBox
            // 
            this.HOCNameBox.FormattingEnabled = true;
            this.HOCNameBox.Location = new System.Drawing.Point(196, 221);
            this.HOCNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.HOCNameBox.Name = "HOCNameBox";
            this.HOCNameBox.Size = new System.Drawing.Size(305, 24);
            this.HOCNameBox.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 223);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Hire Other Charge Name :";
            // 
            // Hire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.HOCNameBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TourTypeBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.noOfDaysBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.selectedIdText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.hireEndBox);
            this.Controls.Add(this.hireStartBox);
            this.Controls.Add(this.driverNameBox);
            this.Controls.Add(this.vechicleTypeBox);
            this.Controls.Add(this.hpNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Hire";
            this.Text = "Hire";
            this.Load += new System.EventHandler(this.Hire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label selectedIdText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView loadData;
        private System.Windows.Forms.DateTimePicker hireEndBox;
        private System.Windows.Forms.DateTimePicker hireStartBox;
        private System.Windows.Forms.ComboBox driverNameBox;
        private System.Windows.Forms.ComboBox vechicleTypeBox;
        private System.Windows.Forms.ComboBox hpNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox noOfDaysBox;
        private System.Windows.Forms.ComboBox TourTypeBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox HOCNameBox;
        private System.Windows.Forms.Label label10;
    }
}