namespace Maestro.Escola.Forms
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Txt_Entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Titulo.Location = new System.Drawing.Point(355, 37);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(222, 47);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Escola Maestro";
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Location = new System.Drawing.Point(355, 179);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(40, 15);
            this.Lbl_Login.TabIndex = 1;
            this.Lbl_Login.Text = "Login:";
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Location = new System.Drawing.Point(355, 222);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(42, 15);
            this.Lbl_Senha.TabIndex = 1;
            this.Lbl_Senha.Text = "Senha:";
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(401, 176);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(160, 23);
            this.Txt_Login.TabIndex = 2;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(401, 219);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(160, 23);
            this.Txt_Senha.TabIndex = 2;
            // 
            // Txt_Entrar
            // 
            this.Txt_Entrar.Location = new System.Drawing.Point(423, 281);
            this.Txt_Entrar.Name = "Txt_Entrar";
            this.Txt_Entrar.Size = new System.Drawing.Size(116, 33);
            this.Txt_Entrar.TabIndex = 3;
            this.Txt_Entrar.Text = "Entrar";
            this.Txt_Entrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 514);
            this.Controls.Add(this.Txt_Entrar);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Lbl_Login);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Login;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.TextBox Txt_Login;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Button Txt_Entrar;
    }
}

