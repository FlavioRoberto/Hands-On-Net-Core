using EstudosNetCore.Api.Domain.DomainObjects;

namespace EstudosNetCore.Api.Domain.Entities
{
    public class Conta : IEntity
    {
        public int Agencia { get; set; }
        public string Numero { get; set; }
        public int Dac { get; set; }

        public Conta(int agencia, string numero, int dac)
        {
            Agencia = agencia;
            Numero = numero;
            Dac = dac;
        }
    }
}
