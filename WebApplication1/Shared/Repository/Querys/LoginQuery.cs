namespace Web.Shared.Repository.Querys
{
    public static class LoginQuery
    {
        public static string Buscar()
        {
            return @"select CodigoUsuario as Id, Nome as Nome, Password as Senha, Perfil as Perfil, CodigoEmpresa as IdEmpresa from Usuarios where Email=@email and Password=@senha;";
        }
    }
}
