namespace music
{
    partial class Reg
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
            this.button_reg = new System.Windows.Forms.Button();
            this.text_password = new System.Windows.Forms.TextBox();
            this.text_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.button_toAuth = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_reg
            // 
            this.button_reg.BackColor = System.Drawing.Color.Black;
            this.button_reg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button_reg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_reg.Location = new System.Drawing.Point(410, 374);
            this.button_reg.Margin = new System.Windows.Forms.Padding(4);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(244, 47);
            this.button_reg.TabIndex = 7;
            this.button_reg.Text = "Зарегистрироваться";
            this.button_reg.UseVisualStyleBackColor = false;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // text_password
            // 
            this.text_password.BackColor = System.Drawing.Color.White;
            this.text_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_password.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.text_password.ForeColor = System.Drawing.Color.Black;
            this.text_password.Location = new System.Drawing.Point(421, 327);
            this.text_password.Margin = new System.Windows.Forms.Padding(4);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(211, 18);
            this.text_password.TabIndex = 6;
            this.text_password.Text = "Пароль";
            this.text_password.Click += new System.EventHandler(this.text_password_Click);
            this.text_password.TextChanged += new System.EventHandler(this.text_password_TextChanged);
            this.text_password.Leave += new System.EventHandler(this.text_password_Leave);
            // 
            // text_login
            // 
            this.text_login.BackColor = System.Drawing.Color.White;
            this.text_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_login.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.text_login.ForeColor = System.Drawing.Color.Black;
            this.text_login.Location = new System.Drawing.Point(421, 276);
            this.text_login.Margin = new System.Windows.Forms.Padding(4);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(211, 18);
            this.text_login.TabIndex = 5;
            this.text_login.Text = "Логин";
            this.text_login.Click += new System.EventHandler(this.text_login_Click);
            this.text_login.TextChanged += new System.EventHandler(this.text_login_TextChanged);
            this.text_login.Leave += new System.EventHandler(this.text_login_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(451, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Регистриция";
            // 
            // text_name
            // 
            this.text_name.BackColor = System.Drawing.Color.White;
            this.text_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.text_name.ForeColor = System.Drawing.Color.Black;
            this.text_name.Location = new System.Drawing.Point(421, 225);
            this.text_name.Margin = new System.Windows.Forms.Padding(4);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(211, 18);
            this.text_name.TabIndex = 8;
            this.text_name.Text = "Имя";
            this.text_name.Click += new System.EventHandler(this.text_name_Click);
            this.text_name.Leave += new System.EventHandler(this.text_name_Leave);
            // 
            // button_toAuth
            // 
            this.button_toAuth.BackColor = System.Drawing.Color.Transparent;
            this.button_toAuth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_toAuth.FlatAppearance.BorderSize = 0;
            this.button_toAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_toAuth.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button_toAuth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_toAuth.Location = new System.Drawing.Point(410, 425);
            this.button_toAuth.Margin = new System.Windows.Forms.Padding(4);
            this.button_toAuth.Name = "button_toAuth";
            this.button_toAuth.Size = new System.Drawing.Size(244, 30);
            this.button_toAuth.TabIndex = 12;
            this.button_toAuth.Text = "Есть аккаунт";
            this.button_toAuth.UseVisualStyleBackColor = false;
            this.button_toAuth.Click += new System.EventHandler(this.button_toAuth_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(410, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 47);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(410, 261);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 47);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(410, 312);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 47);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 599);
            this.Controls.Add(this.button_toAuth);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1085, 646);
            this.MinimumSize = new System.Drawing.Size(1085, 646);
            this.Name = "Reg";
            this.Text = "Z.Музыка";
            this.Load += new System.EventHandler(this.Reg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Button button_toAuth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}