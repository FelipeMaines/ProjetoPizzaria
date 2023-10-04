namespace ProjetoPizzaria.ModuloSabor
{
    partial class TelaSaborForm
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
            lbId = new Label();
            lbNome = new Label();
            lbCategoria = new Label();
            lbTipo = new Label();
            lbImagem = new Label();
            lbIgredientes = new Label();
            pictureBox = new PictureBox();
            checkedListBox1 = new CheckedListBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            ListBoxCategoria = new ListBox();
            ListBoxTipo = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // txId
            // 
            txId.Location = new Point(30, 41);
            txId.Name = "txId";
            txId.Size = new Size(100, 23);
            txId.TabIndex = 0;
            // 
            // txNome
            // 
            txNome.Location = new Point(30, 117);
            txNome.Name = "txNome";
            txNome.Size = new Size(335, 23);
            txNome.TabIndex = 1;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(30, 23);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 15);
            lbId.TabIndex = 2;
            lbId.Text = "Id";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(30, 99);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 3;
            lbNome.Text = "Nome";
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(30, 204);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(58, 15);
            lbCategoria.TabIndex = 4;
            lbCategoria.Text = "Categoria";
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Location = new Point(215, 204);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(30, 15);
            lbTipo.TabIndex = 5;
            lbTipo.Text = "Tipo";
            // 
            // lbImagem
            // 
            lbImagem.AutoSize = true;
            lbImagem.Location = new Point(30, 337);
            lbImagem.Name = "lbImagem";
            lbImagem.Size = new Size(51, 15);
            lbImagem.TabIndex = 6;
            lbImagem.Text = "Imagem";
            // 
            // lbIgredientes
            // 
            lbIgredientes.AutoSize = true;
            lbIgredientes.Location = new Point(392, 23);
            lbIgredientes.Name = "lbIgredientes";
            lbIgredientes.Size = new Size(65, 15);
            lbIgredientes.TabIndex = 7;
            lbIgredientes.Text = "Igredientes";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.ActiveBorder;
            pictureBox.Location = new Point(30, 355);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(335, 165);
            pictureBox.TabIndex = 10;
            pictureBox.TabStop = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(392, 41);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(211, 400);
            checkedListBox1.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Location = new Point(434, 472);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(88, 48);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(528, 472);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 48);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ListBoxCategoria
            // 
            ListBoxCategoria.FormattingEnabled = true;
            ListBoxCategoria.ItemHeight = 15;
            ListBoxCategoria.Location = new Point(30, 222);
            ListBoxCategoria.Name = "ListBoxCategoria";
            ListBoxCategoria.Size = new Size(126, 109);
            ListBoxCategoria.TabIndex = 2;
            // 
            // ListBoxTipo
            // 
            ListBoxTipo.FormattingEnabled = true;
            ListBoxTipo.ItemHeight = 15;
            ListBoxTipo.Location = new Point(215, 222);
            ListBoxTipo.Name = "ListBoxTipo";
            ListBoxTipo.Size = new Size(126, 109);
            ListBoxTipo.TabIndex = 3;
            // 
            // TelaSaborForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 532);
            Controls.Add(ListBoxTipo);
            Controls.Add(ListBoxCategoria);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(checkedListBox1);
            Controls.Add(pictureBox);
            Controls.Add(lbIgredientes);
            Controls.Add(lbImagem);
            Controls.Add(lbTipo);
            Controls.Add(lbCategoria);
            Controls.Add(lbNome);
            Controls.Add(lbId);
            Controls.Add(txNome);
            Controls.Add(txId);
            KeyPreview = true;
            Name = "TelaSaborForm";
            Text = "TelaSaborForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txId;
        private TextBox txNome;
        private Label lbId;
        private Label lbNome;
        private Label lbCategoria;
        private Label lbTipo;
        private Label lbImagem;
        private Label lbIgredientes;
        private PictureBox pictureBox;
        private CheckedListBox checkedListBox1;
        private Button btnCadastrar;
        private Button btnCancelar;
        private ListBox ListBoxCategoria;
        private ListBox ListBoxTipo;
    }
}