using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.ModuloCep;
using ProjetoPizzaria.ModuloCliente;
using ProjetoPizzaria.ModuloFuncionario;
using ProjetoPizzaria.ModuloIgrediente;
using ProjetoPizzaria.ModuloLogin;
using ProjetoPizzaria.ModuloPedidos;
using ProjetoPizzaria.ModuloProdutos;
using ProjetoPizzaria.ModuloSabor;
using ProjetoPizzaria.ModuloValores;
using System.Configuration;

namespace ProjetoPizzaria
{
    public partial class TelaPrincipal : Form
    {
        private ControladorBase controlador;
        private static TelaPrincipal telaPrincipal;
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
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
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
            controlador = new ControladorIgrediente();

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelRegistros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            controlador = new ControladorIgrediente();

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
           // remove todos os controles e recria a tela, aplicando assim o novo idioma

            string idiomaAtual = ConfigurationManager.AppSettings.Get("IdiomaRegiao");

            if (!LinguagemSelecionada.fechaAplicacao)
            {
                Application.Restart();
                Environment.Exit(0);
            }
            else
            {
                Controls.Clear();
                InitializeComponent();
            }
        }
    }
}