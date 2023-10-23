namespace DentalClinicApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            LoginLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aquamarine;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.ForeColor = SystemColors.Highlight;
            LoginLabel.Location = new Point(69, 103);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(264, 30);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Dental Clinic Management";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(12, 166);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(109, 30);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(12, 237);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(104, 30);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(162, 163);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(222, 35);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(162, 234);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(222, 35);
            passwordTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Aquamarine;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(162, 305);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(222, 40);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(410, 367);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(LoginLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label LoginLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
    }
}