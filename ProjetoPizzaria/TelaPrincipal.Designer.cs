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
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            abrirAplicacaoToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.FromArgb(55, 61, 66);
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, toolStripLabel1, toolStripLabel2, toolStripLabel3, btnConfiguracao });
            toolStrip1.Location = new Point(128, -1);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(8);
            toolStrip1.Size = new Size(672, 84);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
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
            toolStripSeparator1.Size = new Size(6, 68);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(0, 65);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(10, 65);
            toolStripLabel2.Text = ".";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.ForeColor = Color.FromArgb(206, 246, 255);
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(86, 65);
            toolStripLabel3.Text = "toolStripLabel3";
            // 
            // btnConfiguracao
            // 
            btnConfiguracao.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConfiguracao.Image = (Image)resources.GetObject("btnConfiguracao.Image");
            btnConfiguracao.ImageTransparentColor = Color.Magenta;
            btnConfiguracao.Name = "btnConfiguracao";
            btnConfiguracao.Size = new Size(23, 65);
            btnConfiguracao.Text = "toolStripButton1";
            btnConfiguracao.Click += btnConfiguracao_Click;
            // 
            // panelRegistros
            // 
            panelRegistros.BackColor = Color.FromArgb(102, 108, 114);
            panelRegistros.Location = new Point(0, 79);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(800, 371);
            panelRegistros.TabIndex = 3;
            panelRegistros.Paint += panelRegistros_Paint;
            panelRegistros.MouseDoubleClick += panelRegistros_MouseDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 61, 66);
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
            panel1.Size = new Size(131, 451);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnValores
            // 
            btnValores.BackColor = Color.FromArgb(233, 154, 39);
            btnValores.ForeColor = Color.Black;
            btnValores.Location = new Point(12, 407);
            btnValores.Name = "btnValores";
            btnValores.Size = new Size(100, 31);
            btnValores.TabIndex = 9;
            btnValores.Text = "Valores";
            btnValores.UseVisualStyleBackColor = false;
            btnValores.Click += btnValores_Click;
            // 
            // btnSabores
            // 
            btnSabores.BackColor = Color.FromArgb(233, 154, 39);
            btnSabores.ForeColor = Color.Black;
            btnSabores.Location = new Point(12, 367);
            btnSabores.Name = "btnSabores";
            btnSabores.Size = new Size(100, 31);
            btnSabores.TabIndex = 8;
            btnSabores.Text = "Sabores";
            btnSabores.UseVisualStyleBackColor = false;
            btnSabores.Click += btnSabores_Click;
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
            btnProdutos.Location = new Point(12, 287);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(100, 31);
            btnProdutos.TabIndex = 6;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(233, 154, 39);
            btnCliente.ForeColor = Color.Black;
            btnCliente.Location = new Point(12, 247);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(100, 31);
            btnCliente.TabIndex = 5;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnEndereco
            // 
            btnEndereco.BackColor = Color.FromArgb(233, 154, 39);
            btnEndereco.ForeColor = Color.Black;
            btnEndereco.Location = new Point(12, 207);
            btnEndereco.Name = "btnEndereco";
            btnEndereco.Size = new Size(100, 31);
            btnEndereco.TabIndex = 4;
            btnEndereco.Text = "Endereço";
            btnEndereco.UseVisualStyleBackColor = false;
            btnEndereco.Click += btnEndereco_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.BackColor = Color.FromArgb(233, 154, 39);
            btnFuncionario.ForeColor = Color.Black;
            btnFuncionario.Location = new Point(12, 167);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(100, 31);
            btnFuncionario.TabIndex = 3;
            btnFuncionario.Text = "Funcionario";
            btnFuncionario.UseMnemonic = false;
            btnFuncionario.UseVisualStyleBackColor = false;
            btnFuncionario.Click += btnFuncionario_Click;
            btnFuncionario.KeyDown += btnFuncionario_KeyDown;
            // 
            // lbNomeFuncionario
            // 
            lbNomeFuncionario.AutoSize = true;
            lbNomeFuncionario.Location = new Point(41, 148);
            lbNomeFuncionario.Name = "lbNomeFuncionario";
            lbNomeFuncionario.Size = new Size(0, 15);
            lbNomeFuncionario.TabIndex = 2;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.ForeColor = Color.FromArgb(206, 246, 255);
            lbNome.Location = new Point(41, 123);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            lbNome.Click += lbNome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(59, 45, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelRegistros);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
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
        private ToolStripButton btnConfiguracao;
        private NotifyIcon notifyIconSystemTray;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem abrirAplicacaoToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}