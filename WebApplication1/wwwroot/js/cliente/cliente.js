function salvar() {
    $.ajax({
        type: 'POST',
        url: "/clientes/cadastrar",
        async: false,
        data: {
            Celular: document.form1.celular.value,
            DddCelular: document.form1.dddCelular.value,
            Email: "teste@teste.com",
            Nome: document.form1.nome.value,
            DataNascimento: document.form1.dataNascimento.value
                    },
        success: function (data) {
            alert("Cadastro bem-sucedido");
        }
    });

}

