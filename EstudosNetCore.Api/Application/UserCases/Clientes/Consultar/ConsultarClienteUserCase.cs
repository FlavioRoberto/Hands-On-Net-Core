using EstudosNetCore.Api.Application.ViewModels;
using EstudosNetCore.Api.Domain.Services;
using System.Linq;

namespace EstudosNetCore.Api.Application.UserCases.Clientes.Consultar
{
    public class ConsultarClienteUserCase : IConsultarClienteUserCase
    {
        private readonly IClienteService _clienteService;

        public ConsultarClienteUserCase(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public ClienteViewModel Executar(string numeroDocumento)
        {
            var cliente = _clienteService.Consultar(numeroDocumento);

            var conta = cliente.Contas.FirstOrDefault();

            return new ClienteViewModel
            {
                Nome = cliente.Nome,
                DataNascimento = cliente.DataNascimento.ToShortDateString(),
                NumeroDocumento = cliente.NumeroDocumento,
                Agencia = conta?.Agencia,
                Conta = conta?.Numero,
                dac = conta?.Dac
            };
        }
    }
}
