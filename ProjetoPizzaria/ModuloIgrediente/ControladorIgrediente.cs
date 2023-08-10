using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.ModuloProdutos;
using ProjetoPizzaria.ModuloSabor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloIgrediente
{
    public class ControladorIgrediente : ControladorBase
    {
        private TabelaIgredientes tabelaIgredientes;
        public override string ToolTipInserir => "Cadastrar Igrediente";

        public override string ToolTipEditar => "Editar Igrediente";

        public override string ToolTipExcluir => "Excluir Igrediente";

        public override void CarregarItens()
        {
            throw new NotImplementedException();
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

            telaIgrediente.ShowDialog();
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
