function entrar() {
    $.ajax({
        type: 'POST',
        url: "/login/login",
        async: false,
        data: {
            email: document.form1.email.value,
            senha: document.form1.senha.value
        },
        success: function (data) {
            document.cookie = "jwtToken=" + data.token + "; path=/";
            window.location.href = "/home";
        }
    });

}

