using Web.Shared.Domain;

namespace Web.Shared.Repository.Models
{
    public class ClienteModel : Base
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string DddCelular { get; set; }

        public string Celular { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}