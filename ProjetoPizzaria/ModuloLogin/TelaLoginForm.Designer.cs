namespace ProjetoPizzaria.ModuloLogin
{
    partial class TelaLoginForm
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
            txUsuario = new TextBox();
            txSenha = new TextBox();
            lbUsuario = new Label();
            lbSenha = new Label();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // txUsuario
            // 
            txUsuario.Location = new Point(282, 142);
            txUsuario.Name = "txUsuario";
            txUsuario.Size = new Size(253, 23);
            txUsuario.TabIndex = 0;
            // 
            // txSenha
            // 
            txSenha.Location = new Point(282, 224);
            txSenha.Name = "txSenha";
            txSenha.Size = new Size(253, 23);
            txSenha.TabIndex = 1;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(282, 124);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(47, 15);
            lbUsuario.TabIndex = 2;
            lbUsuario.Text = "Usuário";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(282, 206);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 3;
            lbSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.DialogResult = DialogResult.OK;
            btnEntrar.Location = new Point(302, 278);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(200, 46);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += button1_Click;
            // 
            // TelaLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrar);
            Controls.Add(lbSenha);
            Controls.Add(lbUsuario);
            Controls.Add(txSenha);
            Controls.Add(txUsuario);
            Name = "TelaLoginForm";
            Text = "TelaLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txUsuario;
        private TextBox txSenha;
        private Label lbUsuario;
        private Label lbSenha;
        private Button btnEntrar;
    }
}