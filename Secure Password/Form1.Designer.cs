namespace Secure_Password
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginButton = new Button();
            userNameTextBox = new TextBox();
            userNameLabel = new Label();
            passwordTextBox = new TextBox();
            PasswordLabel = new Label();
            testTextBox = new TextBox();
            createUserButton = new Button();
            createUserButton1 = new Button();
            testButton = new Button();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(333, 300);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(104, 42);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(323, 172);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(125, 27);
            userNameTextBox.TabIndex = 1;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(353, 149);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(75, 20);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "Username";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(323, 257);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(125, 27);
            passwordTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(353, 234);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(70, 20);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            // 
            // testTextBox
            // 
            testTextBox.Location = new Point(91, 63);
            testTextBox.Name = "testTextBox";
            testTextBox.Size = new Size(665, 27);
            testTextBox.TabIndex = 5;
            // 
            // createUserButton
            // 
            createUserButton.Location = new Point(0, 0);
            createUserButton.Name = "createUserButton";
            createUserButton.Size = new Size(75, 23);
            createUserButton.TabIndex = 0;
            // 
            // createUserButton1
            // 
            createUserButton1.Location = new Point(333, 348);
            createUserButton1.Name = "createUserButton1";
            createUserButton1.Size = new Size(104, 42);
            createUserButton1.TabIndex = 6;
            createUserButton1.Text = "Create User";
            createUserButton1.UseVisualStyleBackColor = true;
            createUserButton1.Click += CreateUserButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(testButton);
            Controls.Add(createUserButton1);
            Controls.Add(createUserButton);
            Controls.Add(testTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(loginButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private TextBox passwordTextBox;
        private Label PasswordLabel;
        private TextBox testTextBox;
        private Button createUserButton;
        private Button createUserButton1;
        private Button testButton;
    }
}