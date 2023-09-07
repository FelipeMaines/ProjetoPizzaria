namespace ProjetoPizzaria
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            toolStripLabel3 = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panelRegistros = new Panel();
            panel1 = new Panel();
            btnValores = new Button();
            btnSabores = new Button();
            btnIgredientes = new Button();
            btnProdutos = new Button();
            btnCliente = new Button();
            btnEndereco = new Button();
            btnFuncionario = new Button();
            lbNomeFuncionario = new Label();
            lbNome = new Label();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = SystemColors.ActiveCaption;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, toolStripLabel1, toolStripLabel2, toolStripLabel3 });
            toolStrip1.Location = new Point(128, -1);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(8);
            toolStrip1.Size = new Size(663, 58);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // btnInserir
            // 
            btnInserir.AutoSize = false;
            btnInserir.BackgroundImage = Properties.Resources.person_add_FILL0_wght400_GRAD0_opsz40;
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(40, 40);
            btnInserir.Text = "toolStripButton1";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = false;
            btnEditar.BackgroundImage = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz40;
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(40, 40);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = false;
            btnExcluir.BackgroundImage = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz40;
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(40, 40);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = SystemColors.ActiveBorder;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 42);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(0, 39);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(10, 39);
            toolStripLabel2.Text = ".";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(86, 39);
            toolStripLabel3.Text = "toolStripLabel3";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panelRegistros
            // 
            panelRegistros.Location = new Point(128, 49);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(672, 379);
            panelRegistros.TabIndex = 3;
            panelRegistros.Paint += panelRegistros_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnValores);
            panel1.Controls.Add(btnSabores);
            panel1.Controls.Add(btnIgredientes);
            panel1.Controls.Add(btnProdutos);
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(btnEndereco);
            panel1.Controls.Add(btnFuncionario);
            panel1.Controls.Add(lbNomeFuncionario);
            panel1.Controls.Add(lbNome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(131, 429);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnValores
            // 
            btnValores.Location = new Point(12, 372);
            btnValores.Name = "btnValores";
            btnValores.Size = new Size(100, 31);
            btnValores.TabIndex = 9;
            btnValores.Text = "Valores";
            btnValores.UseVisualStyleBackColor = true;
            btnValores.Click += btnValores_Click;
            // 
            // btnSabores
            // 
            btnSabores.Location = new Point(12, 332);
            btnSabores.Name = "btnSabores";
            btnSabores.Size = new Size(100, 31);
            btnSabores.TabIndex = 8;
            btnSabores.Text = "Sabores";
            btnSabores.UseVisualStyleBackColor = true;
            btnSabores.Click += btnSabores_Click;
            // 
            // btnIgredientes
            // 
            btnIgredientes.Location = new Point(12, 292);
            btnIgredientes.Name = "btnIgredientes";
            btnIgredientes.Size = new Size(100, 31);
            btnIgredientes.TabIndex = 7;
            btnIgredientes.Text = "Igredientes";
            btnIgredientes.UseVisualStyleBackColor = true;
            btnIgredientes.Click += btnIgredientes_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(12, 252);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(100, 31);
            btnProdutos.TabIndex = 6;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(12, 212);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(100, 31);
            btnCliente.TabIndex = 5;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnEndereco
            // 
            btnEndereco.Location = new Point(12, 172);
            btnEndereco.Name = "btnEndereco";
            btnEndereco.Size = new Size(100, 31);
            btnEndereco.TabIndex = 4;
            btnEndereco.Text = "Endereço";
            btnEndereco.UseVisualStyleBackColor = true;
            btnEndereco.Click += btnEndereco_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.Location = new Point(12, 132);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(100, 31);
            btnFuncionario.TabIndex = 3;
            btnFuncionario.Text = "Funcionario";
            btnFuncionario.UseVisualStyleBackColor = true;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // lbNomeFuncionario
            // 
            lbNomeFuncionario.AutoSize = true;
            lbNomeFuncionario.Location = new Point(41, 130);
            lbNomeFuncionario.Name = "lbNomeFuncionario";
            lbNomeFuncionario.Size = new Size(0, 15);
            lbNomeFuncionario.TabIndex = 2;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(41, 98);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 92);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Name = "TelaPrincipal";
            Text = "Pizzaria";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel panelRegistros;
        private ToolStripLabel toolStripLabel3;
        private Panel panel1;
        private Label lbNome;
        private PictureBox pictureBox1;
        private Label lbNomeFuncionario;
        private Button btnValores;
        private Button btnSabores;
        private Button btnIgredientes;
        private Button btnProdutos;
        private Button btnCliente;
        private Button btnEndereco;
        private Button btnFuncionario;
    }
}