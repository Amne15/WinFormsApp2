namespace WinFormsApp2
{
    partial class Form2
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
            this.lLogin = new System.Windows.Forms.Label();
            this.lPwd = new System.Windows.Forms.Label();
            this.tboxLogin = new System.Windows.Forms.TextBox();
            this.tboxPwd = new System.Windows.Forms.TextBox();
            this.tbMensaje = new System.Windows.Forms.TextBox();
            this.lMensaje = new System.Windows.Forms.Label();
            this.bVerificar = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lLogin
            // 
            this.lLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLogin.BackColor = System.Drawing.SystemColors.Control;
            this.lLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lLogin.Location = new System.Drawing.Point(30, 29);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(72, 23);
            this.lLogin.TabIndex = 0;
            this.lLogin.Text = "Login";
            this.lLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lPwd
            // 
            this.lPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPwd.BackColor = System.Drawing.SystemColors.Control;
            this.lPwd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPwd.Location = new System.Drawing.Point(30, 78);
            this.lPwd.Name = "lPwd";
            this.lPwd.Size = new System.Drawing.Size(72, 23);
            this.lPwd.TabIndex = 2;
            this.lPwd.Text = "Password";
            this.lPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxLogin
            // 
            this.tboxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxLogin.Location = new System.Drawing.Point(108, 29);
            this.tboxLogin.Name = "tboxLogin";
            this.tboxLogin.Size = new System.Drawing.Size(119, 23);
            this.tboxLogin.TabIndex = 1;
            this.tboxLogin.TextChanged += new System.EventHandler(this.tboxLogin_TextChanged);
            // 
            // tboxPwd
            // 
            this.tboxPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxPwd.Location = new System.Drawing.Point(108, 78);
            this.tboxPwd.Name = "tboxPwd";
            this.tboxPwd.Size = new System.Drawing.Size(119, 23);
            this.tboxPwd.TabIndex = 3;
            this.tboxPwd.UseSystemPasswordChar = true;
            this.tboxPwd.TextChanged += new System.EventHandler(this.tboxPwd_TextChanged);
            // 
            // tbMensaje
            // 
            this.tbMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMensaje.Location = new System.Drawing.Point(108, 128);
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.Size = new System.Drawing.Size(119, 23);
            this.tbMensaje.TabIndex = 7;
            this.tbMensaje.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lMensaje
            // 
            this.lMensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lMensaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lMensaje.Location = new System.Drawing.Point(30, 128);
            this.lMensaje.Name = "lMensaje";
            this.lMensaje.Size = new System.Drawing.Size(72, 23);
            this.lMensaje.TabIndex = 6;
            this.lMensaje.Text = "Check";
            this.lMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bVerificar
            // 
            this.bVerificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bVerificar.Location = new System.Drawing.Point(35, 176);
            this.bVerificar.Name = "bVerificar";
            this.bVerificar.Size = new System.Drawing.Size(93, 32);
            this.bVerificar.TabIndex = 4;
            this.bVerificar.Text = "OK";
            this.bVerificar.UseVisualStyleBackColor = true;
            this.bVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bClear.Location = new System.Drawing.Point(134, 176);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(93, 32);
            this.bClear.TabIndex = 5;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 271);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bVerificar);
            this.Controls.Add(this.tbMensaje);
            this.Controls.Add(this.lMensaje);
            this.Controls.Add(this.tboxPwd);
            this.Controls.Add(this.tboxLogin);
            this.Controls.Add(this.lPwd);
            this.Controls.Add(this.lLogin);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lLogin;
        private Label lPwd;
        private TextBox tboxLogin;
        private TextBox tboxPwd;
        private TextBox tbMensaje;
        private Label lMensaje;
        private Button bVerificar;
        private Button bClear;
    }
}