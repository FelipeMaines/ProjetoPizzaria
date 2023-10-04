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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            toolStripLabel3 = new ToolStripLabel();
            btnConfiguracao = new ToolStripButton();
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            abrirAplicacaoToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lbNome = new Label();
            btnIgredientes = new Button();
            btnProdutos = new Button();
            btnFuncionario = new Button();
            btnEndereco = new Button();
            btnSabores = new Button();
            btnValores = new Button();
            btnCliente = new Button();
            panelContainerTabela = new Panel();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.FromArgb(55, 61, 66);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, toolStripLabel1, toolStripLabel2, toolStripLabel3, btnConfiguracao });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Margin = new Padding(10);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(8);
            toolStrip1.Size = new Size(796, 80);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.AutoSize = false;
            btnInserir.BackgroundImage = Properties.Resources.person_add_FILL0_wght400_GRAD0_opsz40;
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.ForeColor = Color.FromArgb(206, 246, 255);
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
            toolStripSeparator1.Size = new Size(6, 64);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(0, 61);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(10, 61);
            toolStripLabel2.Text = ".";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.ForeColor = Color.FromArgb(206, 246, 255);
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(86, 61);
            toolStripLabel3.Text = "toolStripLabel3";
            // 
            // btnConfiguracao
            // 
            btnConfiguracao.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConfiguracao.Image = (Image)resources.GetObject("btnConfiguracao.Image");
            btnConfiguracao.ImageTransparentColor = Color.Magenta;
            btnConfiguracao.Name = "btnConfiguracao";
            btnConfiguracao.Size = new Size(23, 61);
            btnConfiguracao.Text = "toolStripButton1";
            btnConfiguracao.Click += btnConfiguracao_Click;
            // 
            // notifyIconSystemTray
            // 
            notifyIconSystemTray.BalloonTipText = "App continua execultando na bandeja";
            notifyIconSystemTray.BalloonTipTitle = "Pizzaria Do Zé";
            notifyIconSystemTray.ContextMenuStrip = contextMenuStrip1;
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "Pizzaria Do Zé";
            notifyIconSystemTray.MouseDoubleClick += notifyIconSystemTray_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { abrirAplicacaoToolStripMenuItem, encerrarToolStripMenuItem, sobreToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(156, 70);
            contextMenuStrip1.MouseDoubleClick += contextMenuStrip1_MouseDoubleClick;
            // 
            // abrirAplicacaoToolStripMenuItem
            // 
            abrirAplicacaoToolStripMenuItem.Name = "abrirAplicacaoToolStripMenuItem";
            abrirAplicacaoToolStripMenuItem.Size = new Size(155, 22);
            abrirAplicacaoToolStripMenuItem.Text = "Abrir Aplicacao";
            abrirAplicacaoToolStripMenuItem.Click += abrirAplicacaoToolStripMenuItem_Click;
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(155, 22);
            encerrarToolStripMenuItem.Text = "Encerrar";
            encerrarToolStripMenuItem.Click += encerrarToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(155, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lbNome);
            panel2.Controls.Add(btnIgredientes);
            panel2.Controls.Add(btnProdutos);
            panel2.Controls.Add(btnFuncionario);
            panel2.Controls.Add(btnEndereco);
            panel2.Controls.Add(btnSabores);
            panel2.Controls.Add(btnValores);
            panel2.Controls.Add(btnCliente);
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(127, 484);
            panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.ForeColor = Color.FromArgb(206, 246, 255);
            lbNome.Location = new Point(42, 21);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            lbNome.Click += lbNome_Click;
            // 
            // btnIgredientes
            // 
            btnIgredientes.BackColor = Color.FromArgb(233, 154, 39);
            btnIgredientes.ForeColor = Color.Black;
            btnIgredientes.Location = new Point(12, 327);
            btnIgredientes.Name = "btnIgredientes";
            btnIgredientes.Size = new Size(100, 31);
            btnIgredientes.TabIndex = 7;
            btnIgredientes.Text = "Igredientes";
            btnIgredientes.UseVisualStyleBackColor = false;
            btnIgredientes.Click += btnIgredientes_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.FromArgb(233, 154, 39);
            btnProdutos.ForeColor = Color.Black;
            btnProdutos.Location = new Point(12, 364);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(100, 31);
            btnProdutos.TabIndex = 6;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.BackColor = Color.FromArgb(233, 154, 39);
            btnFuncionario.ForeColor = Color.Black;
            btnFuncionario.Location = new Point(12, 213);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(100, 31);
            btnFuncionario.TabIndex = 3;
            btnFuncionario.Text = "Funcionario";
            btnFuncionario.UseMnemonic = false;
            btnFuncionario.UseVisualStyleBackColor = false;
            btnFuncionario.Click += btnFuncionario_Click;
            btnFuncionario.KeyDown += btnFuncionario_KeyDown;
            // 
            // btnEndereco
            // 
            btnEndereco.BackColor = Color.FromArgb(233, 154, 39);
            btnEndereco.ForeColor = Color.Black;
            btnEndereco.Location = new Point(12, 250);
            btnEndereco.Name = "btnEndereco";
            btnEndereco.Size = new Size(100, 31);
            btnEndereco.TabIndex = 4;
            btnEndereco.Text = "Endereço";
            btnEndereco.UseVisualStyleBackColor = false;
            btnEndereco.Click += btnEndereco_Click;
            // 
            // btnSabores
            // 
            btnSabores.BackColor = Color.FromArgb(233, 154, 39);
            btnSabores.ForeColor = Color.Black;
            btnSabores.Location = new Point(12, 401);
            btnSabores.Name = "btnSabores";
            btnSabores.Size = new Size(100, 31);
            btnSabores.TabIndex = 8;
            btnSabores.Text = "Sabores";
            btnSabores.UseVisualStyleBackColor = false;
            btnSabores.Click += btnSabores_Click;
            // 
            // btnValores
            // 
            btnValores.BackColor = Color.FromArgb(233, 154, 39);
            btnValores.ForeColor = Color.Black;
            btnValores.Location = new Point(12, 290);
            btnValores.Name = "btnValores";
            btnValores.Size = new Size(100, 31);
            btnValores.TabIndex = 9;
            btnValores.Text = "Valores";
            btnValores.UseVisualStyleBackColor = false;
            btnValores.Click += btnValores_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(233, 154, 39);
            btnCliente.ForeColor = Color.Black;
            btnCliente.Location = new Point(12, 176);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(100, 31);
            btnCliente.TabIndex = 5;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // panelContainerTabela
            // 
            panelContainerTabela.Location = new Point(127, 80);
            panelContainerTabela.Name = "panelContainerTabela";
            panelContainerTabela.Size = new Size(669, 484);
            panelContainerTabela.TabIndex = 11;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(59, 45, 30);
            ClientSize = new Size(796, 564);
            Controls.Add(panelContainerTabela);
            Controls.Add(panel2);
            Controls.Add(toolStrip1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria";
            FormClosed += TelaPrincipal_FormClosed;
            Load += TelaPrincipal_Load;
            Resize += FormPrincipal_Resize;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabel3;
        private ToolStripButton btnConfiguracao;
        private NotifyIcon notifyIconSystemTray;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem abrirAplicacaoToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lbNome;
        private Button btnIgredientes;
        private Button btnProdutos;
        private Button btnFuncionario;
        private Button btnEndereco;
        private Button btnSabores;
        private Button btnValores;
        private Button btnCliente;
        private Panel panelContainerTabela;
    }
}