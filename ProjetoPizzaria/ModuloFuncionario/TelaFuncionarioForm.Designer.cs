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
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            lbCv = new Label();
            txCpf = new MaskedTextBox();
            txTelefone = new MaskedTextBox();
            btnCancelar = new Button();
            btnCadastrar = new Button();
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
            txNome.TabIndex = 1;
            // 
            // txMatricula
            // 
            txMatricula.Location = new Point(288, 44);
            txMatricula.Name = "txMatricula";
            txMatricula.Size = new Size(140, 23);
            txMatricula.TabIndex = 3;
            // 
            // txCarteira
            // 
            txCarteira.Location = new Point(68, 249);
            txCarteira.Name = "txCarteira";
            txCarteira.Size = new Size(105, 23);
            txCarteira.TabIndex = 4;
            // 
            // txEmail
            // 
            txEmail.Location = new Point(189, 181);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(239, 23);
            txEmail.TabIndex = 5;
            // 
            // txSenha
            // 
            txSenha.Location = new Point(337, 249);
            txSenha.Name = "txSenha";
            txSenha.Size = new Size(91, 23);
            txSenha.TabIndex = 7;
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
            PnlCv.Controls.Add(radioButton3);
            PnlCv.Controls.Add(radioButton2);
            PnlCv.Controls.Add(radioButton1);
            PnlCv.Location = new Point(443, 44);
            PnlCv.Name = "PnlCv";
            PnlCv.Size = new Size(133, 134);
            PnlCv.TabIndex = 21;
            PnlCv.Paint += panel1_Paint;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(18, 53);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(18, 28);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(18, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
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
            txCpf.TabIndex = 23;
            // 
            // txTelefone
            // 
            txTelefone.Location = new Point(68, 181);
            txTelefone.Mask = "(99) 0 0000-0000";
            txTelefone.Name = "txTelefone";
            txTelefone.Size = new Size(105, 23);
            txTelefone.TabIndex = 24;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(486, 420);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Location = new Point(405, 420);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 41);
            btnCadastrar.TabIndex = 25;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // TelaFuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 473);
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
            Name = "TelaFuncionarioForm";
            Text = "TelaFuncionarioForm";
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
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label lbCv;
        private MaskedTextBox txCpf;
        private MaskedTextBox txTelefone;
        private Button btnCancelar;
        private Button btnCadastrar;
    }
}