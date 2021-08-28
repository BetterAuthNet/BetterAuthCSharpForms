
namespace BetterAuthCSharpForms
{
    partial class BetterAuth
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panelLogReg = new System.Windows.Forms.Panel();
            this.panelsubs = new System.Windows.Forms.Panel();
            this.comboproduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltimeleft = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnactivatekey = new System.Windows.Forms.Button();
            this.panelLogReg.SuspendLayout();
            this.panelsubs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(98, 26);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 79);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(19, 139);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(123, 139);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panelLogReg
            // 
            this.panelLogReg.Controls.Add(this.txtPassword);
            this.panelLogReg.Controls.Add(this.btnRegister);
            this.panelLogReg.Controls.Add(this.txtUsername);
            this.panelLogReg.Controls.Add(this.btnLogin);
            this.panelLogReg.Controls.Add(this.label1);
            this.panelLogReg.Controls.Add(this.label2);
            this.panelLogReg.Location = new System.Drawing.Point(33, 12);
            this.panelLogReg.Name = "panelLogReg";
            this.panelLogReg.Size = new System.Drawing.Size(215, 206);
            this.panelLogReg.TabIndex = 6;
            // 
            // panelsubs
            // 
            this.panelsubs.Controls.Add(this.btnactivatekey);
            this.panelsubs.Controls.Add(this.txtKey);
            this.panelsubs.Controls.Add(this.label5);
            this.panelsubs.Controls.Add(this.btnDownload);
            this.panelsubs.Controls.Add(this.label4);
            this.panelsubs.Controls.Add(this.lbltimeleft);
            this.panelsubs.Controls.Add(this.label3);
            this.panelsubs.Controls.Add(this.comboproduct);
            this.panelsubs.Location = new System.Drawing.Point(296, 12);
            this.panelsubs.Name = "panelsubs";
            this.panelsubs.Size = new System.Drawing.Size(464, 206);
            this.panelsubs.TabIndex = 7;
            // 
            // comboproduct
            // 
            this.comboproduct.FormattingEnabled = true;
            this.comboproduct.Items.AddRange(new object[] {
            "Product 0",
            "Product 1",
            "Product 2"});
            this.comboproduct.Location = new System.Drawing.Point(157, 29);
            this.comboproduct.Name = "comboproduct";
            this.comboproduct.Size = new System.Drawing.Size(121, 21);
            this.comboproduct.TabIndex = 0;
            this.comboproduct.SelectedIndexChanged += new System.EventHandler(this.comboproduct_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product";
            // 
            // lbltimeleft
            // 
            this.lbltimeleft.AutoSize = true;
            this.lbltimeleft.Location = new System.Drawing.Point(163, 69);
            this.lbltimeleft.Name = "lbltimeleft";
            this.lbltimeleft.Size = new System.Drawing.Size(0, 13);
            this.lbltimeleft.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time left:";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(157, 95);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Key:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(111, 136);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 6;
            // 
            // btnactivatekey
            // 
            this.btnactivatekey.Location = new System.Drawing.Point(122, 162);
            this.btnactivatekey.Name = "btnactivatekey";
            this.btnactivatekey.Size = new System.Drawing.Size(75, 23);
            this.btnactivatekey.TabIndex = 7;
            this.btnactivatekey.Text = "Activate";
            this.btnactivatekey.UseVisualStyleBackColor = true;
            this.btnactivatekey.Click += new System.EventHandler(this.btnactivatekey_Click);
            // 
            // BetterAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 225);
            this.Controls.Add(this.panelsubs);
            this.Controls.Add(this.panelLogReg);
            this.Name = "BetterAuth";
            this.Text = "BetterAuth";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogReg.ResumeLayout(false);
            this.panelLogReg.PerformLayout();
            this.panelsubs.ResumeLayout(false);
            this.panelsubs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panelLogReg;
        private System.Windows.Forms.Panel panelsubs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboproduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltimeleft;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnactivatekey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label5;
    }
}

