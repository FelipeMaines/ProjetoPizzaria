using ProjetoPizzaria.Compartilhado;
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
    public partial class TabelaIgredientes : UserControl
    {
        public TabelaIgredientes()
        {
            InitializeComponent();
            ConfigurarColunas();

            #region idioma/região interface - satellite assembly

            Funcoes.AjustaResourcesControl(this);

            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

            ConfiguracaoGrid.ConfigurarGridSomenteLeitura(this.grid);
            ConfiguracaoGrid.ConfigurarGridZebrado(this.grid);
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText = "Nome"
                }
            };

            grid.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Ingrediente> listaIgredientes)
        {
            grid.Rows.Clear();

            foreach (Ingrediente item in listaIgredientes)
                grid.Rows.Add(item.id,
                            item.nome);
        }

        public Guid ObterIdSelecionado()
        {
            return grid.PegarId();
        }
    }
}
