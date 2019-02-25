namespace MyApplication
{
    partial class RegisterForm
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.fullnameTextBox1 = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Location = new System.Drawing.Point(12, 15);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(65, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "&Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Location = new System.Drawing.Point(12, 41);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "&Password";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.fullnameLabel.Location = new System.Drawing.Point(12, 67);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(58, 13);
            this.fullnameLabel.TabIndex = 4;
            this.fullnameLabel.Text = "&Fullname";
            // 
            // usernameTextBox1
            // 
            this.usernameTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox1.Location = new System.Drawing.Point(109, 12);
            this.usernameTextBox1.Name = "usernameTextBox1";
            this.usernameTextBox1.Size = new System.Drawing.Size(318, 20);
            this.usernameTextBox1.TabIndex = 1;
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox1.Location = new System.Drawing.Point(109, 38);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(318, 20);
            this.passwordTextBox1.TabIndex = 3;
            this.passwordTextBox1.UseSystemPasswordChar = true;
            // 
            // fullnameTextBox1
            // 
            this.fullnameTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullnameTextBox1.Location = new System.Drawing.Point(109, 64);
            this.fullnameTextBox1.Name = "fullnameTextBox1";
            this.fullnameTextBox1.Size = new System.Drawing.Size(318, 20);
            this.fullnameTextBox1.TabIndex = 5;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(109, 90);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Re&gister";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(190, 90);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(271, 90);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(352, 90);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(457, 128);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.fullnameTextBox1);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.usernameTextBox1);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.MaximumSize = new System.Drawing.Size(4544, 4545);
            this.MinimumSize = new System.Drawing.Size(473, 39);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.TextBox usernameTextBox1;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.TextBox fullnameTextBox1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
    }
}