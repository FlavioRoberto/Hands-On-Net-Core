using EstudosNetCore.Api.Domain.Entities;
using EstudosNetCore.Api.Domain.Services;
using System;

namespace EstudosNetCore.Api.Infra.Services
{
    public class ClienteHttpService : IClienteService
    {
        public Cliente Consultar(string numero_documento)
        {
            var cliente = new Cliente("Alan", new DateTime(1991, 02, 23), numero_documento);

            cliente.AdicionarConta(new Conta(1500, "01012", 7));

            return cliente;
        }
    }


}
