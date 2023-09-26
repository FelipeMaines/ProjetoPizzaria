using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria.ModuloProdutos
{
    public partial class TelaProdutoForm : Form
    {
        public TelaProdutoForm()
        {
            InitializeComponent();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            EventTarget();
        }

        private void EventTarget()
        {
            ListBoxMedida.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            ListBoxMedida.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            ListBoxTipo.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            ListBoxTipo.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txNome.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txNome.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txId.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txId.Leave += new EventHandler(Funcoes.CampoEventoLeave!);

            txValor.Enter += new EventHandler(Funcoes.CampoEventoEnter!);
            txValor.Leave += new EventHandler(Funcoes.CampoEventoLeave!);
        }
    }
}
