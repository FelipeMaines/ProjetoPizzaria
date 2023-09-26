namespace ProjetoPizzaria.ModuloValores
{
    partial class TelaValorForm
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
            lbId = new Label();
            lbValor = new Label();
            lbValorBorda = new Label();
            txValor = new TextBox();
            txValorBorda = new TextBox();
            txId = new TextBox();
            listBoxTamanho = new ListBox();
            listBoxCategoria = new ListBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            lbTamanho = new Label();
            lbCategoria = new Label();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(26, 15);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 1;
            lbId.Text = "ID";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(26, 80);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(33, 15);
            lbValor.TabIndex = 2;
            lbValor.Text = "Valor";
            // 
            // lbValorBorda
            // 
            lbValorBorda.AutoSize = true;
            lbValorBorda.Location = new Point(172, 80);
            lbValorBorda.Name = "lbValorBorda";
            lbValorBorda.Size = new Size(96, 15);
            lbValorBorda.TabIndex = 3;
            lbValorBorda.Text = "Valor Extra Borda";
            // 
            // txValor
            // 
            txValor.Location = new Point(26, 98);
            txValor.Name = "txValor";
            txValor.Size = new Size(131, 23);
            txValor.TabIndex = 1;
            // 
            // txValorBorda
            // 
            txValorBorda.Location = new Point(172, 98);
            txValorBorda.Name = "txValorBorda";
            txValorBorda.Size = new Size(139, 23);
            txValorBorda.TabIndex = 2;
            // 
            // txId
            // 
            txId.Location = new Point(26, 33);
            txId.Name = "txId";
            txId.Size = new Size(100, 23);
            txId.TabIndex = 0;
            // 
            // listBoxTamanho
            // 
            listBoxTamanho.FormattingEnabled = true;
            listBoxTamanho.ItemHeight = 15;
            listBoxTamanho.Location = new Point(26, 158);
            listBoxTamanho.Name = "listBoxTamanho";
            listBoxTamanho.Size = new Size(131, 169);
            listBoxTamanho.TabIndex = 3;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 15;
            listBoxCategoria.Location = new Point(172, 158);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(131, 169);
            listBoxCategoria.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Location = new Point(172, 351);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(78, 41);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(258, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 41);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lbTamanho
            // 
            lbTamanho.AutoSize = true;
            lbTamanho.Location = new Point(26, 140);
            lbTamanho.Name = "lbTamanho";
            lbTamanho.Size = new Size(56, 15);
            lbTamanho.TabIndex = 13;
            lbTamanho.Text = "Tamanho";
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(172, 140);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(58, 15);
            lbCategoria.TabIndex = 14;
            lbCategoria.Text = "Categoria";
            // 
            // TelaValorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 399);
            Controls.Add(lbCategoria);
            Controls.Add(lbTamanho);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(listBoxCategoria);
            Controls.Add(listBoxTamanho);
            Controls.Add(txId);
            Controls.Add(txValorBorda);
            Controls.Add(txValor);
            Controls.Add(lbValorBorda);
            Controls.Add(lbValor);
            Controls.Add(lbId);
            Name = "TelaValorForm";
            Text = "TelaValorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private Label lbValor;
        private Label lbValorBorda;
        private TextBox txValor;
        private TextBox txValorBorda;
        private TextBox txId;
        private ListBox listBoxTamanho;
        private ListBox listBoxCategoria;
        private Button btnCadastrar;
        private Button btnCancelar;
        private Label lbTamanho;
        private Label lbCategoria;
    }
}