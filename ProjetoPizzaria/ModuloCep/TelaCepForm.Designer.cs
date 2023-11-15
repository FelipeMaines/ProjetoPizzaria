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
            btnCadastrar = new Button();
            btnCancelar = new Button();
            lbId = new Label();
            lbCep = new Label();
            lbLogradouro = new Label();
            lbPais = new Label();
            lbUf = new Label();
            lbCidade = new Label();
            lbBairro = new Label();
            txPais = new TextBox();
            txUf = new TextBox();
            txCidade = new TextBox();
            txCep = new TextBox();
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
            txBairro.Location = new Point(239, 138);
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
            // btnCadastrar
            // 
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Location = new Point(291, 181);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 41);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
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
            lbUf.Location = new Point(239, 64);
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
            lbBairro.Location = new Point(239, 120);
            lbBairro.Name = "lbBairro";
            lbBairro.Size = new Size(38, 15);
            lbBairro.TabIndex = 15;
            lbBairro.Text = "Bairro";
            // 
            // txPais
            // 
            txPais.Location = new Point(28, 82);
            txPais.Name = "txPais";
            txPais.Size = new Size(188, 23);
            txPais.TabIndex = 16;
            // 
            // txUf
            // 
            txUf.Location = new Point(239, 82);
            txUf.Name = "txUf";
            txUf.Size = new Size(188, 23);
            txUf.TabIndex = 17;
            // 
            // txCidade
            // 
            txCidade.Location = new Point(28, 138);
            txCidade.Name = "txCidade";
            txCidade.Size = new Size(188, 23);
            txCidade.TabIndex = 18;
            // 
            // txCep
            // 
            txCep.Location = new Point(146, 35);
            txCep.Name = "txCep";
            txCep.Size = new Size(100, 23);
            txCep.TabIndex = 19;
            // 
            // TelaCepForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 233);
            Controls.Add(txCep);
            Controls.Add(txCidade);
            Controls.Add(txUf);
            Controls.Add(txPais);
            Controls.Add(lbBairro);
            Controls.Add(lbCidade);
            Controls.Add(lbUf);
            Controls.Add(lbPais);
            Controls.Add(lbLogradouro);
            Controls.Add(lbCep);
            Controls.Add(lbId);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
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
        private Button btnCadastrar;
        private Button btnCancelar;
        private Label lbId;
        private Label lbCep;
        private Label lbLogradouro;
        private Label lbPais;
        private Label lbUf;
        private Label lbCidade;
        private Label lbBairro;
        private TextBox txPais;
        private TextBox txUf;
        private TextBox txCidade;
        private TextBox txCep;
    }
}