using ProjetoPizzaria.Compartilhado;
using ProjetoPizzariaDominio.ModuloIgrediente;
using ProjetoPizzariaDominio.ModuloSabor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria.ModuloSabor
{
    public partial class TabelaSabores : UserControl
    {
        public TabelaSabores()
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
        new DataGridViewImageColumn() // Use DataGridViewImageColumn para criar uma coluna de imagem
        {
            Name = "imagem",
            HeaderText = "Imagem"
        },
        new DataGridViewTextBoxColumn()
        {
            Name = "categoria",
            HeaderText = "Categoria"
        },
        new DataGridViewTextBoxColumn()
        {
            Name = "tipo",
            HeaderText = "Tipo"
        }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Sabor> listaSabores)
        {
            grid.Rows.Clear();

            foreach (Sabor item in listaSabores)
            {
                grid.Rows.Add(item.id,
                            item.Descricao,
                            item.Foto,
                            item.Categoria,
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
            else if (this.grid.Columns[e.ColumnIndex].Name.Equals("categoria"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()));
            }
            else if (this.grid.Columns[e.ColumnIndex].Name.Equals("tipo"))
            {
                e.Value = EnumExtensions.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()));
            }
            else if (this.grid.Columns[e.ColumnIndex].Name.Equals("valor"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }
    }
}
