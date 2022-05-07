namespace RTiPPO
{
    partial class Auth
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
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.LogIn = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(70, 90);
            this.LoginText.Name = "LoginText";
            this.LoginText.PlaceholderText = "Логин";
            this.LoginText.Size = new System.Drawing.Size(124, 23);
            this.LoginText.TabIndex = 0;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(70, 122);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '●';
            this.PasswordText.PlaceholderText = "Пароль";
            this.PasswordText.Size = new System.Drawing.Size(124, 23);
            this.PasswordText.TabIndex = 1;
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(93, 158);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 23);
            this.LogIn.TabIndex = 2;
            this.LogIn.Text = "Войти";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.BackColor = System.Drawing.Color.IndianRed;
            this.CloseApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseApp.Location = new System.Drawing.Point(231, 12);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(26, 27);
            this.CloseApp.TabIndex = 3;
            this.CloseApp.Text = "x";
            this.CloseApp.UseVisualStyleBackColor = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(83, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вход";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.Label label2;
    }
}