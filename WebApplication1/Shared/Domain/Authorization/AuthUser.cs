namespace Web.Shared.Domain.Authorization
{
    public class AuthUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int IdEmpresa { get; set; }
        public string Empresa { get; set; }
        public string[] Roles { get; set; }
    }
}
