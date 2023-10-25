namespace UIDentalClinicApp
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            signUpButton = new Button();
            SignUpPasswordTextBox = new TextBox();
            SignUpUsernameTextBox = new TextBox();
            SignUpUsernameLabel = new Label();
            LoginLabel = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            signUpPasswordAgainLabel = new Label();
            SignUpPasswordAgainTextBox = new TextBox();
            signUpPasswordLbl = new Label();
            signUpPhoneLabel = new Label();
            signUpPhoneTextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.Aquamarine;
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            signUpButton.Location = new Point(162, 397);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(222, 40);
            signUpButton.TabIndex = 4;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // SignUpPasswordTextBox
            // 
            SignUpPasswordTextBox.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpPasswordTextBox.Location = new Point(162, 199);
            SignUpPasswordTextBox.Name = "SignUpPasswordTextBox";
            SignUpPasswordTextBox.PasswordChar = '*';
            SignUpPasswordTextBox.Size = new Size(222, 35);
            SignUpPasswordTextBox.TabIndex = 1;
            // 
            // SignUpUsernameTextBox
            // 
            SignUpUsernameTextBox.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpUsernameTextBox.Location = new Point(162, 135);
            SignUpUsernameTextBox.Name = "SignUpUsernameTextBox";
            SignUpUsernameTextBox.Size = new Size(222, 35);
            SignUpUsernameTextBox.TabIndex = 0;
            // 
            // SignUpUsernameLabel
            // 
            SignUpUsernameLabel.AutoSize = true;
            SignUpUsernameLabel.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpUsernameLabel.Location = new Point(12, 138);
            SignUpUsernameLabel.Name = "SignUpUsernameLabel";
            SignUpUsernameLabel.Size = new Size(109, 30);
            SignUpUsernameLabel.TabIndex = 11;
            SignUpUsernameLabel.Text = "Username";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.ForeColor = SystemColors.Highlight;
            LoginLabel.Location = new Point(71, 103);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(264, 30);
            LoginLabel.TabIndex = 9;
            LoginLabel.Text = "Dental Clinic Management";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aquamarine;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 100);
            panel1.TabIndex = 5;
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
            // signUpPasswordAgainLabel
            // 
            signUpPasswordAgainLabel.AutoSize = true;
            signUpPasswordAgainLabel.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            signUpPasswordAgainLabel.Location = new Point(12, 266);
            signUpPasswordAgainLabel.Name = "signUpPasswordAgainLabel";
            signUpPasswordAgainLabel.Size = new Size(104, 30);
            signUpPasswordAgainLabel.TabIndex = 10;
            signUpPasswordAgainLabel.Text = "Password";
            // 
            // SignUpPasswordAgainTextBox
            // 
            SignUpPasswordAgainTextBox.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpPasswordAgainTextBox.Location = new Point(162, 263);
            SignUpPasswordAgainTextBox.Name = "SignUpPasswordAgainTextBox";
            SignUpPasswordAgainTextBox.PasswordChar = '*';
            SignUpPasswordAgainTextBox.Size = new Size(222, 35);
            SignUpPasswordAgainTextBox.TabIndex = 2;
            // 
            // signUpPasswordLbl
            // 
            signUpPasswordLbl.AutoSize = true;
            signUpPasswordLbl.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            signUpPasswordLbl.Location = new Point(12, 202);
            signUpPasswordLbl.Name = "signUpPasswordLbl";
            signUpPasswordLbl.Size = new Size(104, 30);
            signUpPasswordLbl.TabIndex = 11;
            signUpPasswordLbl.Text = "Password";
            // 
            // signUpPhoneLabel
            // 
            signUpPhoneLabel.AutoSize = true;
            signUpPhoneLabel.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            signUpPhoneLabel.Location = new Point(12, 330);
            signUpPhoneLabel.Name = "signUpPhoneLabel";
            signUpPhoneLabel.Size = new Size(73, 30);
            signUpPhoneLabel.TabIndex = 10;
            signUpPhoneLabel.Text = "Phone";
            // 
            // signUpPhoneTextBox
            // 
            signUpPhoneTextBox.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            signUpPhoneTextBox.Location = new Point(162, 327);
            signUpPhoneTextBox.Name = "signUpPhoneTextBox";
            signUpPhoneTextBox.Size = new Size(222, 35);
            signUpPhoneTextBox.TabIndex = 3;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 452);
            Controls.Add(signUpButton);
            Controls.Add(signUpPhoneTextBox);
            Controls.Add(SignUpPasswordAgainTextBox);
            Controls.Add(SignUpPasswordTextBox);
            Controls.Add(SignUpUsernameTextBox);
            Controls.Add(signUpPhoneLabel);
            Controls.Add(signUpPasswordAgainLabel);
            Controls.Add(signUpPasswordLbl);
            Controls.Add(SignUpUsernameLabel);
            Controls.Add(LoginLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signUpButton;
        private Button loginButton;
        private TextBox SignUpPasswordTextBox;
        private TextBox SignUpUsernameTextBox;
        private Label passwordLabel;
        private Label SignUpUsernameLabel;
        private Label LoginLabel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label signUpPasswordAgainLabel;
        private TextBox SignUpPasswordAgainTextBox;
        private Label signUpPasswordLbl;
        private Label signUpPhoneLabel;
        private TextBox signUpPhoneTextBox;
    }
}