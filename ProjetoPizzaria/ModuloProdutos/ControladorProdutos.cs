using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.ModuloSabor;
using ProjetoPizzaria.ModuloValores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloProdutos
{
    public class ControladorProdutos : ControladorBase
    {
        private TabelaProdutos tabelaProdutos;
        public override string ToolTipInserir => "Cadastrar Produtos";

        public override string ToolTipEditar => "Editar Produtos";

        public override string ToolTipExcluir => "Excluir Produtos";

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
            var telaProduto = new TelaProdutoForm();

            telaProduto.ShowDialog();
        }

        public override UserControl ObterTabela()
        {
            if (tabelaProdutos == null)
                tabelaProdutos = new TabelaProdutos();

            return tabelaProdutos;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Produtos";
        }
    }
}
