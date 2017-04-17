$(document).ready(function () {

    Pace.on('start', function () {
        //algo
    });
    Pace.on('done', function () {
        $.get("http://localhost:64954/default/Validacion", function (data) {
          
            if (data === true) {
                //Pagina luego de logearte
                window.location = "Default/Autentificado";
            }

            if (data === false) {
                //Pagina de Login -> Index
                window.location = "Default/Index";
            }
        });
      
    });

});

