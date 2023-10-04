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

        public Igrediente igrediente { get; set; }

        private void EventoTarget()
        {
            txId.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txId.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
        }

        public Igrediente PegarIgrendiente()
        {
            string nome = txNome.Text;
            return new Igrediente(nome);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            igrediente = PegarIgrendiente();
        }
    }
}
