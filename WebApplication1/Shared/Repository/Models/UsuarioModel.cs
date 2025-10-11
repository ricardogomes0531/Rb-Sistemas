namespace Web.Shared.Repository.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int IdEmpresa { get; set; }
        public string Empresa { get; set; }
        public string Perfil { get; set; }
    }
}
