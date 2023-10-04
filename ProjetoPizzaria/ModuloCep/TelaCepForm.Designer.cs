namespace ProjetoPizzaria.ModuloCep
{
    partial class TelaCepForm
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
            txBairro = new TextBox();
            txLograduro = new TextBox();
            cbPais = new ComboBox();
            cbUf = new ComboBox();
            cbCidade = new ComboBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            lbId = new Label();
            lbCep = new Label();
            lbLogradouro = new Label();
            lbPais = new Label();
            lbUf = new Label();
            lbCidade = new Label();
            lbBairro = new Label();
            txCep = new MaskedTextBox();
            SuspendLayout();
            // 
            // txId
            // 
            txId.Enabled = false;
            txId.Location = new Point(28, 35);
            txId.Name = "txId";
            txId.Size = new Size(100, 23);
            txId.TabIndex = 0;
            // 
            // txBairro
            // 
            txBairro.Location = new Point(266, 138);
            txBairro.Name = "txBairro";
            txBairro.Size = new Size(100, 23);
            txBairro.TabIndex = 6;
            // 
            // txLograduro
            // 
            txLograduro.Location = new Point(266, 35);
            txLograduro.Name = "txLograduro";
            txLograduro.Size = new Size(188, 23);
            txLograduro.TabIndex = 2;
            // 
            // cbPais
            // 
            cbPais.FormattingEnabled = true;
            cbPais.Location = new Point(28, 82);
            cbPais.Name = "cbPais";
            cbPais.Size = new Size(218, 23);
            cbPais.TabIndex = 3;
            // 
            // cbUf
            // 
            cbUf.FormattingEnabled = true;
            cbUf.Location = new Point(266, 82);
            cbUf.Name = "cbUf";
            cbUf.Size = new Size(100, 23);
            cbUf.TabIndex = 4;
            // 
            // cbCidade
            // 
            cbCidade.FormattingEnabled = true;
            cbCidade.Location = new Point(28, 138);
            cbCidade.Name = "cbCidade";
            cbCidade.Size = new Size(218, 23);
            cbCidade.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Location = new Point(291, 181);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 41);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(372, 181);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(28, 17);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 15);
            lbId.TabIndex = 9;
            lbId.Text = "Id";
            // 
            // lbCep
            // 
            lbCep.AutoSize = true;
            lbCep.Location = new Point(146, 17);
            lbCep.Name = "lbCep";
            lbCep.Size = new Size(28, 15);
            lbCep.TabIndex = 10;
            lbCep.Text = "CEP";
            // 
            // lbLogradouro
            // 
            lbLogradouro.AutoSize = true;
            lbLogradouro.Location = new Point(266, 17);
            lbLogradouro.Name = "lbLogradouro";
            lbLogradouro.Size = new Size(69, 15);
            lbLogradouro.TabIndex = 11;
            lbLogradouro.Text = "Logradouro";
            // 
            // lbPais
            // 
            lbPais.AutoSize = true;
            lbPais.Location = new Point(28, 64);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(28, 15);
            lbPais.TabIndex = 12;
            lbPais.Text = "País";
            // 
            // lbUf
            // 
            lbUf.AutoSize = true;
            lbUf.Location = new Point(266, 64);
            lbUf.Name = "lbUf";
            lbUf.Size = new Size(21, 15);
            lbUf.TabIndex = 13;
            lbUf.Text = "UF";
            // 
            // lbCidade
            // 
            lbCidade.AutoSize = true;
            lbCidade.Location = new Point(28, 120);
            lbCidade.Name = "lbCidade";
            lbCidade.Size = new Size(44, 15);
            lbCidade.TabIndex = 14;
            lbCidade.Text = "Cidade";
            // 
            // lbBairro
            // 
            lbBairro.AutoSize = true;
            lbBairro.Location = new Point(266, 120);
            lbBairro.Name = "lbBairro";
            lbBairro.Size = new Size(38, 15);
            lbBairro.TabIndex = 15;
            lbBairro.Text = "Bairro";
            // 
            // txCep
            // 
            txCep.Location = new Point(146, 35);
            txCep.Mask = "00 . 000 - 000";
            txCep.Name = "txCep";
            txCep.Size = new Size(100, 23);
            txCep.TabIndex = 1;
            txCep.TextAlign = HorizontalAlignment.Center;
            // 
            // TelaCepForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 233);
            Controls.Add(txCep);
            Controls.Add(lbBairro);
            Controls.Add(lbCidade);
            Controls.Add(lbUf);
            Controls.Add(lbPais);
            Controls.Add(lbLogradouro);
            Controls.Add(lbCep);
            Controls.Add(lbId);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(cbCidade);
            Controls.Add(cbUf);
            Controls.Add(cbPais);
            Controls.Add(txLograduro);
            Controls.Add(txBairro);
            Controls.Add(txId);
            KeyPreview = true;
            Name = "TelaCepForm";
            RightToLeftLayout = true;
            Text = "TelaCepForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txId;
        private TextBox txBairro;
        private TextBox txLograduro;
        private ComboBox cbPais;
        private ComboBox cbUf;
        private ComboBox cbCidade;
        private Button btnCadastrar;
        private Button btnCancelar;
        private Label lbId;
        private Label lbCep;
        private Label lbLogradouro;
        private Label lbPais;
        private Label lbUf;
        private Label lbCidade;
        private Label lbBairro;
        private MaskedTextBox txCep;
    }
}