function salvar() {
    $.ajax({
        type: 'POST',
        url: "/clientes/cadastrar",
        async: false,
        data: {
            Celular: document.form1.celular.value,
            DddCelular: document.form1.dddCelular.value,
            Email: document.form1.email.value,
            Nome: document.form1.nome.value,
            Sexo: document.form1.sexo.value,
            DataNascimento: document.form1.dataNascimento.value
                    },
        success: function (data) {
            alert("Cadastro bem-sucedido");
        }
    });

}

