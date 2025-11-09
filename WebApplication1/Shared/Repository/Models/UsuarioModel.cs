namespace Web.Shared.Repository.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int CodigoEmpresa { get; set; }
        public string Empresa { get; set; }
        public string Perfil { get; set; }
    }
}
