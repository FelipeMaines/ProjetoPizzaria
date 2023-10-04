using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.ModuloProdutos;
using ProjetoPizzaria.ModuloSabor;
using ProjetoPizzariaDominio.ModuloIgrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloIgrediente
{
    public class ControladorIgrediente : ControladorBase
    {
        IRepositorioIgrediente repositorioIgrediente;
        private TabelaIgredientes tabelaIgredientes;
        public ControladorIgrediente(IRepositorioIgrediente repositorioIgrediente)
        {
            this.tabelaIgredientes = new TabelaIgredientes();
            this.repositorioIgrediente = repositorioIgrediente;
        }

        public override string ToolTipInserir => "Cadastrar Igrediente";

        public override string ToolTipEditar => "Editar Igrediente";

        public override string ToolTipExcluir => "Excluir Igrediente";

        public override void CarregarItens()
        {
            tabelaIgredientes.AtualizarRegistros(repositorioIgrediente.SelecionarTodos());
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            var telaIgrediente = new TelaIgredienteForm();

            if(telaIgrediente.ShowDialog() == DialogResult.OK)
            {
                repositorioIgrediente.Inserir(telaIgrediente.igrediente);
            }

            tabelaIgredientes.AtualizarRegistros(repositorioIgrediente.SelecionarTodos());
        }

        public override UserControl ObterTabela()
        {
            if (tabelaIgredientes == null)
                tabelaIgredientes = new TabelaIgredientes();

            return tabelaIgredientes;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Igredientes";
        }
    }
}
