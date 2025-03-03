namespace DesktopApp
{
    partial class login
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
            panel1 = new Panel();
            btnLogin = new Button();
            showPass = new CheckBox();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label3silahkanlogin = new Label();
            label2pass = new Label();
            labelUsername = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(showPass);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label3silahkanlogin);
            panel1.Controls.Add(label2pass);
            panel1.Controls.Add(labelUsername);
            panel1.Location = new Point(201, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 374);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Location = new Point(185, 297);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(257, 39);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Location = new Point(280, 237);
            showPass.Name = "showPass";
            showPass.Size = new Size(162, 29);
            showPass.TabIndex = 5;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(185, 177);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(257, 31);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(185, 120);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(257, 31);
            txtUser.TabIndex = 3;
            // 
            // label3silahkanlogin
            // 
            label3silahkanlogin.AutoSize = true;
            label3silahkanlogin.BackColor = Color.Transparent;
            label3silahkanlogin.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3silahkanlogin.Location = new Point(172, 47);
            label3silahkanlogin.Name = "label3silahkanlogin";
            label3silahkanlogin.Size = new Size(221, 38);
            label3silahkanlogin.TabIndex = 2;
            label3silahkanlogin.Text = "Silahkan Login";
            // 
            // label2pass
            // 
            label2pass.AutoSize = true;
            label2pass.Location = new Point(74, 180);
            label2pass.Name = "label2pass";
            label2pass.Size = new Size(91, 25);
            label2pass.TabIndex = 1;
            label2pass.Text = "Password:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(74, 123);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(95, 25);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username:";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(955, 585);
            Controls.Add(panel1);
            Name = "login";
            Text = "Login";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3silahkanlogin;
        private Label label2pass;
        private Label labelUsername;
        private Button btnLogin;
        private CheckBox showPass;
        private TextBox txtPass;
        private TextBox txtUser;
    }
}
