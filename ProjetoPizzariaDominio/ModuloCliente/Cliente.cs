using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int EnderecoId { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        public Cliente(int id, string nome, string cpf, string telefone, string email, int enderecoId, string numero, string complemento)
        {
            this.id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            EnderecoId = enderecoId;
            Numero = numero;
            Complemento = complemento;
        }

        public Cliente(string nome, string cpf, string telefone, string email, int enderecoId, string numero, string complemento)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            EnderecoId = enderecoId;
            Numero = numero;
            Complemento = complemento;
        }

        public Cliente()
        {
        }
    }
}
