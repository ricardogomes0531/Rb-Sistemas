namespace Web.Shared.Repository.Querys
{
    public static class UserQuery
    {
        public static string GetUserByIdQuery()
        {
            return @"select * from usuarios;";
        }
    }
}
