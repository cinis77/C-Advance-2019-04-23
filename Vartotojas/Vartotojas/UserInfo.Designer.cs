namespace Vartotojas
{
    partial class UserInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VardasText = new System.Windows.Forms.TextBox();
            this.PavardeText = new System.Windows.Forms.TextBox();
            this.AboutText = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 296);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VardasText
            // 
            this.VardasText.Location = new System.Drawing.Point(747, 31);
            this.VardasText.Name = "VardasText";
            this.VardasText.Size = new System.Drawing.Size(146, 29);
            this.VardasText.TabIndex = 1;
            // 
            // PavardeText
            // 
            this.PavardeText.Location = new System.Drawing.Point(747, 87);
            this.PavardeText.Name = "PavardeText";
            this.PavardeText.Size = new System.Drawing.Size(146, 29);
            this.PavardeText.TabIndex = 2;
            // 
            // AboutText
            // 
            this.AboutText.Location = new System.Drawing.Point(747, 153);
            this.AboutText.Multiline = true;
            this.AboutText.Name = "AboutText";
            this.AboutText.Size = new System.Drawing.Size(267, 379);
            this.AboutText.TabIndex = 3;
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(1152, 31);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(168, 29);
            this.userNameText.TabIndex = 4;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(1152, 87);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = 'A';
            this.PasswordText.Size = new System.Drawing.Size(168, 29);
            this.PasswordText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pavarde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1036, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1041, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apie";
            // 
            // RegisterB
            // 
            this.RegisterB.Location = new System.Drawing.Point(1198, 516);
            this.RegisterB.Name = "RegisterB";
            this.RegisterB.Size = new System.Drawing.Size(138, 69);
            this.RegisterB.TabIndex = 11;
            this.RegisterB.Text = "Registruoti";
            this.RegisterB.UseVisualStyleBackColor = true;
            this.RegisterB.Click += new System.EventHandler(this.RegisterB_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 608);
            this.Controls.Add(this.RegisterB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.AboutText);
            this.Controls.Add(this.PavardeText);
            this.Controls.Add(this.VardasText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserInfo";
            this.Text = "UserInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox VardasText;
        private System.Windows.Forms.TextBox PavardeText;
        private System.Windows.Forms.TextBox AboutText;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterB;
    }
}