function Global() {

    $("#SearchBar").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $(".bodySearch .trSearch").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });


    var select = document.getElementsByName("selecThis");

    $('button[name="btnChange"]').on('click', function () {
        var isDisabled = $(this).closest("div").find(select).prop('disabled');
        if (isDisabled == true) {
            $(this).closest("div").find(select).prop('disabled', false);
            this.setAttribute("class", "btn btn-success");
            this.innerHTML = "Salva";
        }
        else {
            $(this).closest("div").find(select).prop('disabled', true);
            this.setAttribute("class", "btn btn-primary");
            this.innerHTML = "Modifica";
        }
    });
}

