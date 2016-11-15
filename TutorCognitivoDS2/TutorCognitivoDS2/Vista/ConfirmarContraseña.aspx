﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmarContraseña.aspx.cs" Inherits="TutorCognitivoDS2.vista.ConfirmarContraseña" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio</title>

    <!--Configuraciones de la página-->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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

            <!--Menú principal-->
            <nav id="nav">
                <ul>
                    <li onclick="return confirmarSalida();"><a>Volver</a></li>
                </ul>
            </nav>

            <!--Cuerpo -->
            <div id="banner-wrapper">
                <section id="banner">
                    <!--titulo-->
                    <h2><a id="logo">Cambiar contraseña</a></h2>

                    <!--Correo-->
                    <div class="login">
                        <div class="row">
                            <div class="4u" style="text-align: center"></div>
                            <div class="4u" style="text-align: center">
                                <!--Usuario-->
                                <h3>Digite la contraseña</h3>
                                <p style="text-align: center">
                                    <asp:TextBox ID="txtContraseña1" placeholder="Contraseña" TextMode="Password" runat="server" CssClass="input inputPassword" Width="400px"></asp:TextBox>
                                </p>

                                <!--Contraseña-->
                                <h3>Confirme la contraseña</h3>
                                <p style="text-align: center">
                                    <asp:TextBox ID="txtContraseña2" placeholder="Confirmar contraseña" TextMode="Password" runat="server" CssClass="input inputPassword" Width="400px"></asp:TextBox>
                                </p>

                                <p>
                                    <asp:Label ID="lblError" runat="server"></asp:Label>
                                </p>
                            </div>
                            <div class="4u" style="text-align: center"></div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="12u" style="text-align: center">
                            <asp:Button ID="btnAceptar" CssClass="button big" runat="server" Text="Aceptar" OnClientClick="return true;" OnClick="btnAceptar_Click" />
                            <asp:Button ID="btnCancelar" CssClass="button alt big" runat="server" Text="Cancelar" CausesValidation="true" OnClick="btnCancelar_Click" />
                        </div>
                    </div>
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
</html>
