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
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            abrirAplicacaoToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSabores = new Button();
            btnValores = new Button();
            btnProduto = new Button();
            btnCliente = new Button();
            btnCep = new Button();
            btnIgrediente = new Button();
            btnFuncionario = new Button();
            panel2 = new Panel();
            btnConfiguracao = new Button();
            btnPesquisar = new Button();
            textBox1 = new TextBox();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnInserir = new Button();
            panelContainer = new Panel();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSabores);
            panel1.Controls.Add(btnValores);
            panel1.Controls.Add(btnProduto);
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(btnCep);
            panel1.Controls.Add(btnIgrediente);
            panel1.Controls.Add(btnFuncionario);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 451);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 111);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 76);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnSabores
            // 
            btnSabores.BackColor = Color.Coral;
            btnSabores.Location = new Point(27, 360);
            btnSabores.Name = "btnSabores";
            btnSabores.Size = new Size(100, 37);
            btnSabores.TabIndex = 9;
            btnSabores.Text = "Sabores";
            btnSabores.UseVisualStyleBackColor = false;
            btnSabores.Click += btnSabores_Click_1;
            // 
            // btnValores
            // 
            btnValores.BackColor = Color.Coral;
            btnValores.ForeColor = SystemColors.ButtonHighlight;
            btnValores.Location = new Point(27, 403);
            btnValores.Name = "btnValores";
            btnValores.Size = new Size(100, 37);
            btnValores.TabIndex = 8;
            btnValores.Text = "Valores";
            btnValores.UseVisualStyleBackColor = false;
            btnValores.Click += btnValores_Click_1;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.Coral;
            btnProduto.Location = new Point(27, 274);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(100, 37);
            btnProduto.TabIndex = 7;
            btnProduto.Text = "Produto";
            btnProduto.UseVisualStyleBackColor = false;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.Coral;
            btnCliente.Location = new Point(27, 231);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(100, 37);
            btnCliente.TabIndex = 6;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click_1;
            // 
            // btnCep
            // 
            btnCep.BackColor = Color.Coral;
            btnCep.Location = new Point(27, 188);
            btnCep.Name = "btnCep";
            btnCep.Size = new Size(100, 37);
            btnCep.TabIndex = 5;
            btnCep.Text = "Cep";
            btnCep.UseVisualStyleBackColor = false;
            btnCep.Click += btnCep_Click;
            // 
            // btnIgrediente
            // 
            btnIgrediente.BackColor = Color.Coral;
            btnIgrediente.ForeColor = SystemColors.ButtonHighlight;
            btnIgrediente.Location = new Point(27, 317);
            btnIgrediente.Name = "btnIgrediente";
            btnIgrediente.Size = new Size(100, 37);
            btnIgrediente.TabIndex = 4;
            btnIgrediente.Text = "Igredientes";
            btnIgrediente.UseVisualStyleBackColor = false;
            btnIgrediente.Click += btnIgrediente_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.BackColor = Color.Coral;
            btnFuncionario.Location = new Point(27, 145);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(100, 37);
            btnFuncionario.TabIndex = 0;
            btnFuncionario.Text = "Funcionario";
            btnFuncionario.UseVisualStyleBackColor = false;
            btnFuncionario.Click += btnFuncionario_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(btnConfiguracao);
            panel2.Controls.Add(btnPesquisar);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnInserir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(160, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 100);
            panel2.TabIndex = 2;
            // 
            // btnConfiguracao
            // 
            btnConfiguracao.Location = new Point(511, 26);
            btnConfiguracao.Name = "btnConfiguracao";
            btnConfiguracao.Size = new Size(46, 45);
            btnConfiguracao.TabIndex = 5;
            btnConfiguracao.Text = "button8";
            btnConfiguracao.UseVisualStyleBackColor = true;
            btnConfiguracao.Click += btnConfiguracao_Click_1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ForeColor = SystemColors.ActiveCaptionText;
            btnPesquisar.Location = new Point(423, 26);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(66, 45);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightGray;
            btnExcluir.Image = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz40;
            btnExcluir.ImageAlign = ContentAlignment.MiddleRight;
            btnExcluir.Location = new Point(172, 26);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(77, 45);
            btnExcluir.TabIndex = 2;
            btnExcluir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightGray;
            btnEditar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz40;
            btnEditar.ImageAlign = ContentAlignment.MiddleRight;
            btnEditar.Location = new Point(89, 26);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(77, 45);
            btnEditar.TabIndex = 1;
            btnEditar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.Gainsboro;
            btnInserir.Image = Properties.Resources.person_add_FILL0_wght400_GRAD0_opsz40;
            btnInserir.ImageAlign = ContentAlignment.MiddleRight;
            btnInserir.Location = new Point(6, 26);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(77, 45);
            btnInserir.TabIndex = 0;
            btnInserir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Azure;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(160, 100);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(581, 351);
            panelContainer.TabIndex = 3;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(741, 451);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria";
            FormClosed += TelaPrincipal_FormClosed;
            Load += TelaPrincipal_Load;
            Resize += FormPrincipal_Resize;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIconSystemTray;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem abrirAplicacaoToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Panel panelContainer;
        private Button btnIgrediente;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnFuncionario;
        private Button btnCliente;
        private Button btnCep;
        private Button btnProduto;
        private Button btnSabores;
        private Button btnValores;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnInserir;
        private Button btnConfiguracao;
        private Button btnPesquisar;
    }
}