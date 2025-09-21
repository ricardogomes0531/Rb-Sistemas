using Web.Shared.Domain;

namespace Web.Models.Cliente
{
    public class ClienteRequest : Base
    {
        public string Nome { get; set; }

        public string Sexo { get; set; }

        public string Email { get; set; }

        public string DddCelular { get; set; }

        public string Celular { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}