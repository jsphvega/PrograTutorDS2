function confirmarSalida() {
    var ask = window.confirm("¿Está seguro? Se perderán los datos");

    if (ask) {
        document.location.href = "login.aspx";
    }

    return !ask;
}

function confirmarCierre() {
    var ask = window.confirm("¿Está seguro de cerrar sesión?");

    if (ask) {
        document.location.href = "login.aspx";
    }

    return !ask;
}