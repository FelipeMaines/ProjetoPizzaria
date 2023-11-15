using ProjetoPizzaria.Compartilhado;
using ProjetoPizzariaDominio.ModuloSabor;
using ProjetoPizzariaDominio.ModuloValor;
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
    public partial class TabelaValores : UserControl
    {
        public TabelaValores()
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
            Name = "valorPizza",
            HeaderText = "Valor Pizza"
        },
        new DataGridViewTextBoxColumn()
        {
            Name = "valorBorda",
            HeaderText = "Valor Borda"
        },
        new DataGridViewTextBoxColumn()
        {
            Name = "categoria",
            HeaderText = "Categoria"
        },
        new DataGridViewTextBoxColumn()
        {
            Name = "tamanho",
            HeaderText = "Tamanho"
        }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Valor> listaValor)
        {
            grid.Rows.Clear();

            foreach (Valor item in listaValor)
            {
                grid.Rows.Add(item.id,
                            item.ValorPizza,
                            item.ValorBorda,
                            item.Categoria,
                            item.Tamanho);
            }

        }

        public Guid ObterIdSelecionado()
        {
            return grid.PegarId();
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == grid.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            else if (this.grid.Columns[e.ColumnIndex].Name.Equals("categoria"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()));
            }
            else if (this.grid.Columns[e.ColumnIndex].Name.Equals("tamanho"))
            {
                e.Value = EnumExtensions.GetDescription((EnumValorTamanho)char.Parse(e.Value.ToString()));
            }
        }
    }
}
