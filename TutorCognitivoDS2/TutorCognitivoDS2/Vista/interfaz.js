function ConfirmarSalidaRegistro() {
    var seleccion = confirm("¿Está seguro? Se perderán los datos");

    if (seleccion) {
        Response.Redirect("login.aspx");
    }
}