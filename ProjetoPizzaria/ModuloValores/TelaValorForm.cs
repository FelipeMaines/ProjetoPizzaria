using ProjetoPizzaria.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria.ModuloValores
{
    public partial class TelaValorForm : Form
    {
        public TelaValorForm()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            EventTarget();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

        }

        private void EventTarget()
        {
            txValor.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txValor.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txValorBorda.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txValorBorda.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txId.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txId.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            listBoxTamanho.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            listBoxTamanho.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            listBoxCategoria.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            listBoxCategoria.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
        }
    }
}
