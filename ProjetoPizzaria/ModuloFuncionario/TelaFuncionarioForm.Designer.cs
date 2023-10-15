namespace ProjetoPizzaria
{
    partial class TelaFuncionarioForm
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
            txMatricula = new TextBox();
            txCarteira = new TextBox();
            txEmail = new TextBox();
            txSenha = new TextBox();
            txValidade = new DateTimePicker();
            txDescricao = new RichTextBox();
            lbId = new Label();
            lbCpf = new Label();
            lbMatricula = new Label();
            lbNome = new Label();
            lbTelefone = new Label();
            lbEmail = new Label();
            lbCarteiraMotorista = new Label();
            lbValidade = new Label();
            lbSenha = new Label();
            lbDescricao = new Label();
            PnlCv = new Panel();
            radioButtonEntregador = new RadioButton();
            radioButtonAtendente = new RadioButton();
            radioButtonAdimin = new RadioButton();
            lbCv = new Label();
            txCpf = new MaskedTextBox();
            txTelefone = new MaskedTextBox();
            btnCancelar = new Button();
            btnCadastrar = new Button();
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
            label1 = new Label();
            txIdCep = new TextBox();
            lbComplemento = new Label();
            txComplemento = new TextBox();
            lbNumero = new Label();
            txNumero = new TextBox();
            PnlCv.SuspendLayout();
            SuspendLayout();
            // 
            // txId
            // 
            txId.Location = new Point(68, 44);
            txId.Name = "txId";
            txId.Size = new Size(80, 23);
            txId.TabIndex = 0;
            // 
            // txNome
            // 
            txNome.Location = new Point(68, 112);
            txNome.Name = "txNome";
            txNome.Size = new Size(360, 23);
            txNome.TabIndex = 4;
            // 
            // txMatricula
            // 
            txMatricula.Location = new Point(288, 44);
            txMatricula.Name = "txMatricula";
            txMatricula.Size = new Size(140, 23);
            txMatricula.TabIndex = 2;
            // 
            // txCarteira
            // 
            txCarteira.Location = new Point(68, 249);
            txCarteira.Name = "txCarteira";
            txCarteira.Size = new Size(105, 23);
            txCarteira.TabIndex = 7;
            // 
            // txEmail
            // 
            txEmail.Location = new Point(189, 181);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(239, 23);
            txEmail.TabIndex = 6;
            // 
            // txSenha
            // 
            txSenha.Location = new Point(337, 249);
            txSenha.Name = "txSenha";
            txSenha.Size = new Size(91, 23);
            txSenha.TabIndex = 9;
            // 
            // txValidade
            // 
            txValidade.Format = DateTimePickerFormat.Short;
            txValidade.Location = new Point(189, 249);
            txValidade.Name = "txValidade";
            txValidade.Size = new Size(132, 23);
            txValidade.TabIndex = 8;
            // 
            // txDescricao
            // 
            txDescricao.Location = new Point(68, 300);
            txDescricao.Name = "txDescricao";
            txDescricao.Size = new Size(487, 96);
            txDescricao.TabIndex = 10;
            txDescricao.Text = "";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(68, 26);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 11;
            lbId.Text = "ID";
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.Location = new Point(166, 26);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(28, 15);
            lbCpf.TabIndex = 12;
            lbCpf.Text = "CPF";
            // 
            // lbMatricula
            // 
            lbMatricula.AutoSize = true;
            lbMatricula.Location = new Point(288, 26);
            lbMatricula.Name = "lbMatricula";
            lbMatricula.Size = new Size(57, 15);
            lbMatricula.TabIndex = 13;
            lbMatricula.Text = "Matrícula";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(68, 94);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 14;
            lbNome.Text = "Nome";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(68, 163);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(51, 15);
            lbTelefone.TabIndex = 15;
            lbTelefone.Text = "Telefone";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(189, 163);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(41, 15);
            lbEmail.TabIndex = 16;
            lbEmail.Text = "E-mail";
            // 
            // lbCarteiraMotorista
            // 
            lbCarteiraMotorista.AutoSize = true;
            lbCarteiraMotorista.Location = new Point(68, 231);
            lbCarteiraMotorista.Name = "lbCarteiraMotorista";
            lbCarteiraMotorista.Size = new Size(102, 15);
            lbCarteiraMotorista.TabIndex = 17;
            lbCarteiraMotorista.Text = "Carteira Motorista";
            // 
            // lbValidade
            // 
            lbValidade.AutoSize = true;
            lbValidade.Location = new Point(189, 231);
            lbValidade.Name = "lbValidade";
            lbValidade.Size = new Size(51, 15);
            lbValidade.TabIndex = 18;
            lbValidade.Text = "Validade";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(337, 231);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 19;
            lbSenha.Text = "Senha";
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Location = new Point(68, 282);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(58, 15);
            lbDescricao.TabIndex = 20;
            lbDescricao.Text = "Descrição";
            // 
            // PnlCv
            // 
            PnlCv.Controls.Add(radioButtonEntregador);
            PnlCv.Controls.Add(radioButtonAtendente);
            PnlCv.Controls.Add(radioButtonAdimin);
            PnlCv.Location = new Point(443, 44);
            PnlCv.Name = "PnlCv";
            PnlCv.Size = new Size(133, 91);
            PnlCv.TabIndex = 3;
            PnlCv.Paint += panel1_Paint;
            // 
            // radioButtonEntregador
            // 
            radioButtonEntregador.AutoSize = true;
            radioButtonEntregador.Location = new Point(18, 53);
            radioButtonEntregador.Name = "radioButtonEntregador";
            radioButtonEntregador.Size = new Size(83, 19);
            radioButtonEntregador.TabIndex = 6;
            radioButtonEntregador.TabStop = true;
            radioButtonEntregador.Text = "Entregador";
            radioButtonEntregador.UseVisualStyleBackColor = true;
            // 
            // radioButtonAtendente
            // 
            radioButtonAtendente.AutoSize = true;
            radioButtonAtendente.Location = new Point(18, 28);
            radioButtonAtendente.Name = "radioButtonAtendente";
            radioButtonAtendente.Size = new Size(80, 19);
            radioButtonAtendente.TabIndex = 5;
            radioButtonAtendente.TabStop = true;
            radioButtonAtendente.Text = "Atendente";
            radioButtonAtendente.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdimin
            // 
            radioButtonAdimin.AutoSize = true;
            radioButtonAdimin.Location = new Point(18, 3);
            radioButtonAdimin.Name = "radioButtonAdimin";
            radioButtonAdimin.Size = new Size(64, 19);
            radioButtonAdimin.TabIndex = 4;
            radioButtonAdimin.TabStop = true;
            radioButtonAdimin.Text = "Adimin";
            radioButtonAdimin.UseVisualStyleBackColor = true;
            // 
            // lbCv
            // 
            lbCv.AutoSize = true;
            lbCv.Location = new Point(458, 26);
            lbCv.Name = "lbCv";
            lbCv.Size = new Size(22, 15);
            lbCv.TabIndex = 22;
            lbCv.Text = "CV";
            // 
            // txCpf
            // 
            txCpf.Location = new Point(166, 44);
            txCpf.Mask = "000.000.000-00";
            txCpf.Name = "txCpf";
            txCpf.Size = new Size(101, 23);
            txCpf.TabIndex = 1;
            // 
            // txTelefone
            // 
            txTelefone.Location = new Point(68, 181);
            txTelefone.Mask = "(99) 0 0000-0000";
            txTelefone.Name = "txTelefone";
            txTelefone.Size = new Size(105, 23);
            txTelefone.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(753, 420);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Location = new Point(668, 420);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 41);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txCep
            // 
            txCep.Location = new Point(595, 78);
            txCep.Mask = "00.000-000";
            txCep.Name = "txCep";
            txCep.Size = new Size(67, 23);
            txCep.TabIndex = 33;
            txCep.Leave += txCep_Leave;
            // 
            // lbBairro
            // 
            lbBairro.AutoSize = true;
            lbBairro.Location = new Point(595, 217);
            lbBairro.Name = "lbBairro";
            lbBairro.Size = new Size(38, 15);
            lbBairro.TabIndex = 47;
            lbBairro.Text = "Bairro";
            // 
            // lbCidade
            // 
            lbCidade.AutoSize = true;
            lbCidade.Location = new Point(593, 163);
            lbCidade.Name = "lbCidade";
            lbCidade.Size = new Size(44, 15);
            lbCidade.TabIndex = 46;
            lbCidade.Text = "Cidade";
            // 
            // lbUf
            // 
            lbUf.AutoSize = true;
            lbUf.Location = new Point(711, 110);
            lbUf.Name = "lbUf";
            lbUf.Size = new Size(21, 15);
            lbUf.TabIndex = 45;
            lbUf.Text = "UF";
            // 
            // lbPais
            // 
            lbPais.AutoSize = true;
            lbPais.Location = new Point(593, 107);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(28, 15);
            lbPais.TabIndex = 44;
            lbPais.Text = "País";
            // 
            // lbLogradouro
            // 
            lbLogradouro.AutoSize = true;
            lbLogradouro.Location = new Point(701, 57);
            lbLogradouro.Name = "lbLogradouro";
            lbLogradouro.Size = new Size(69, 15);
            lbLogradouro.TabIndex = 43;
            lbLogradouro.Text = "Logradouro";
            // 
            // lbCep
            // 
            lbCep.AutoSize = true;
            lbCep.Location = new Point(595, 57);
            lbCep.Name = "lbCep";
            lbCep.Size = new Size(28, 15);
            lbCep.TabIndex = 42;
            lbCep.Text = "CEP";
            // 
            // cbCidade
            // 
            cbCidade.FormattingEnabled = true;
            cbCidade.Location = new Point(593, 181);
            cbCidade.Name = "cbCidade";
            cbCidade.Size = new Size(218, 23);
            cbCidade.TabIndex = 37;
            // 
            // cbUf
            // 
            cbUf.FormattingEnabled = true;
            cbUf.Location = new Point(711, 128);
            cbUf.Name = "cbUf";
            cbUf.Size = new Size(100, 23);
            cbUf.TabIndex = 36;
            // 
            // cbPais
            // 
            cbPais.FormattingEnabled = true;
            cbPais.Location = new Point(593, 125);
            cbPais.Name = "cbPais";
            cbPais.Size = new Size(102, 23);
            cbPais.TabIndex = 35;
            // 
            // txLograduro
            // 
            txLograduro.Location = new Point(668, 79);
            txLograduro.Name = "txLograduro";
            txLograduro.Size = new Size(143, 23);
            txLograduro.TabIndex = 34;
            // 
            // txBairro
            // 
            txBairro.Location = new Point(593, 234);
            txBairro.Name = "txBairro";
            txBairro.Size = new Size(100, 23);
            txBairro.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(593, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 49;
            label1.Text = "ID";
            // 
            // txIdCep
            // 
            txIdCep.Location = new Point(593, 31);
            txIdCep.Name = "txIdCep";
            txIdCep.Size = new Size(69, 23);
            txIdCep.TabIndex = 50;
            // 
            // lbComplemento
            // 
            lbComplemento.AutoSize = true;
            lbComplemento.Location = new Point(595, 265);
            lbComplemento.Name = "lbComplemento";
            lbComplemento.Size = new Size(84, 15);
            lbComplemento.TabIndex = 52;
            lbComplemento.Text = "Complemento";
            // 
            // txComplemento
            // 
            txComplemento.Location = new Point(593, 282);
            txComplemento.Name = "txComplemento";
            txComplemento.Size = new Size(100, 23);
            txComplemento.TabIndex = 51;
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Location = new Point(713, 217);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(51, 15);
            lbNumero.TabIndex = 54;
            lbNumero.Text = "Numero";
            // 
            // txNumero
            // 
            txNumero.Location = new Point(711, 234);
            txNumero.Name = "txNumero";
            txNumero.Size = new Size(100, 23);
            txNumero.TabIndex = 53;
            // 
            // TelaFuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 473);
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
            Controls.Add(txTelefone);
            Controls.Add(txCpf);
            Controls.Add(lbCv);
            Controls.Add(PnlCv);
            Controls.Add(lbDescricao);
            Controls.Add(lbSenha);
            Controls.Add(lbValidade);
            Controls.Add(lbCarteiraMotorista);
            Controls.Add(lbEmail);
            Controls.Add(lbTelefone);
            Controls.Add(lbNome);
            Controls.Add(lbMatricula);
            Controls.Add(lbCpf);
            Controls.Add(lbId);
            Controls.Add(txDescricao);
            Controls.Add(txValidade);
            Controls.Add(txSenha);
            Controls.Add(txEmail);
            Controls.Add(txCarteira);
            Controls.Add(txMatricula);
            Controls.Add(txNome);
            Controls.Add(txId);
            KeyPreview = true;
            Name = "TelaFuncionarioForm";
            Text = "v";
            PnlCv.ResumeLayout(false);
            PnlCv.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txId;
        private TextBox txNome;
        private TextBox txMatricula;
        private TextBox txCarteira;
        private TextBox txEmail;
        private TextBox txSenha;
        private DateTimePicker txValidade;
        private RichTextBox txDescricao;
        private Label lbId;
        private Label lbCpf;
        private Label lbMatricula;
        private Label lbNome;
        private Label lbTelefone;
        private Label lbEmail;
        private Label lbCarteiraMotorista;
        private Label lbValidade;
        private Label lbSenha;
        private Label lbDescricao;
        private Panel PnlCv;
        private RadioButton radioButtonEntregador;
        private RadioButton radioButtonAtendente;
        private RadioButton radioButtonAdimin;
        private Label lbCv;
        private MaskedTextBox txCpf;
        private MaskedTextBox txTelefone;
        private Button btnCancelar;
        private Button btnCadastrar;
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
        private Label label1;
        private TextBox txIdCep;
        private Label lbComplemento;
        private TextBox txComplemento;
        private Label lbNumero;
        private TextBox txNumero;
    }
}