using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.infra.ModuloIgrediente;
using ProjetoPizzaria.ModuloCep;
using ProjetoPizzaria.ModuloCliente;
using ProjetoPizzaria.ModuloFuncionario;
using ProjetoPizzaria.ModuloIgrediente;
using ProjetoPizzaria.ModuloLogin;
using ProjetoPizzaria.ModuloPedidos;
using ProjetoPizzaria.ModuloProdutos;
using ProjetoPizzaria.ModuloSabor;
using ProjetoPizzaria.ModuloValores;
using ProjetoPizzariaDominio.ModuloIgrediente;
using System.Configuration;

namespace ProjetoPizzaria
{
    public partial class TelaPrincipal : Form
    {
        private ControladorBase controlador;
        private static TelaPrincipal telaPrincipal;

        IRepositorioIgrediente repositorioIgrediente = new RepositorioIgrendiente();

        public TelaPrincipal()
        {
            ConfigurarLinguagem();

            InitializeComponent();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            telaPrincipal = this;

            FazerLogin();

        }

        private static void FazerLogin()
        {
            telaPrincipal.Visible = false;

            TelaLoginForm telaLoginForm = new TelaLoginForm();

            if (telaLoginForm.ShowDialog() == DialogResult.OK)
                telaPrincipal.Visible = true;
        }

        public void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            this.controlador = controlador;

            toolStripLabel1.Text = controlador.ObterTipoCadastro();

            ConfigurarToolTips(controlador);

            ConfigurarTabela(controlador);

            ConfigurarEstados(controlador);
        }

        public static TelaPrincipal Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipal();

                return telaPrincipal;
            }
        }

        private void ConfigurarEstados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }

        private void ConfigurarTabela(ControladorBase controlador)
        {
            UserControl listagem = controlador.ObterTabela();
            listagem.Dock = DockStyle.Fill;

            panelContainerTabela.Dock = DockStyle.None;
            panelContainerTabela.Visible = true;
            panelContainerTabela.Controls.Add(listagem);
            listagem.BringToFront();
        }

        private void cepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCep();

            ConfigurarTelaPrincipal(controlador);
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorFuncionario();

            ConfigurarTelaPrincipal(controlador);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente();

            ConfigurarTelaPrincipal(controlador);
        }

        private void igredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorIgrediente(repositorioIgrediente);

            ConfigurarTelaPrincipal(controlador);
        }

        private void saboresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorSabores();

            ConfigurarTelaPrincipal(controlador);
        }

        private void valoresPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorValores();

            ConfigurarTelaPrincipal(controlador);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorProdutos();

            ConfigurarTelaPrincipal(controlador);
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorPedidos();

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma área primeiro!", "Selecione uma Área", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma área primeiro!", "Selecione uma Área", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma área primeiro!", "Selecione uma Área", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            controlador.Excluir();
        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCep();

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            controlador = new ControladorFuncionario();

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente();

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            controlador = new ControladorProdutos();

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnIgredientes_Click(object sender, EventArgs e)
        {
            controlador = new ControladorIgrediente(repositorioIgrediente);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnSabores_Click(object sender, EventArgs e)
        {
            controlador = new ControladorSabores();

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnValores_Click(object sender, EventArgs e)
        {
            controlador = new ControladorValores();

            ConfigurarTelaPrincipal(controlador);
        }

        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            ConfigurarLinguagem();
        }

        private void ConfigurarLinguagem()
        {
            FormConfiguracoes config = new()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            _ = config.ShowDialog();

            string idiomaAtual = ConfigurationManager.AppSettings.Get("IdiomaRegiao");

            Controls.Clear();
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    controlador = new ControladorFuncionario();

                    ConfigurarTelaPrincipal(controlador);
                    break;
                case Keys.F3:
                    controlador = new ControladorCep();

                    ConfigurarTelaPrincipal(controlador);
                    break;
                case Keys.F4:
                    controlador = new ControladorCliente();

                    ConfigurarTelaPrincipal(controlador);
                    break;
                case Keys.F5:
                    controlador = new ControladorProdutos();

                    ConfigurarTelaPrincipal(controlador);
                    break;
                case Keys.F6:
                    controlador = new ControladorIgrediente(repositorioIgrediente);

                    ConfigurarTelaPrincipal(controlador);
                    break;
                case Keys.F7:
                    controlador = new ControladorSabores();

                    ConfigurarTelaPrincipal(controlador);
                    break;
                case Keys.F8:
                    controlador = new ControladorValores();

                    ConfigurarTelaPrincipal(controlador);
                    break;
                case Keys.F9:
                    ConfigurarLinguagem();
                    break;
                case Keys.Delete:
                    Application.Exit();
                    break;
            }
        }

        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
                notifyIconSystemTray.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }

        private void panelRegistros_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void abrirAplicacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            WindowState = FormWindowState.Minimized;
            notifyIconSystemTray.Visible = true;
        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void contextMenuStrip1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }
    }
}