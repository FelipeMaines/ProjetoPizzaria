namespace ProjetoPizzaria.ModuloProdutos
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
            ListBoxMedida = new ListBox();
            ListBoxTipo = new ListBox();
            lbTipo = new Label();
            lbUnidadeMedida = new Label();
            lbNome = new Label();
            lbId = new Label();
            txNome = new TextBox();
            txId = new TextBox();
            lbValor = new Label();
            txValor = new TextBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // ListBoxMedida
            // 
            ListBoxMedida.FormattingEnabled = true;
            ListBoxMedida.ItemHeight = 15;
            ListBoxMedida.Location = new Point(209, 218);
            ListBoxMedida.Name = "ListBoxMedida";
            ListBoxMedida.Size = new Size(126, 169);
            ListBoxMedida.TabIndex = 4;
            // 
            // ListBoxTipo
            // 
            ListBoxTipo.FormattingEnabled = true;
            ListBoxTipo.ItemHeight = 15;
            ListBoxTipo.Location = new Point(44, 218);
            ListBoxTipo.Name = "ListBoxTipo";
            ListBoxTipo.Size = new Size(126, 169);
            ListBoxTipo.TabIndex = 3;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Location = new Point(44, 200);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(30, 15);
            lbTipo.TabIndex = 21;
            lbTipo.Text = "Tipo";
            // 
            // lbUnidadeMedida
            // 
            lbUnidadeMedida.AutoSize = true;
            lbUnidadeMedida.Location = new Point(209, 200);
            lbUnidadeMedida.Name = "lbUnidadeMedida";
            lbUnidadeMedida.Size = new Size(24, 15);
            lbUnidadeMedida.TabIndex = 20;
            lbUnidadeMedida.Text = "ML";
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
            lbId.Location = new Point(44, 23);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 15);
            lbId.TabIndex = 18;
            lbId.Text = "Id";
            // 
            // txNome
            // 
            txNome.Location = new Point(44, 104);
            txNome.Name = "txNome";
            txNome.Size = new Size(335, 23);
            txNome.TabIndex = 1;
            // 
            // txId
            // 
            txId.Location = new Point(44, 41);
            txId.Name = "txId";
            txId.Size = new Size(100, 23);
            txId.TabIndex = 0;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(44, 151);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(33, 15);
            lbValor.TabIndex = 25;
            lbValor.Text = "Valor";
            // 
            // txValor
            // 
            txValor.Location = new Point(44, 169);
            txValor.Name = "txValor";
            txValor.Size = new Size(335, 23);
            txValor.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(225, 403);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(81, 31);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(312, 403);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 31);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaProdutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 446);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(lbValor);
            Controls.Add(txValor);
            Controls.Add(ListBoxMedida);
            Controls.Add(ListBoxTipo);
            Controls.Add(lbTipo);
            Controls.Add(lbUnidadeMedida);
            Controls.Add(lbNome);
            Controls.Add(lbId);
            Controls.Add(txNome);
            Controls.Add(txId);
            Name = "TelaProdutoForm";
            Text = "TelaProdutoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxMedida;
        private ListBox ListBoxTipo;
        private Label lbTipo;
        private Label lbUnidadeMedida;
        private Label lbNome;
        private Label lbId;
        private TextBox txNome;
        private TextBox txId;
        private Label lbValor;
        private TextBox txValor;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}