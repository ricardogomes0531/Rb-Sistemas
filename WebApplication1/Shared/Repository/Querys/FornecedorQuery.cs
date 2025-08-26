namespace Web.Shared.Repository.Querys
{
    public static class FornecedorQuery
    {
        public static string Inserir()
        {
            return @"insert into fornecedor(idEstabelecimento, nome, descricao, email, ddd_celular, celular, ddd_telefone, telefone, documento, endereco, bairro, cidade, uf, cep, formaPagamentoPrincipal, dataInsersao, usuarioInsersao, dataAlteracao, usuarioAlteracao)
values(2, @Nome, @Descricao, @Email, @DddCelular, @Celular, @DddTelefone, @Telefone, @Documento, @Endereco, @Bairro, @Cidade, @Uf, @Cep, @FormaPagamentoPrincipal, now(), null, null, null);";
        }

        public static string ListarTodos()
        {
            return @"select nome as Nome, descricao as Descricao, email as Email, ddd_celular as DddCelular, celular as Celular, ddd_telefone as DddTelefone, telefone as Telefone, documento as Documento, endereco as Endereco, bairro as Bairro, cidade as Cidade, uf as Uf, cep as Cep, formaPagamentoPrincipal as FormaPagamentoPrincipal, dataInsersao as DataInsersao, usuarioInsersao as UsuarioInsersao, dataAlteracao as DataAlteracao, usuarioAlteracao as UsuarioAlteracao from fornecedor;";
        }
    }
}
