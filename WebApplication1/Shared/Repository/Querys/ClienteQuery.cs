namespace Web.Shared.Repository.Querys
{
    public static class ClienteQuery
    {
        public static string Inserir()
        {
            return @"insert into Cliente(nome, email, DddCelular, Celular, DataNascimento, DataInsersao, UsuarioInsersao, DataAlteracao, UsuarioAlteracao) values(@nome, @email, @DddCelular, @Celular, @DataNascimento, now(), @UsuarioInsersao, null, null);";
                    }

        public static string ListarTodos()
        {
            return @"select nome as Nome, Email as Email, DddCelular as DddCelular, Celular as Celular, DataNascimento as DataNascimento from Cliente;";
        }
    }
}
