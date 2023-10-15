using ProjetoPizzaria.Compartilhado;
using ProjetoPizzariaDominio.ModuloEndereco;
using ProjetoPizzariaDominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria.ModuloFuncionario
{
    public partial class TabelaFuncionario : UserControl
    {
        public TabelaFuncionario()
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
                    HeaderText = "nome"
                },
                 new DataGridViewTextBoxColumn()
                {
                    Name = "matricula",
                    HeaderText = "Matricula"
                },
                     new DataGridViewTextBoxColumn()
                {
                    Name = "Cep",
                    HeaderText = "Endereco Id"
                },
                  new DataGridViewTextBoxColumn()
                {
                    Name = "Email",
                    HeaderText = "Email"
                },
                   new DataGridViewTextBoxColumn()
                {
                    Name = "Telefone",
                    HeaderText = "Telefone"
                },
                    new DataGridViewTextBoxColumn()
                {
                    Name = "Grupo",
                    HeaderText = "Grupo"
                }
            };

            grid.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Funcionario> Funcionarios)
        {
            grid.Rows.Clear();

            foreach (Funcionario item in Funcionarios)
                grid.Rows.Add(item.id,
                            item.Nome,
                            item.Matricula,
                            item.EnderecoId,
                            item.Email,
                            item.Telefone,
                            item.Grupo);
        }

        public int ObterIdSelecionado()
        {
            if (grid.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
