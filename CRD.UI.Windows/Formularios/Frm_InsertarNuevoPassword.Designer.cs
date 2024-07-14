namespace CRD.UI.Windows.Formularios
{
    partial class Frm_InsertarNuevoPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtViejoPassword = new System.Windows.Forms.TextBox();
            this.txtNuevoPassword = new System.Windows.Forms.TextBox();
            this.btnResetearPassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnResetearPassword);
            this.panel1.Controls.Add(this.txtNuevoPassword);
            this.panel1.Controls.Add(this.txtViejoPassword);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Contraseña);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(66, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 487);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESETEAR CONTRASEÑA";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(33, 158);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(91, 23);
            this.Contraseña.TabIndex = 1;
            this.Contraseña.Text = "Contraseña";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(33, 71);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 23);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nueva Contraseña";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(37, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(349, 29);
            this.txtEmail.TabIndex = 4;
            // 
            // txtViejoPassword
            // 
            this.txtViejoPassword.Location = new System.Drawing.Point(37, 192);
            this.txtViejoPassword.Name = "txtViejoPassword";
            this.txtViejoPassword.Size = new System.Drawing.Size(349, 29);
            this.txtViejoPassword.TabIndex = 5;
            this.txtViejoPassword.UseSystemPasswordChar = true;
            // 
            // txtNuevoPassword
            // 
            this.txtNuevoPassword.Location = new System.Drawing.Point(37, 283);
            this.txtNuevoPassword.Name = "txtNuevoPassword";
            this.txtNuevoPassword.Size = new System.Drawing.Size(349, 29);
            this.txtNuevoPassword.TabIndex = 6;
            this.txtNuevoPassword.UseSystemPasswordChar = true;
            // 
            // btnResetearPassword
            // 
            this.btnResetearPassword.Location = new System.Drawing.Point(37, 352);
            this.btnResetearPassword.Name = "btnResetearPassword";
            this.btnResetearPassword.Size = new System.Drawing.Size(349, 39);
            this.btnResetearPassword.TabIndex = 7;
            this.btnResetearPassword.Text = "Resetear Contraseña";
            this.btnResetearPassword.UseVisualStyleBackColor = true;
            this.btnResetearPassword.Click += new System.EventHandler(this.btnResetearPassword_Click);
            // 
            // Frm_InertarNuevoPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 565);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_InertarNuevoPassword";
            this.Text = "Frm_InertarNuevoPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetearPassword;
        private System.Windows.Forms.TextBox txtNuevoPassword;
        private System.Windows.Forms.TextBox txtViejoPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label label1;
    }
}