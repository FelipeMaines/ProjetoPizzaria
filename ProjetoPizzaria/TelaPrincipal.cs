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

namespace ProjetoPizzaria
{
    public partial class TelaPrincipal : Form
    {
        private ControladorBase controlador;
        private static TelaPrincipal telaPrincipal;
        public TelaPrincipal()
        {
            InitializeComponent();

            #region idioma/regi�o interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            telaPrincipal = this;

            FazerLogin();

        }
        /// <summary>
        /// Abre a tela de login e valida usuario
        /// </summary>
        private static void FazerLogin()
        {
            telaPrincipal.Visible = false;

            TelaLoginForm telaLoginForm = new TelaLoginForm();

            if (telaLoginForm.ShowDialog() == DialogResult.OK)
                telaPrincipal.Visible = true;
        }
        /// <summary>
        /// Configura toda a tela de acordo com o controlador referenciado
        /// </summary>
        /// <param name="controlador">Controlaodr da tela referenciada</param>
        public void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            this.controlador = controlador;

            toolStripLabel1.Text = controlador.ObterTipoCadastro();

            ConfigurarToolTips(controlador);

            ConfigurarTabela(controlador);

            ConfigurarEstados(controlador);
        }
        /// <summary>
        /// Pega uma instancia da tela principal static
        /// </summary>
        public static TelaPrincipal Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipal();

                return telaPrincipal;
            }
        }
        /// <summary>
        /// Configura o estado dos botoes da tela referenciada
        /// </summary>
        /// <param name="controlador">controlaodr da tela referenciada</param>
        private void ConfigurarEstados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
        }
        /// <summary>
        /// Configura as ToolTipText dos botoes de acordo com a tela
        /// </summary>
        /// <param name="controlador">controlador da tela referenciada</param>
        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }
        /// <summary>
        /// Configura a tabela da tela referenciada
        /// </summary>
        /// <param name="controlador">controlador da tela referenciada</param>
        private void ConfigurarTabela(ControladorBase controlador)
        {
            UserControl listagem = controlador.ObterTabela();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }
        /// <summary>
        /// Com o click seleciona o controlador do item clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCep();

            ConfigurarTelaPrincipal(controlador);
        }
        /// <summary>
        /// Com o click seleciona o controlador do item clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorFuncionario();

            ConfigurarTelaPrincipal(controlador);
        }
        /// <summary>
        /// Com o click seleciona o controlador do item clicado e chama o metodo de configurarTelaPrincipal passando o controlaodr selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente();

            ConfigurarTelaPrincipal(controlador);
        }
        /// <summary>
        /// Com o click seleciona o controlador do item clicado e chama o metodo de configurarTelaPrincipal passando o controlaodr selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void igredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorIgrediente();

            ConfigurarTelaPrincipal(controlador);
        }
        /// <summary>
        /// Com o click seleciona o controlador do item clicado e chama o metodo de configurarTelaPrincipal passando o controlaodr selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saboresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorSabores();

            ConfigurarTelaPrincipal(controlador);
        }
        /// <summary>
        /// Com o click seleciona o controlador do item clicado e chama o metodo de configurarTelaPrincipal passando o controlaodr selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void valoresPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorValores();

            ConfigurarTelaPrincipal(controlador);
        }
        /// <summary>
        /// Com o click seleciona o controlador do item clicado e chama o metodo de configurarTelaPrincipal passando o controlaodr selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorProdutos();

            ConfigurarTelaPrincipal(controlador);
        }
        /// <summary>
        /// Com o click seleciona o controlador do item clicado e chama o metodo de configurarTelaPrincipal passando o controlaodr selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorPedidos();

            ConfigurarTelaPrincipal(controlador);
        }
        /// <summary>
        /// Com o click no botao de inserir, chama o metodo de inserir do controlador selecionado anteriormente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma �rea primeiro!", "Selecione uma �rea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controlador.Inserir();
        }
        /// <summary>
        /// Com o click no botao de editar, chama o metodo de editar do controlador selecionado anteriormente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma �rea primeiro!", "Selecione uma �rea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            controlador.Editar();
        }
        /// <summary>
        /// Com o click no botao de excluir, chama o metodo de excluir do controlador selecionado anteriormente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma �rea primeiro!", "Selecione uma �rea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            controlador.Excluir();
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
    }
}