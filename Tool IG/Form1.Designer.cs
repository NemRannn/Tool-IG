namespace Tool_IG
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_UserIG = new System.Windows.Forms.TextBox();
            this.tb_PassIG = new System.Windows.Forms.TextBox();
            this.my_username = new System.Windows.Forms.Label();
            this.my_coins = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(12, 63);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(156, 20);
            this.tb_User.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NV,
            this.account_username,
            this.URL,
            this.massage});
            this.dataGridView1.Location = new System.Drawing.Point(15, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 301);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // tb_Pass
            // 
            this.tb_Pass.Location = new System.Drawing.Point(186, 63);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(156, 20);
            this.tb_Pass.TabIndex = 5;
            this.tb_Pass.UseSystemPasswordChar = true;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btStart.Location = new System.Drawing.Point(477, 26);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(81, 57);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.Red;
            this.btStop.Location = new System.Drawing.Point(477, 113);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(81, 57);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "UserName IG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password IG";
            // 
            // tb_UserIG
            // 
            this.tb_UserIG.Location = new System.Drawing.Point(12, 151);
            this.tb_UserIG.Name = "tb_UserIG";
            this.tb_UserIG.Size = new System.Drawing.Size(156, 20);
            this.tb_UserIG.TabIndex = 9;
            // 
            // tb_PassIG
            // 
            this.tb_PassIG.Location = new System.Drawing.Point(186, 151);
            this.tb_PassIG.Name = "tb_PassIG";
            this.tb_PassIG.Size = new System.Drawing.Size(156, 20);
            this.tb_PassIG.TabIndex = 10;
            this.tb_PassIG.UseSystemPasswordChar = true;
            // 
            // my_username
            // 
            this.my_username.AutoSize = true;
            this.my_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_username.ForeColor = System.Drawing.Color.Red;
            this.my_username.Location = new System.Drawing.Point(362, 67);
            this.my_username.Name = "my_username";
            this.my_username.Size = new System.Drawing.Size(85, 16);
            this.my_username.TabIndex = 12;
            this.my_username.Text = "User Name";
            // 
            // my_coins
            // 
            this.my_coins.AutoSize = true;
            this.my_coins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_coins.ForeColor = System.Drawing.Color.Red;
            this.my_coins.Location = new System.Drawing.Point(378, 155);
            this.my_coins.Name = "my_coins";
            this.my_coins.Size = new System.Drawing.Size(51, 16);
            this.my_coins.TabIndex = 13;
            this.my_coins.Text = "0 VND";
            // 
            // ID
            // 
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // NV
            // 
            this.NV.HeaderText = "Loại nhiệm vụ";
            this.NV.Name = "NV";
            this.NV.ReadOnly = true;
            // 
            // account_username
            // 
            this.account_username.HeaderText = "Tài khoản Instagram";
            this.account_username.Name = "account_username";
            this.account_username.ReadOnly = true;
            this.account_username.Width = 150;
            // 
            // URL
            // 
            this.URL.HeaderText = "Link nhiệm vụ";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            // 
            // massage
            // 
            this.massage.HeaderText = "Trạng thái";
            this.massage.Name = "massage";
            this.massage.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 541);
            this.Controls.Add(this.my_coins);
            this.Controls.Add(this.my_username);
            this.Controls.Add(this.tb_PassIG);
            this.Controls.Add(this.tb_UserIG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tool ig";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_UserIG;
        private System.Windows.Forms.TextBox tb_PassIG;
        private System.Windows.Forms.Label my_username;
        private System.Windows.Forms.Label my_coins;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn massage;
    }
}

