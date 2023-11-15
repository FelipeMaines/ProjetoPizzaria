using ProjetoPizzariaDominio.Compartilhado;
using ProjetoPizzariaDominio.ModuloEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloFuncionario
{
    public class Funcionario : EntidadeBase<Funcionario>
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public string Senha { get; set; }
        public char Grupo { get; set; }
        public string Motorista { get; set; }
        public DateTime Validade { get; set; }
        public string Observacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        public Endereco endereco { get; set; }

        public Funcionario()
        {
            
        }
        public Funcionario(Endereco endereco, Guid id, string nome = "", string cpf = "", string matricula = "", string senha = "", char grupo = default, string
        motorista = "", DateTime validade_motorista = default, string observacao = "", string telefone = "", string email = "", int endereco_id = 0,
        string numero = "", string complemento = "")
        {
            this.id = id;
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            Senha = senha;
            Grupo = grupo;
            Motorista = motorista;
            Validade = validade_motorista;
            Observacao = observacao;
            Telefone = telefone;
            Email = email;
            Numero = numero;
            Complemento = complemento;
            this.endereco = endereco;
        }

        public Funcionario(string nome = "", string cpf = "", string matricula = "", string senha = "", char grupo = default, string
       motorista = "", DateTime validade_motorista = default, string observacao = "", string telefone = "", string email = "", int endereco_id = 0,
       string numero = "", string complemento = "")
        {
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            Senha = senha;
            Grupo = grupo;
            Motorista = motorista;
            Validade = validade_motorista;
            Observacao = observacao;
            Telefone = telefone;
            Email = email;
            Numero = numero;
            Complemento = complemento;
            
        }
    }
}
