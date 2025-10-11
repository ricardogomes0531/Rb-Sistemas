namespace Web.Shared.Repository.Querys
{
    public static class LoginQuery
    {
        public static string Buscar()
        {
            return @"select CodigoUsuario as CodigoUsuario, Nome as Nome, Password as Password, Perfil as Perfil, CodigoEmpresa as CodigoEmpresa, Empresa as Empresa from Usuarios where email=@email and password=@senha;";
        }
    }
}
