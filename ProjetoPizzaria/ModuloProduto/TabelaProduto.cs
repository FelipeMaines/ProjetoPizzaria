using ProjetoPizzaria.Compartilhado;
using ProjetoPizzariaDominio.ModuloProduto;
using ProjetoPizzariaDominio.ModuloSabor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria.ModuloProduto
{
    public partial class TabelaProduto : UserControl
    {
        public TabelaProduto()
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
            Name = "descricao",
            HeaderText = "Descrição"
        },
        new DataGridViewTextBoxColumn()
        {
            Name = "valor",
            HeaderText = "Valor"
        },
        new DataGridViewTextBoxColumn()
        {
            Name = "ml",
            HeaderText = "ML"
        },
        new DataGridViewTextBoxColumn()
        {
            Name = "tipo",
            HeaderText = "Tipo"
        }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Produto> listarProdutos)
        {
            grid.Rows.Clear();

            foreach (Produto item in listarProdutos)
            {
                grid.Rows.Add(item.id,
                            item.Descricao,
                            item.Valor,
                            item.ML,
                            item.Tipo);
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
            else if (this.grid.Columns[e.ColumnIndex].Name.Equals("Refrigerante"))
            {
                e.Value = EnumExtensions.GetDescription((EnumProdutoTipo)char.Parse(e.Value.ToString()));
            }
            else if (this.grid.Columns[e.ColumnIndex].Name.Equals("Cerveja"))
            {
                e.Value = EnumExtensions.GetDescription((EnumProdutoTipo)char.Parse(e.Value.ToString()));
            }
            else if (this.grid.Columns[e.ColumnIndex].Name.Equals("Suco"))
            {
                e.Value = EnumExtensions.GetDescription((EnumProdutoTipo)char.Parse(e.Value.ToString()));
            }
            else if (this.grid.Columns[e.ColumnIndex].Name.Equals("Agua"))
            {
                e.Value = EnumExtensions.GetDescription((EnumProdutoTipo)char.Parse(e.Value.ToString()));

            }
            else if (this.grid.Columns[e.ColumnIndex].Name.Equals("Outros"))
            {
                e.Value = EnumExtensions.GetDescription((EnumProdutoTipo)char.Parse(e.Value.ToString()));

            }
        }
    }
}
