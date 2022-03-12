using EstudosNetCore.Api.Domain.Entities;

namespace EstudosNetCore.Api.Domain.Services
{
    public interface IClienteService
    {
        Cliente Consultar(string numero_documento);
    }
}
