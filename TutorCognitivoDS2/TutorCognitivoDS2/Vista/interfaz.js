function ConfirmarSalidaRegistro() {
    var seleccion = confirm("¿Está seguro? Se perderán los datos");

    if (seleccion)
        window.locationf = "login.aspx";

    return seleccion;
}