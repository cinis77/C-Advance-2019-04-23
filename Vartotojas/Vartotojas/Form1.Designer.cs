namespace Vartotojas
{
    partial class LogInPage
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SingUpB = new System.Windows.Forms.Button();
            this.LogInB = new System.Windows.Forms.Button();
            this.ExitB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName.Location = new System.Drawing.Point(143, 32);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(220, 29);
            this.UserName.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.Location = new System.Drawing.Point(143, 85);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(220, 29);
            this.Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // SingUpB
            // 
            this.SingUpB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SingUpB.Location = new System.Drawing.Point(232, 153);
            this.SingUpB.Name = "SingUpB";
            this.SingUpB.Size = new System.Drawing.Size(173, 54);
            this.SingUpB.TabIndex = 4;
            this.SingUpB.Text = "Sign Up";
            this.SingUpB.UseVisualStyleBackColor = true;
            this.SingUpB.Click += new System.EventHandler(this.SingUpB_Click);
            // 
            // LogInB
            // 
            this.LogInB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogInB.Location = new System.Drawing.Point(33, 153);
            this.LogInB.Name = "LogInB";
            this.LogInB.Size = new System.Drawing.Size(169, 53);
            this.LogInB.TabIndex = 5;
            this.LogInB.Text = "Login";
            this.LogInB.UseVisualStyleBackColor = true;
            this.LogInB.Click += new System.EventHandler(this.LogInB_Click);
            // 
            // ExitB
            // 
            this.ExitB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitB.Location = new System.Drawing.Point(143, 242);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(204, 69);
            this.ExitB.TabIndex = 6;
            this.ExitB.Text = "Exit";
            this.ExitB.UseVisualStyleBackColor = true;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 357);
            this.ControlBox = false;
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.LogInB);
            this.Controls.Add(this.SingUpB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SingUpB;
        private System.Windows.Forms.Button LogInB;
        private System.Windows.Forms.Button ExitB;
    }
}

