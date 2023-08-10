using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.ModuloCep;
using ProjetoPizzaria.ModuloCliente;
using ProjetoPizzaria.ModuloFuncionario;
using ProjetoPizzaria.ModuloIgrediente;
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
                MessageBox.Show("Selecione uma �rea primeiro!", "Selecione uma �rea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma �rea primeiro!", "Selecione uma �rea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma �rea primeiro!", "Selecione uma �rea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            controlador.Excluir();
        }
    }
}