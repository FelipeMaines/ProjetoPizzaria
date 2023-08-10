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
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(209, 218);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(126, 169);
            listBox2.TabIndex = 23;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(44, 218);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(126, 169);
            listBox1.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 200);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 21;
            label4.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 200);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 20;
            label3.Text = "ML";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 86);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 19;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 23);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 18;
            label1.Text = "Id";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 151);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 25;
            label5.Text = "Valor";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(44, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(335, 23);
            textBox3.TabIndex = 24;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(225, 403);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(81, 31);
            btnCadastrar.TabIndex = 26;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(312, 403);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 31);
            btnCancelar.TabIndex = 27;
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
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "TelaProdutoForm";
            Text = "TelaProdutoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox2;
        private ListBox listBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox3;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}