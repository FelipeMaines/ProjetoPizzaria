using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.ModuloValores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloSabor
{
    public class ControladorSabores : ControladorBase
    {
        private TabelaSabores tabelaSabores;
        public override string ToolTipInserir => "Cadastrar Sabores";

        public override string ToolTipEditar => "Editar Sabores";

        public override string ToolTipExcluir => "Excluir Sabores";

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
            var telaValoresForm = new TelaSaborForm();

            telaValoresForm.ShowDialog();
        }

        public override UserControl ObterTabela()
        {
            if(tabelaSabores == null)
                tabelaSabores = new TabelaSabores();

            return tabelaSabores;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Sabores";
        }
    }
}
