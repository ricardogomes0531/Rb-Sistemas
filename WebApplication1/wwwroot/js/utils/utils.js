function chamadaAutenticada(url) {
    $.ajax({
        type: 'GET',
        url: url,
        async: false,
        headers: {
            Authorization: "Bearer " + localStorage.getItem("token")
        }


    });

}

