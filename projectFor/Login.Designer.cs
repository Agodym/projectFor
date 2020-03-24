namespace projectFor
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitBt = new System.Windows.Forms.Button();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.EmailLB = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.EnterBT = new System.Windows.Forms.Button();
            this.btsignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBt
            // 
            this.ExitBt.Location = new System.Drawing.Point(686, 295);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(64, 41);
            this.ExitBt.TabIndex = 0;
            this.ExitBt.Text = "Exit";
            this.ExitBt.UseVisualStyleBackColor = true;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(82, 12);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(180, 20);
            this.EmailTB.TabIndex = 1;
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Location = new System.Drawing.Point(12, 9);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(32, 13);
            this.EmailLB.TabIndex = 2;
            this.EmailLB.Text = "Email";
            // 
            // PasswordTB
            // 
            this.PasswordTB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PasswordTB.Location = new System.Drawing.Point(82, 54);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(180, 20);
            this.PasswordTB.TabIndex = 3;
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.Location = new System.Drawing.Point(12, 54);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(53, 13);
            this.PasswordLB.TabIndex = 4;
            this.PasswordLB.Text = "Password";
            // 
            // EnterBT
            // 
            this.EnterBT.Location = new System.Drawing.Point(286, 12);
            this.EnterBT.Name = "EnterBT";
            this.EnterBT.Size = new System.Drawing.Size(55, 24);
            this.EnterBT.TabIndex = 5;
            this.EnterBT.Text = "Enter";
            this.EnterBT.UseVisualStyleBackColor = true;
            this.EnterBT.Click += new System.EventHandler(this.EnterBT_Click);
            // 
            // btsignup
            // 
            this.btsignup.Location = new System.Drawing.Point(286, 54);
            this.btsignup.Name = "btsignup";
            this.btsignup.Size = new System.Drawing.Size(55, 23);
            this.btsignup.TabIndex = 6;
            this.btsignup.Text = "Sign up";
            this.btsignup.UseVisualStyleBackColor = true;
            this.btsignup.Click += new System.EventHandler(this.btsignup_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 86);
            this.Controls.Add(this.btsignup);
            this.Controls.Add(this.EnterBT);
            this.Controls.Add(this.PasswordLB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.ExitBt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBt;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label EmailLB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.Button EnterBT;
        private System.Windows.Forms.Button btsignup;
    }
}

