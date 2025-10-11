namespace Web.Shared.Repository.Querys
{
    public static class ClienteQuery
    {
        public static string Inserir()
        {
            return @"insert into Cliente(nome, email, DddCelular, Celular, DataNascimento, Sexo, DataInsersao, UsuarioInsersao, DataAlteracao, UsuarioAlteracao) values(@nome, @email, @DddCelular, @Celular, @DataNascimento, @Sexo, now(), @UsuarioInsersao, null, null);";
                    }

        public static string ListarTodos()
        {
            return @"select nome as Nome, Sexo as Sexo, Email as Email, DddCelular as DddCelular, Celular as Celular, DataNascimento as DataNascimento, DataInsersao as DataInsersao, UsuarioInsersao as UsuarioInsersao, DataAlteracao as DataAlteracao, UsuarioAlteracao as UsuarioAlteracao from Cliente;";
        }
    }
}
