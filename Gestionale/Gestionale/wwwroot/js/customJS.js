function Global() {

    $("#SearchBar").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $(".bodySearch .trSearch").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });


    var select = document.getElementsByName("selecThis");

    $('.btnChange').on('click', function () {
        var isDisabled = $(this).closest("tr").find(select).prop('disabled');
        if (isDisabled == true) {
            $(this).closest("tr").find(select).prop('disabled', false);
            this.setAttribute("class", "btn btn-success .btnChange");
            this.innerHTML = "Salva";
        }
        else {
            $(this).closest("tr").find(select).prop('disabled', true);
            this.setAttribute("class", "btn btn-primary .btnChange");
            this.innerHTML = "Modifica";
        }
    });

    $('.arrowBack').on('click', function () {
        window.history.back();
    })
}

