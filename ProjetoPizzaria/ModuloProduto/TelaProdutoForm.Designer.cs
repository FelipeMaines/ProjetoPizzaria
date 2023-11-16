namespace ProjetoPizzaria.ModuloProduto
{
    partial class TelaProdutoForm
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
            lbCategoria = new Label();
            lbTamanho = new Label();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            listBoxTamanho = new ListBox();
            listBoxTipo = new ListBox();
            txId = new TextBox();
            txValor = new TextBox();
            txNome = new TextBox();
            lbValor = new Label();
            lbNome = new Label();
            lbId = new Label();
            SuspendLayout();
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(190, 146);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(56, 15);
            lbCategoria.TabIndex = 26;
            lbCategoria.Text = "Tamanho";
            // 
            // lbTamanho
            // 
            lbTamanho.AutoSize = true;
            lbTamanho.Location = new Point(44, 146);
            lbTamanho.Name = "lbTamanho";
            lbTamanho.Size = new Size(30, 15);
            lbTamanho.TabIndex = 25;
            lbTamanho.Text = "Tipo";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(276, 357);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 41);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Location = new Point(190, 357);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(78, 41);
            btnCadastrar.TabIndex = 23;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // listBoxTamanho
            // 
            listBoxTamanho.FormattingEnabled = true;
            listBoxTamanho.ItemHeight = 15;
            listBoxTamanho.Location = new Point(190, 164);
            listBoxTamanho.Name = "listBoxTamanho";
            listBoxTamanho.Size = new Size(131, 169);
            listBoxTamanho.TabIndex = 22;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Location = new Point(44, 164);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(131, 169);
            listBoxTipo.TabIndex = 20;
            // 
            // txId
            // 
            txId.Enabled = false;
            txId.Location = new Point(44, 39);
            txId.Name = "txId";
            txId.Size = new Size(100, 23);
            txId.TabIndex = 15;
            // 
            // txValor
            // 
            txValor.Location = new Point(190, 104);
            txValor.Name = "txValor";
            txValor.Size = new Size(139, 23);
            txValor.TabIndex = 18;
            // 
            // txNome
            // 
            txNome.Location = new Point(44, 104);
            txNome.Name = "txNome";
            txNome.Size = new Size(131, 23);
            txNome.TabIndex = 16;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(190, 86);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(33, 15);
            lbValor.TabIndex = 21;
            lbValor.Text = "Valor";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(44, 86);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 19;
            lbNome.Text = "Nome";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(44, 21);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 17;
            lbId.Text = "ID";
            // 
            // TelaProdutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 401);
            Controls.Add(lbCategoria);
            Controls.Add(lbTamanho);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(listBoxTamanho);
            Controls.Add(listBoxTipo);
            Controls.Add(txId);
            Controls.Add(txValor);
            Controls.Add(txNome);
            Controls.Add(lbValor);
            Controls.Add(lbNome);
            Controls.Add(lbId);
            Name = "TelaProdutoForm";
            Text = "TelaProdutoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCategoria;
        private Label lbTamanho;
        private Button btnCancelar;
        private Button btnCadastrar;
        private ListBox listBoxTamanho;
        private ListBox listBoxTipo;
        private TextBox txId;
        private TextBox txValor;
        private TextBox txNome;
        private Label lbValor;
        private Label lbNome;
        private Label lbId;
    }
}