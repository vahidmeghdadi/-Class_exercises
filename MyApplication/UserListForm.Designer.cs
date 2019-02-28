namespace MyApplication
{
    partial class UserListForm
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
			this.fuulnameLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.deletusersButton = new System.Windows.Forms.Button();
			this.serchButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fuulnameLabel
			// 
			this.fuulnameLabel.AutoSize = true;
			this.fuulnameLabel.BackColor = System.Drawing.Color.Transparent;
			this.fuulnameLabel.Location = new System.Drawing.Point(9, 15);
			this.fuulnameLabel.Name = "fuulnameLabel";
			this.fuulnameLabel.Size = new System.Drawing.Size(54, 13);
			this.fuulnameLabel.TabIndex = 0;
			this.fuulnameLabel.Text = "&Full Name";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(69, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(319, 20);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 67);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(376, 120);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "userListBox";
			// 
			// deletusersButton
			// 
			this.deletusersButton.Location = new System.Drawing.Point(12, 193);
			this.deletusersButton.Name = "deletusersButton";
			this.deletusersButton.Size = new System.Drawing.Size(75, 23);
			this.deletusersButton.TabIndex = 4;
			this.deletusersButton.Text = "&Delet Users";
			this.deletusersButton.UseVisualStyleBackColor = true;
			// 
			// serchButton
			// 
			this.serchButton.Location = new System.Drawing.Point(69, 38);
			this.serchButton.Name = "serchButton";
			this.serchButton.Size = new System.Drawing.Size(75, 23);
			this.serchButton.TabIndex = 2;
			this.serchButton.Text = "&Serch";
			this.serchButton.UseVisualStyleBackColor = true;
			// 
			// UserListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(397, 228);
			this.Controls.Add(this.serchButton);
			this.Controls.Add(this.deletusersButton);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.fuulnameLabel);
			this.Name = "UserListForm";
			this.Text = "UserListForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fuulnameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button deletusersButton;
        private System.Windows.Forms.Button serchButton;
    }
}