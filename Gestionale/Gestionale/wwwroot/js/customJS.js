function Search() {
  $("#SearchBar").on("keyup", function() {
    var value = $(this).val().toLowerCase();
    $(".bodySearch .trSearch").filter(function() {
      $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
    });
  });
};

