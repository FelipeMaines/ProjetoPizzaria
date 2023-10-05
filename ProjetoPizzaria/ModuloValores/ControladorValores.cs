using ProjetoPizzaria.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloValores
{
    public class ControladorValores : ControladorBase
    {
        private TabelaValores tabelaValores;
        public override string ToolTipInserir => "Cadastrar Valores";

        public override string ToolTipEditar => "Editar Valores";

        public override string ToolTipExcluir => "Excluir Valores";

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
            TelaValorForm telaValoresForm = new TelaValorForm();

            telaValoresForm.ShowDialog();
        }

        public override UserControl ObterTabela()
        {
            if (tabelaValores == null)
                tabelaValores = new TabelaValores();

            return tabelaValores;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Valores";
        }

        public override void Pesquisar(string texto)
        {
            throw new NotImplementedException();
        }
    }
}
