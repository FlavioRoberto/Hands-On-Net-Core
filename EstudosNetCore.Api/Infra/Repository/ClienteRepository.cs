using EstudosNetCore.Api.Domain.Entities;
using EstudosNetCore.Api.Domain.Services;
using System;

namespace EstudosNetCore.Api.Infra.Repository
{
    public class ClienteRepository : IClienteService
    {
        public Cliente Consultar(string numero_documento)
        {
            return new Cliente("Flávio", new DateTime(1996, 03, 22), "123");
        }
    }
}
