    function validarCadastro()
{
        $.ajax({
            type: 'POST',
            url: "fornecedor/cadastrar",
            async: false,
data: {

},
            success: function (data) {
$("#resultadoResp").html(data);            
    }
              });
          
    }
    
