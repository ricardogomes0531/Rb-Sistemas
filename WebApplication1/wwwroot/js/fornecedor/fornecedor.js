    function salvar()
{
        $.ajax({
            type: 'POST',
            url: "/fornecedor/cadastrar",
            async: false,
data: {
Celular: document.form1.celular.value,
DddCelular: document.form1.dddCelular.value,
    DddTelefone: document.form1.dddTelefone.value,
    Telefone: document.form1.telefone.value,
Descricao: document.form1.descricao.value,
Email: "teste@teste.com",
FormaPagamentoPrincipal: document.form1.formaPagamento.value,
Nome: document.form1.nomeFornecedor.value,
Endereco: document.form1.endereco.value,
Bairro: document.form1.bairro.value,
Cidade: document.form1.cidade.value,
Uf: document.form1.estado.value,
Cep: document.form1.cep.value,
Documento: document.form1.documento.value
},
            success: function (data) {
alert("Cadastro bem-sucedido");
            }
                          });

    }
    
