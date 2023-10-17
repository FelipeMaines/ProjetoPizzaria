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
            lbNumero = new Label();
            txNumero = new TextBox();
            lbComplemento = new Label();
            txComplemento = new TextBox();
            txIdCep = new TextBox();
            label1 = new Label();
            txCep = new MaskedTextBox();
            lbBairro = new Label();
            lbCidade = new Label();
            lbUf = new Label();
            lbPais = new Label();
            lbLogradouro = new Label();
            lbCep = new Label();
            cbCidade = new ComboBox();
            cbUf = new ComboBox();
            cbPais = new ComboBox();
            txLograduro = new TextBox();
            txBairro = new TextBox();
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
            txNome.TabIndex = 2;
            // 
            // txEmail
            // 
            txEmail.Location = new Point(222, 205);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(268, 23);
            txEmail.TabIndex = 4;
            // 
            // txCpf
            // 
            txCpf.Location = new Point(136, 59);
            txCpf.Mask = "000.000.000-00";
            txCpf.Name = "txCpf";
            txCpf.Size = new Size(157, 23);
            txCpf.TabIndex = 1;
            txCpf.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // txTelefone
            // 
            txTelefone.Location = new Point(12, 205);
            txTelefone.Mask = "(00) 0 0000 - 0000";
            txTelefone.Name = "txTelefone";
            txTelefone.Size = new Size(186, 23);
            txTelefone.TabIndex = 3;
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
            btnCadastrar.Location = new Point(550, 300);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 43);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(650, 300);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 43);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Location = new Point(636, 167);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(51, 15);
            lbNumero.TabIndex = 72;
            lbNumero.Text = "Numero";
            // 
            // txNumero
            // 
            txNumero.Location = new Point(634, 184);
            txNumero.Name = "txNumero";
            txNumero.Size = new Size(100, 23);
            txNumero.TabIndex = 71;
            // 
            // lbComplemento
            // 
            lbComplemento.AutoSize = true;
            lbComplemento.Location = new Point(518, 215);
            lbComplemento.Name = "lbComplemento";
            lbComplemento.Size = new Size(84, 15);
            lbComplemento.TabIndex = 70;
            lbComplemento.Text = "Complemento";
            // 
            // txComplemento
            // 
            txComplemento.Location = new Point(516, 232);
            txComplemento.Name = "txComplemento";
            txComplemento.Size = new Size(100, 23);
            txComplemento.TabIndex = 69;
            // 
            // txIdCep
            // 
            txIdCep.Location = new Point(516, 29);
            txIdCep.Name = "txIdCep";
            txIdCep.Size = new Size(69, 23);
            txIdCep.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(518, 11);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 67;
            label1.Text = "ID";
            // 
            // txCep
            // 
            txCep.Location = new Point(310, 59);
            txCep.Mask = "00.000-000";
            txCep.Name = "txCep";
            txCep.Size = new Size(83, 23);
            txCep.TabIndex = 55;
            txCep.Leave += txCep_Leave;
            // 
            // lbBairro
            // 
            lbBairro.AutoSize = true;
            lbBairro.Location = new Point(518, 167);
            lbBairro.Name = "lbBairro";
            lbBairro.Size = new Size(38, 15);
            lbBairro.TabIndex = 66;
            lbBairro.Text = "Bairro";
            // 
            // lbCidade
            // 
            lbCidade.AutoSize = true;
            lbCidade.Location = new Point(516, 113);
            lbCidade.Name = "lbCidade";
            lbCidade.Size = new Size(44, 15);
            lbCidade.TabIndex = 65;
            lbCidade.Text = "Cidade";
            // 
            // lbUf
            // 
            lbUf.AutoSize = true;
            lbUf.Location = new Point(634, 60);
            lbUf.Name = "lbUf";
            lbUf.Size = new Size(21, 15);
            lbUf.TabIndex = 64;
            lbUf.Text = "UF";
            // 
            // lbPais
            // 
            lbPais.AutoSize = true;
            lbPais.Location = new Point(516, 57);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(28, 15);
            lbPais.TabIndex = 63;
            lbPais.Text = "País";
            // 
            // lbLogradouro
            // 
            lbLogradouro.AutoSize = true;
            lbLogradouro.Location = new Point(591, 11);
            lbLogradouro.Name = "lbLogradouro";
            lbLogradouro.Size = new Size(69, 15);
            lbLogradouro.TabIndex = 62;
            lbLogradouro.Text = "Logradouro";
            // 
            // lbCep
            // 
            lbCep.AutoSize = true;
            lbCep.Location = new Point(310, 41);
            lbCep.Name = "lbCep";
            lbCep.Size = new Size(28, 15);
            lbCep.TabIndex = 61;
            lbCep.Text = "CEP";
            // 
            // cbCidade
            // 
            cbCidade.FormattingEnabled = true;
            cbCidade.Location = new Point(516, 131);
            cbCidade.Name = "cbCidade";
            cbCidade.Size = new Size(218, 23);
            cbCidade.TabIndex = 59;
            // 
            // cbUf
            // 
            cbUf.FormattingEnabled = true;
            cbUf.Location = new Point(634, 78);
            cbUf.Name = "cbUf";
            cbUf.Size = new Size(100, 23);
            cbUf.TabIndex = 58;
            // 
            // cbPais
            // 
            cbPais.FormattingEnabled = true;
            cbPais.Location = new Point(516, 75);
            cbPais.Name = "cbPais";
            cbPais.Size = new Size(102, 23);
            cbPais.TabIndex = 57;
            // 
            // txLograduro
            // 
            txLograduro.Location = new Point(591, 29);
            txLograduro.Name = "txLograduro";
            txLograduro.Size = new Size(143, 23);
            txLograduro.TabIndex = 56;
            // 
            // txBairro
            // 
            txBairro.Location = new Point(516, 184);
            txBairro.Name = "txBairro";
            txBairro.Size = new Size(100, 23);
            txBairro.TabIndex = 60;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 355);
            Controls.Add(lbNumero);
            Controls.Add(txNumero);
            Controls.Add(lbComplemento);
            Controls.Add(txComplemento);
            Controls.Add(txIdCep);
            Controls.Add(label1);
            Controls.Add(txCep);
            Controls.Add(lbBairro);
            Controls.Add(lbCidade);
            Controls.Add(lbUf);
            Controls.Add(lbPais);
            Controls.Add(lbLogradouro);
            Controls.Add(lbCep);
            Controls.Add(cbCidade);
            Controls.Add(cbUf);
            Controls.Add(cbPais);
            Controls.Add(txLograduro);
            Controls.Add(txBairro);
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
            KeyPreview = true;
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
        private Label lbNumero;
        private TextBox txNumero;
        private Label lbComplemento;
        private TextBox txComplemento;
        private TextBox txIdCep;
        private Label label1;
        private MaskedTextBox txCep;
        private Label lbBairro;
        private Label lbCidade;
        private Label lbUf;
        private Label lbPais;
        private Label lbLogradouro;
        private Label lbCep;
        private ComboBox cbCidade;
        private ComboBox cbUf;
        private ComboBox cbPais;
        private TextBox txLograduro;
        private TextBox txBairro;
    }
}