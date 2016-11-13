<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TutorCognitivoDS2.Vista.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio</title>

    <!--Configuraciones de la página-->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!--Archivos .js responsive-->
    <!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->

    <!--Archivos .css responsive-->
    <link rel="stylesheet" href="assets/css/main.css" />
    <!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
</head>
<body>
    <form id="formLogin" runat="server">
        <!--Contenedor principal-->
        <div id="page-wrapper">

            <!-- Nav -->
            <nav id="nav">
                <ul>
                    <li><a href="">Registro por Facebook</a></li>
                    <li class="current"><a href="registro.aspx">Registro</a></li>
                    <li><a href="">Registro por google</a></li>
                </ul>
            </nav>

            <!--Cuerpo -->
            <div id="banner-wrapper">
                <section id="banner">
                    <!--titulo-->
                    <h2><a id="logo">Tutor Cognitivo</a></h2>

                    <!--Correo-->
                    <div class="login">

                        <!--Usuario-->
                        <h3>Usuario</h3>
                        <p>
                            <asp:TextBox ID="txtUsuario" placeholder="Correo electrónico" TextMode="Email" runat="server" CssClass="input inputEmail"></asp:TextBox>
                        </p>

                        <!--Contraseña-->
                        <h3>Contraseña</h3>
                        <p>
                            <asp:TextBox ID="txtContraseña" placeholder="Contraseña" TextMode="Password" runat="server"  CssClass="input inputPassword"></asp:TextBox>
                        </p>

                        <!--Tipo-->
                        <div class="radioGroup">
                            <label for="markAdmin">
                                <asp:RadioButton ID="rdnTutor" Text="Tutor" runat="server" />
                            </label>
                            <label for="markStudent">
                                <asp:RadioButton ID="rdnAdmin" Text="Administrador" runat="server" />
                            </label>
                            <label for="markService">
                                <asp:RadioButton ID="rdnFinal" Text="Final" runat="server" />
                            </label>
                        </div>

                        <br />
                    </div>

                    <!--Botones de inicio-->
                    <a class="buttonFacebook">Iniciar por Facebook</a>
                    <a class="button">Iniciar Sesión</a>
                    <a class="buttonGoogle">Iniciar por Google</a>
                </section>
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
