namespace Web.Shared.Repository.Models
{
    public class FornecedorModel
    {
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public string Email { get; set; }
                public int DddCelular { get; set; }
        public string Celular { get; set; }
        public int DddTelefone { get; set; }
        public string Telefone { get; set; }
                public string FormaPagamentoPrincipal { get; set; }
        public string Documento { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }

    }
}
