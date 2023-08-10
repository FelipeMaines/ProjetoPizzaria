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
            labelid = new Label();
            labolValor = new Label();
            labelValorBorda = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Location = new Point(26, 15);
            labelid.Name = "labelid";
            labelid.Size = new Size(18, 15);
            labelid.TabIndex = 1;
            labelid.Text = "ID";
            // 
            // labolValor
            // 
            labolValor.AutoSize = true;
            labolValor.Location = new Point(26, 80);
            labolValor.Name = "labolValor";
            labolValor.Size = new Size(33, 15);
            labolValor.TabIndex = 2;
            labolValor.Text = "Valor";
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Location = new Point(172, 80);
            labelValorBorda.Name = "labelValorBorda";
            labelValorBorda.Size = new Size(96, 15);
            labelValorBorda.TabIndex = 3;
            labelValorBorda.Text = "Valor Extra Borda";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(26, 33);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(26, 158);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(131, 169);
            listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(172, 158);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(131, 169);
            listBox2.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Location = new Point(172, 351);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(78, 41);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "button1";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(258, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 41);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "button2";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 140);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 13;
            label1.Text = "Tamanho";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 140);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 14;
            label2.Text = "Categoria";
            // 
            // TelaValorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 399);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelValorBorda);
            Controls.Add(labolValor);
            Controls.Add(labelid);
            Name = "TelaValorForm";
            Text = "TelaValorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelid;
        private Label labolValor;
        private Label labelValorBorda;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnCadastrar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
    }
}