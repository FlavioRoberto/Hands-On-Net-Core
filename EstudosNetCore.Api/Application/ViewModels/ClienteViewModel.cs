using System.Text.Json.Serialization;

namespace EstudosNetCore.Api.Application.ViewModels
{
    public class ClienteViewModel
    {
        public string Nome { get; set; }
        [JsonPropertyName("data_nascimento")]
        public string DataNascimento { get; set; }
        [JsonPropertyName("numero_documento")]
        public string NumeroDocumento { get; set; }
        public int? Agencia { get; set; }
        public string Conta { get; set; }
        public int? dac { get; set; }
    }
}
