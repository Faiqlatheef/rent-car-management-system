namespace project_Ayubo_1
{
    partial class HirePacakges
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.selectedIdText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoadData = new System.Windows.Forms.DataGridView();
            this.HPNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HPAmountBox = new System.Windows.Forms.TextBox();
            this.HPMinKMBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HPMixKMBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HPMixHourBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoadData)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(198, 353);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(117, 41);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(336, 353);
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
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(469, 353);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 41);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // selectedIdText
            // 
            this.selectedIdText.AutoSize = true;
            this.selectedIdText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedIdText.Location = new System.Drawing.Point(108, 414);
            this.selectedIdText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedIdText.Name = "selectedIdText";
            this.selectedIdText.Size = new System.Drawing.Size(16, 17);
            this.selectedIdText.TabIndex = 21;
            this.selectedIdText.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 415);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "selected Id :";
            // 
            // LoadData
            // 
            this.LoadData.AllowUserToAddRows = false;
            this.LoadData.AllowUserToDeleteRows = false;
            this.LoadData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LoadData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoadData.Location = new System.Drawing.Point(16, 436);
            this.LoadData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadData.Name = "LoadData";
            this.LoadData.ReadOnly = true;
            this.LoadData.Size = new System.Drawing.Size(891, 201);
            this.LoadData.TabIndex = 19;
            this.LoadData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadData_CellClick);
            this.LoadData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadData_CellContentClick);
            // 
            // HPNameBox
            // 
            this.HPNameBox.Location = new System.Drawing.Point(336, 122);
            this.HPNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HPNameBox.Name = "HPNameBox";
            this.HPNameBox.Size = new System.Drawing.Size(257, 22);
            this.HPNameBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hire Packages Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 39);
            this.label1.TabIndex = 25;
            this.label1.Text = "Hire Package Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hire Packages Amount :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // HPAmountBox
            // 
            this.HPAmountBox.Location = new System.Drawing.Point(336, 164);
            this.HPAmountBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HPAmountBox.Name = "HPAmountBox";
            this.HPAmountBox.Size = new System.Drawing.Size(257, 22);
            this.HPAmountBox.TabIndex = 27;
            // 
            // HPMinKMBox
            // 
            this.HPMinKMBox.Location = new System.Drawing.Point(336, 205);
            this.HPMinKMBox.Margin = new System.Windows.Forms.Padding(4);
            this.HPMinKMBox.Name = "HPMinKMBox";
            this.HPMinKMBox.Size = new System.Drawing.Size(257, 22);
            this.HPMinKMBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Hire Packages MinKM :";
            // 
            // HPMixKMBox
            // 
            this.HPMixKMBox.Location = new System.Drawing.Point(336, 247);
            this.HPMixKMBox.Margin = new System.Windows.Forms.Padding(4);
            this.HPMixKMBox.Name = "HPMixKMBox";
            this.HPMixKMBox.Size = new System.Drawing.Size(257, 22);
            this.HPMixKMBox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Hire Packages MixKM :";
            // 
            // HPMixHourBox
            // 
            this.HPMixHourBox.Location = new System.Drawing.Point(336, 284);
            this.HPMixHourBox.Margin = new System.Windows.Forms.Padding(4);
            this.HPMixHourBox.Name = "HPMixHourBox";
            this.HPMixHourBox.Size = new System.Drawing.Size(257, 22);
            this.HPMixHourBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 287);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Hire Packages MixHour :";
            // 
            // HirePacakges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.HPMixHourBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HPMixKMBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HPMinKMBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HPAmountBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.selectedIdText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.HPNameBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HirePacakges";
            this.Text = "HirePacakges";
            this.Load += new System.EventHandler(this.HirePacakges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label selectedIdText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView LoadData;
        private System.Windows.Forms.TextBox HPNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HPAmountBox;
        private System.Windows.Forms.TextBox HPMinKMBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HPMixKMBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HPMixHourBox;
        private System.Windows.Forms.Label label7;
    }
}