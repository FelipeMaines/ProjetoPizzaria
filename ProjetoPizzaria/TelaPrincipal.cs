using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.Compartilhado.Ioc;
using ProjetoPizzaria.ModuloCep;
using ProjetoPizzaria.ModuloCliente;
using ProjetoPizzaria.ModuloFuncionario;
using ProjetoPizzaria.ModuloIgrediente;
using ProjetoPizzaria.ModuloLogin;
using ProjetoPizzaria.ModuloSabor;
using ProjetoPizzaria.ModuloValores;
using System.Configuration;

namespace ProjetoPizzaria
{
    public partial class TelaPrincipal : Form
    {
        private ControladorBase controlador;
        private static TelaPrincipal telaPrincipal;
        private Ioc Ioc;

        public TelaPrincipal()
        {
            ConfigurarLinguagem();


            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            //InitializeComponent();

            telaPrincipal = this;

            FazerLogin();

            this.Ioc = new IocComInjecaoDependecia();
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

            //labelToStrip.Text = controlador.ObterTipoCadastro();

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
            //btnInserir. = controlador.ToolTipInserir;
            //btnEditar.ToolTipText = controlador.ToolTipEditar;
            //btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }

        private void ConfigurarTabela(ControladorBase controlador)
        {
            UserControl listagem = controlador.ObterTabela();
            listagem.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(listagem);
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

        private void btnFuncionario_Click_1(object sender, EventArgs e)
        {
            //controlador = new ControladorFuncionario(repositorioEndereco, repositorioFuncionario);

            ConfigurarTelaPrincipal(this.Ioc.Get<ControladorFuncionario>());
        }

        private void btnCep_Click(object sender, EventArgs e)
        {
            //controlador = new ControladorCep(repositorioEndereco);

            ConfigurarTelaPrincipal(this.Ioc.Get<ControladorCep>());
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            //controlador = new ControladorCliente(repositorioEndereco, repositorioCliente);

            ConfigurarTelaPrincipal(this.Ioc.Get<ControladorCliente>());
        }

        private void btnIgrediente_Click(object sender, EventArgs e)
        {
            //controlador = new ControladorIgrediente(repositorioIgrediente);

            ConfigurarTelaPrincipal(this.Ioc.Get<ControladorIgrediente>());
        }

        private void btnSabores_Click_1(object sender, EventArgs e)
        {
            //controlador = new ControladorSabores(repositorioSabor, repositorioIgrediente);

            ConfigurarTelaPrincipal(this.Ioc.Get<ControladorSabores>());
        }

        private void btnValores_Click_1(object sender, EventArgs e)
        {
            //controlador = new ControladorValores();

            ConfigurarTelaPrincipal(this.Ioc.Get<ControladorValores>());
        }

        private void btnConfiguracao_Click_1(object sender, EventArgs e)
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(controlador == null)
            {
                MessageBox.Show("Selecione uma area primeiro!");
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                controlador.CarregarItens();
                return;
            }

            controlador.Pesquisar(textBox1.Text);
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    ConfigurarTelaPrincipal(Ioc.Get<ControladorFuncionario>());
                    break;

                case Keys.F3:
                    ConfigurarTelaPrincipal(this.Ioc.Get<ControladorCep>());
                    break;

                case Keys.F4:
                    ConfigurarTelaPrincipal(this.Ioc.Get<ControladorCliente>());
                    break;

                case Keys.F6:
                    ConfigurarTelaPrincipal(this.Ioc.Get<ControladorIgrediente>());
                    break;

                case Keys.F7:
                    ConfigurarTelaPrincipal(this.Ioc.Get<ControladorSabores>());
                    break;
                case Keys.F8:
                    ConfigurarTelaPrincipal(this.Ioc.Get<ControladorValores>());
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