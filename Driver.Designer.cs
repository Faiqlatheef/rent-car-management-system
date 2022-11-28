namespace project_Ayubo_1
{
    partial class Driver
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
            this.selectedIdText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadData = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.driverRentBox = new System.Windows.Forms.TextBox();
            this.dreiverLicenceNoBox = new System.Windows.Forms.TextBox();
            this.driverTelenoBox = new System.Windows.Forms.TextBox();
            this.driverAddressBox = new System.Windows.Forms.TextBox();
            this.driverNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.driverOverNightChargeBox = new System.Windows.Forms.TextBox();
            this.driverWaitingChargeBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadData)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedIdText
            // 
            this.selectedIdText.AutoSize = true;
            this.selectedIdText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedIdText.Location = new System.Drawing.Point(108, 380);
            this.selectedIdText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedIdText.Name = "selectedIdText";
            this.selectedIdText.Size = new System.Drawing.Size(16, 17);
            this.selectedIdText.TabIndex = 27;
            this.selectedIdText.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "selected Id :";
            // 
            // loadData
            // 
            this.loadData.AllowUserToAddRows = false;
            this.loadData.AllowUserToDeleteRows = false;
            this.loadData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadData.Location = new System.Drawing.Point(16, 405);
            this.loadData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadData.Name = "loadData";
            this.loadData.ReadOnly = true;
            this.loadData.Size = new System.Drawing.Size(968, 233);
            this.loadData.TabIndex = 25;
            this.loadData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadData_CellClick);
            this.loadData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadData_CellContentClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(280, 322);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(117, 41);
            this.DeleteBtn.TabIndex = 24;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(407, 322);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(117, 41);
            this.updateBtn.TabIndex = 23;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(529, 322);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 41);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // driverRentBox
            // 
            this.driverRentBox.Location = new System.Drawing.Point(691, 171);
            this.driverRentBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.driverRentBox.Name = "driverRentBox";
            this.driverRentBox.Size = new System.Drawing.Size(215, 22);
            this.driverRentBox.TabIndex = 21;
            // 
            // dreiverLicenceNoBox
            // 
            this.dreiverLicenceNoBox.Location = new System.Drawing.Point(691, 133);
            this.dreiverLicenceNoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dreiverLicenceNoBox.Name = "dreiverLicenceNoBox";
            this.dreiverLicenceNoBox.Size = new System.Drawing.Size(215, 22);
            this.dreiverLicenceNoBox.TabIndex = 20;
            // 
            // driverTelenoBox
            // 
            this.driverTelenoBox.Location = new System.Drawing.Point(169, 209);
            this.driverTelenoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.driverTelenoBox.Name = "driverTelenoBox";
            this.driverTelenoBox.Size = new System.Drawing.Size(289, 22);
            this.driverTelenoBox.TabIndex = 19;
            // 
            // driverAddressBox
            // 
            this.driverAddressBox.Location = new System.Drawing.Point(169, 174);
            this.driverAddressBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.driverAddressBox.Name = "driverAddressBox";
            this.driverAddressBox.Size = new System.Drawing.Size(289, 22);
            this.driverAddressBox.TabIndex = 18;
            // 
            // driverNameBox
            // 
            this.driverNameBox.Location = new System.Drawing.Point(169, 135);
            this.driverNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.driverNameBox.Name = "driverNameBox";
            this.driverNameBox.Size = new System.Drawing.Size(289, 22);
            this.driverNameBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Driver Licence No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(584, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Driver Rate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Driver Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Driver Telephone No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Driver Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 39);
            this.label7.TabIndex = 28;
            this.label7.Text = "Driver Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Driver Over Night Charge :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(508, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Driver Waiting Charge :";
            // 
            // driverOverNightChargeBox
            // 
            this.driverOverNightChargeBox.Location = new System.Drawing.Point(695, 244);
            this.driverOverNightChargeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.driverOverNightChargeBox.Name = "driverOverNightChargeBox";
            this.driverOverNightChargeBox.Size = new System.Drawing.Size(211, 22);
            this.driverOverNightChargeBox.TabIndex = 31;
            // 
            // driverWaitingChargeBox
            // 
            this.driverWaitingChargeBox.Location = new System.Drawing.Point(695, 207);
            this.driverWaitingChargeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.driverWaitingChargeBox.Name = "driverWaitingChargeBox";
            this.driverWaitingChargeBox.Size = new System.Drawing.Size(211, 22);
            this.driverWaitingChargeBox.TabIndex = 32;
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.driverWaitingChargeBox);
            this.Controls.Add(this.driverOverNightChargeBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectedIdText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.driverRentBox);
            this.Controls.Add(this.dreiverLicenceNoBox);
            this.Controls.Add(this.driverTelenoBox);
            this.Controls.Add(this.driverAddressBox);
            this.Controls.Add(this.driverNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Driver";
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.Driver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectedIdText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView loadData;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox driverRentBox;
        private System.Windows.Forms.TextBox dreiverLicenceNoBox;
        private System.Windows.Forms.TextBox driverTelenoBox;
        private System.Windows.Forms.TextBox driverAddressBox;
        private System.Windows.Forms.TextBox driverNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox driverOverNightChargeBox;
        private System.Windows.Forms.TextBox driverWaitingChargeBox;
    }
}