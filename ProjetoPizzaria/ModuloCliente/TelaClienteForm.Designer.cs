namespace ProjetoPizzaria.ModuloCliente
{
    partial class TelaClienteForm
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
            txId = new TextBox();
            txNome = new TextBox();
            txEmail = new TextBox();
            txCpf = new MaskedTextBox();
            txTelefone = new MaskedTextBox();
            lbId = new Label();
            lbCpf = new Label();
            lbNome = new Label();
            lbTelefone = new Label();
            lbEmail = new Label();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txId
            // 
            txId.AccessibleRole = AccessibleRole.None;
            txId.Location = new Point(12, 59);
            txId.Name = "txId";
            txId.Size = new Size(118, 23);
            txId.TabIndex = 0;
            // 
            // txNome
            // 
            txNome.Location = new Point(12, 127);
            txNome.Name = "txNome";
            txNome.Size = new Size(429, 23);
            txNome.TabIndex = 1;
            // 
            // txEmail
            // 
            txEmail.Location = new Point(222, 205);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(268, 23);
            txEmail.TabIndex = 2;
            // 
            // txCpf
            // 
            txCpf.Location = new Point(136, 59);
            txCpf.Mask = "000.000.000-00";
            txCpf.Name = "txCpf";
            txCpf.Size = new Size(157, 23);
            txCpf.TabIndex = 3;
            txCpf.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // txTelefone
            // 
            txTelefone.Location = new Point(12, 205);
            txTelefone.Mask = "(00) 0 0000 - 0000";
            txTelefone.Name = "txTelefone";
            txTelefone.Size = new Size(186, 23);
            txTelefone.TabIndex = 4;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(10, 35);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 15);
            lbId.TabIndex = 5;
            lbId.Text = "Id";
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.Location = new Point(136, 35);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(28, 15);
            lbCpf.TabIndex = 6;
            lbCpf.Text = "CPF";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(12, 109);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 7;
            lbNome.Text = "Nome";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(12, 187);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(51, 15);
            lbTelefone.TabIndex = 8;
            lbTelefone.Text = "Telefone";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(222, 187);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(41, 15);
            lbEmail.TabIndex = 9;
            lbEmail.Text = "E-mail";
            // 
            // btnCadastrar
            // 
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Location = new Point(299, 256);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 43);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(399, 256);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 43);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 311);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(lbEmail);
            Controls.Add(lbTelefone);
            Controls.Add(lbNome);
            Controls.Add(lbCpf);
            Controls.Add(lbId);
            Controls.Add(txTelefone);
            Controls.Add(txCpf);
            Controls.Add(txEmail);
            Controls.Add(txNome);
            Controls.Add(txId);
            Name = "TelaClienteForm";
            Text = "TelaClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txId;
        private TextBox txNome;
        private TextBox txEmail;
        private MaskedTextBox txCpf;
        private MaskedTextBox txTelefone;
        private Label lbId;
        private Label lbCpf;
        private Label lbNome;
        private Label lbTelefone;
        private Label lbEmail;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}