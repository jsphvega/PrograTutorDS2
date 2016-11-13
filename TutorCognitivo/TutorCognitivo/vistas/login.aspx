<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TutorCognitivo.vistas.login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Inicio</title>

	<!--Configuraciones de la página-->
	<meta charset="utf-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1" />

	<!--Archivos .js responsive-->
	<!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->

	<!--Archivos .css responsive-->
	<link rel="stylesheet" href="assets/css/main.css" />
	<!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
</head>

<body class="homepage">
     <form id="form2" runat="server" >
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
					<p><input id="txtUsuario" placeholder="Correo electrónico" type="text" /></p>

					<!--Contraseña-->
					<h3>Contraseña</h3>
					<p><input id="txtContraseña" placeholder="Contraseña" type="password" /></p>

					<!--Tipo-->
					<div class="radioGroup">
						<label for="markAdmin">
							<input name="rdnTipo" type="radio" value="tutor"> Tutor</input>
						</label>
						<label for="markStudent">
							<input name="rdnTipo" type="radio" value="admin"> Administrador</input>
						</label>
						<label for="markService">
							<input name="rdnTipo" type="radio" value="final"> Final</input>
						</label>
					</div>

					<br/>
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
    </form>
	<!-- Scripts -->
	<script src="assets/js/jquery.min.js"></script>
	<script src="assets/js/jquery.dropotron.min.js"></script>
	<script src="assets/js/skel.min.js"></script>
	<script src="assets/js/skel-viewport.min.js"></script>
	<script src="assets/js/util.js"></script>
	<!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
	<script src="assets/js/main.js"></script>
    
</body>
</html>
