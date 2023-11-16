using Microsoft.Identity.Client;
using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.infra.ModuloIgrediente;
using ProjetoPizzariaDominio.ModuloIgrediente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria.ModuloIgrediente
{
    public partial class TelaIgredienteForm : Form
    {
        public Ingrediente igrediente { get; set; }
        public TelaIgredienteForm()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            EventoTarget();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        public TelaIgredienteForm(Ingrediente igrediente) : this()
        {
            this.igrediente = igrediente;
            SetarTela();
        }


        private void EventoTarget()
        {
            txId.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txId.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
        }

        public void PegarIgrendiente(bool edicao = false)
        {
            string nome = txNome.Text;

            if (!edicao)
                igrediente.nome = nome;

            else
            {
                Guid id = Guid.Parse(txId.Text);
                igrediente.id = id;
                igrediente.nome = nome;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            PegarIgrendiente();
        }

        private void SetarTela()
        {
            txId.Text = igrediente.id.ToString();
            txNome.Text = igrediente.nome;
        }
    }
}
