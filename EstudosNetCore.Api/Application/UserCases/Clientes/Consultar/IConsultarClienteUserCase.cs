using EstudosNetCore.Api.Application.ViewModels;

namespace EstudosNetCore.Api.Application.UserCases.Clientes.Consultar
{
    public interface IConsultarClienteUserCase
    {
        ClienteViewModel Executar(string numeroDocumento);
    }
}
