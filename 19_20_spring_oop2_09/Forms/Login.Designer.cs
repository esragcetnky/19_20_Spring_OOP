namespace _19_20_spring_oop2_09.Forms
{
    partial class Login
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.rememberMe = new System.Windows.Forms.CheckBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(130, 102);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(79, 17);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name";
            this.userNameLabel.UseMnemonic = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(130, 152);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(331, 251);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(96, 38);
            this.register.TabIndex = 3;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += Register_Click;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(215, 99);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(212, 22);
            this.userName.TabIndex = 4;
            this.userName.KeyPress += UserName_KeyPress;
            this.userName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(215, 149);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(212, 22);
            this.password.TabIndex = 5;
            this.password.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.password.KeyPress += Password_KeyPress;

            // 
            // rememberMe
            // 
            this.rememberMe.AutoSize = true;
            this.rememberMe.Location = new System.Drawing.Point(215, 207);
            this.rememberMe.Name = "rememberMe";
            this.rememberMe.Size = new System.Drawing.Size(122, 21);
            this.rememberMe.TabIndex = 6;
            this.rememberMe.Text = "Remember Me";
            this.rememberMe.UseVisualStyleBackColor = true;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(215, 251);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(90, 38);
            this.loginbutton.TabIndex = 7;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += Login_Click;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.rememberMe);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.register);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Name = "Login";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.FormClosing += Login_FormClosing;
            this.PerformLayout();

        }

        

        private void Password_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)System.Windows.Forms.Keys.Space);
        }
        private void UserName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)System.Windows.Forms.Keys.Space);
        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox rememberMe;
        private System.Windows.Forms.Button loginbutton;
    }
}

