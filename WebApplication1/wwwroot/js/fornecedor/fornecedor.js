function validarCadastro()
{
if (document.form1.nome.value == "")
{
alert("Favor preencher o nome do fornecedor.");
}
else
{
document.form1.submit();
}

}