using EstudosNetCore.Api.Domain.DomainObjects;
using System;
using System.Collections.Generic;

namespace EstudosNetCore.Api.Domain.Entities
{
    public class Cliente : IEntity
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NumeroDocumento { get; set; }
        public IList<Conta> Contas { get; set; }

        public Cliente(string nome, DateTime dataNascimento, string numeroDocumento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            NumeroDocumento = numeroDocumento;
            Contas = new List<Conta>();
        }

        public void AdicionarConta(Conta conta)
        {
            Contas.Add(conta);
        }
    }
}
