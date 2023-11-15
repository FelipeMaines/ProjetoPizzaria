﻿using ProjetoPizzariaDominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzariaDominio.ModuloEndereco
{
    public class Endereco : EntidadeBase<Endereco>
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public Endereco()
        {
            
        }
        public Endereco(Guid id, string cep, string logradouro, string bairro, string cidade)
        {
            this.id = id;
            Cep = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
        }

        public Endereco(string pais, string cep, string logradouro, string bairro, string cidade, string estado)
        {
            Pais = pais;
            Cep = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
