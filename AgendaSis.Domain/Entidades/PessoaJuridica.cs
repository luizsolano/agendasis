﻿using System;

namespace AgendaSis.Domain.Entidades
{
    public class PessoaJuridica : Pessoa
    {
        protected PessoaJuridica() { }

        public PessoaJuridica(string nome, string telefone, string endereco, string email, string cnpj, string razaoSocial, DateTime dataAbertura)
            : base(nome, telefone, endereco, email)
        {
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            DataAbertura = dataAbertura;
        }

        public string Cnpj { get; protected set; }
        public string RazaoSocial { get; protected set; }
        public DateTime DataAbertura { get; protected set; }
    }
}
