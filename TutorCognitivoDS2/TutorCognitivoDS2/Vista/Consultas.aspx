<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="TutorCognitivoDS2.vista.Consultas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consultas</title>

    <!--Configuraciones de la página-->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!--Archivos .js responsive-->
    <!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->
    <script src="interfaz.js"></script>

    <!--Archivos .css responsive-->
    <link rel="stylesheet" href="assets/css/main.css" />
    <!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
</head>
<body>
    <form id="formMenuAdmin" runat="server">
        <!--Contenedor principal-->
        <div id="page-wrapper">

            <!--Menú principal-->
            <nav id="nav">
                <ul>
                    <li onclick="return confirmarCierre();"><a>Cerrar Sesión</a></li>
                </ul>
            </nav>

            <!--Cuerpo-->
            <div id="main-wrapper">

                <!--Contenedor-->
                <div id="main" class="container">

                    <div class="row 200%">
                        <div class="12u">

                            <!-- Features -->
                            <section class="box features">

                                <div class="row">
                                    <div class="4u 12u(mobile)">
                                        <h3>Seleccione la consulta</h3>
                                    </div>
                                    <div class="4u 12u(mobile)">
                                        <asp:DropDownList ID="ddlConsulta" runat="server" OnSelectedIndexChanged="ddlConsulta_SelectedIndexChanged">
                                            <asp:ListItem Value="0">--Seleccione--</asp:ListItem>
                                            <asp:ListItem Value="1">Bitacora entre dos fechas</asp:ListItem>
                                            <asp:ListItem Value="2">Tutor con mas aportes</asp:ListItem>
                                            <asp:ListItem>Tutor por fecha de vencimiento</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>

                                <div class="row">
                                    <asp:Panel ID="panelBitacora" runat="server">
                                    </asp:Panel>
                                </div>

                                <div>
                                    <!--Seccion del nombre y correo-->
                                    <div class="row">
                                        <!--Nombre-->
                                        <div class="12u 12u(mobile)">
                                            <asp:GridView ID="GridConsultas" runat="server" Width="100%"></asp:GridView>
                                        </div>
                                    </div>
                                </div>
                            </section>
                        </div>
                    </div>
                </div>

                <!-- Footer -->
                <footer id="footer" class="container">
                    <!-- Copyright -->
                    <div id="copyright">
                        <ul class="menu">
                            Creado por <b>ChuckyBueno</b> / II semestre / <b>Noviembre 2016</b>
                        </ul>
                    </div>
                </footer>
            </div>
        </div>

        <!-- Scripts -->
        <script src="assets/js/jquery.min.js"></script>
        <script src="assets/js/jquery.dropotron.min.js"></script>
        <script src="assets/js/skel.min.js"></script>
        <script src="assets/js/skel-viewport.min.js"></script>
        <script src="assets/js/util.js"></script>
        <!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
        <script src="assets/js/main.js"></script>
    </form>
</body>
</html>
