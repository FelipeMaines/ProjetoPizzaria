using ProjetoPizzaria.Compartilhado;
using ProjetoPizzaria.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.ModuloCep
{
    public class ControladorCep : ControladorBase
    {
        private TabelaCep tabelaCep;
        public override string ToolTipInserir => "Cadastrar de Cep";

        public override string ToolTipEditar => "Editar Cep";

        public override string ToolTipExcluir => "Excluir Cep";

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
            TelaCepForm telaCepForm = new TelaCepForm();

            telaCepForm.ShowDialog();
        }

        public override UserControl ObterTabela()
        {
            if (tabelaCep == null)
                tabelaCep = new TabelaCep();

            return tabelaCep;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Cep";
        }
    }
}
