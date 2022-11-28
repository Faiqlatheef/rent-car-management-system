namespace project_Ayubo_1
{
    partial class hireOtherCharge
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
            this.HOCNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectedIdText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loadData = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HOCAmountPerKMBox = new System.Windows.Forms.TextBox();
            this.HOCAmountPerHourBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadData)).BeginInit();
            this.SuspendLayout();
            // 
            // HOCNameBox
            // 
            this.HOCNameBox.Location = new System.Drawing.Point(375, 149);
            this.HOCNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.HOCNameBox.Name = "HOCNameBox";
            this.HOCNameBox.Size = new System.Drawing.Size(311, 22);
            this.HOCNameBox.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 39);
            this.label6.TabIndex = 44;
            this.label6.Text = "Hire Other Charge";
            // 
            // selectedIdText
            // 
            this.selectedIdText.AutoSize = true;
            this.selectedIdText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedIdText.Location = new System.Drawing.Point(100, 379);
            this.selectedIdText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedIdText.Name = "selectedIdText";
            this.selectedIdText.Size = new System.Drawing.Size(16, 17);
            this.selectedIdText.TabIndex = 41;
            this.selectedIdText.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 379);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "selected Id :";
            // 
            // loadData
            // 
            this.loadData.AllowUserToAddRows = false;
            this.loadData.AllowUserToDeleteRows = false;
            this.loadData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadData.Location = new System.Drawing.Point(8, 400);
            this.loadData.Margin = new System.Windows.Forms.Padding(4);
            this.loadData.Name = "loadData";
            this.loadData.ReadOnly = true;
            this.loadData.Size = new System.Drawing.Size(822, 239);
            this.loadData.TabIndex = 39;
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(569, 312);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 41);
            this.saveBtn.TabIndex = 38;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(445, 312);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(117, 41);
            this.updateBtn.TabIndex = 37;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(313, 312);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(117, 41);
            this.DeleteBtn.TabIndex = 36;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "HOC Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "HOC Amount PerHour :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "HOC Amount PerKM :";
            // 
            // HOCAmountPerKMBox
            // 
            this.HOCAmountPerKMBox.Location = new System.Drawing.Point(375, 187);
            this.HOCAmountPerKMBox.Margin = new System.Windows.Forms.Padding(4);
            this.HOCAmountPerKMBox.Name = "HOCAmountPerKMBox";
            this.HOCAmountPerKMBox.Size = new System.Drawing.Size(311, 22);
            this.HOCAmountPerKMBox.TabIndex = 48;
            // 
            // HOCAmountPerHourBox
            // 
            this.HOCAmountPerHourBox.Location = new System.Drawing.Point(375, 227);
            this.HOCAmountPerHourBox.Margin = new System.Windows.Forms.Padding(4);
            this.HOCAmountPerHourBox.Name = "HOCAmountPerHourBox";
            this.HOCAmountPerHourBox.Size = new System.Drawing.Size(311, 22);
            this.HOCAmountPerHourBox.TabIndex = 49;
            // 
            // hireOtherCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.HOCAmountPerHourBox);
            this.Controls.Add(this.HOCAmountPerKMBox);
            this.Controls.Add(this.HOCNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectedIdText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hireOtherCharge";
            this.Text = "hireOtherCharge";
            this.Load += new System.EventHandler(this.hireOtherCharge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HOCNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label selectedIdText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView loadData;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HOCAmountPerKMBox;
        private System.Windows.Forms.TextBox HOCAmountPerHourBox;

    }
}