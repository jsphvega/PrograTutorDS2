﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="TutorCognitivoDS2.Vista.registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro</title>

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
    <form id="form1" runat="server">
    <!--Contenedor principal-->
	<div id="page-wrapper">

		<!--Encabezado-->
		<header id="header">

			<!--Nombre del proyecto-->
			<div class="logo container">
				<div>
					<h1><a id="logo">Tutor Cognitivo</a></h1>
					<p>por ChuckyBueno</p>
				</div>
			</div>
		</header>

		<!--Menú principal-->
		<nav id="nav">
			<ul>
				<li class="current"><a href="login.aspx">Volver</a></li>
			</ul>
		</nav>

		<!--Cuerpo-->
		<div id="main-wrapper">

			<!--Contenedor-->
			<div id="main" class="container">

				<!-- Features -->
				<section class="box features">
					<h2 class="major"><span>Registro de usuarios</span></h2>
					<div>

						<!--Seccion del nombre y correo-->
						<div class="row">
							<!--Nombre-->
							<div class="4u 12u(mobile) 12u(tablet)">
								<h3>Nombre</h3>
								<p><input id="txtNombre" placeholder="Nombre" type="text" /></p>
							</div>

							<!--Apell1do 1-->
							<div class="4u 12u(mobile) 12u(tablet)">
								<h3>1° Apellido</h3>
								<p><input id="txtApellido1" placeholder="1° Apellido" type="text" /></p>
							</div>

							<!--Apellido 2-->
							<div class="4u 12u(mobile) 12u(tablet)">
								<h3>1° Apellido</h3>
								<p><input id="txtApellido2" placeholder="2° Apellido" type="text"/></p>
							</div>
						</div>

						<!--Seccion del correo y la contraseña-->
						<div class="row">
							<!--Correo-->
							<div class="4u 12u(mobile) 12u(tablet)">
								<h3>Correo electrónico</h3>
								<p><input id="txtCorreo" placeholder="ejemplo@dominio.com" type="text" /></p>
							</div>

							<!--Contraseña-->
							<div class="4u 12u(mobile) 12u(tablet)">
								<h3>Contraseña</h3>
								<p><input id="txtContraseña1" placeholder="Digite la contraseña" type="password" /></p>
							</div>

							<!--Confirmar Contraseña-->
							<div class="4u 12u(mobile) 12u(tablet)">
								<h3>Confirmar Contraseña</h3>
								<p><input id="txtContraseña2" placeholder="Confirme su contraseña" type="password" /></p>
							</div>
						</div>

						<!--Seccion de la carrera-->
						<div class="row">
							<!--Carrera-->
							<div class="4u 12u(mobile) 12u(tablet)">
								<h3>Carrera</h3>
								<p>
									<select>
										<option value="null"> </option>
										<option value="AE"> Administración de Empresas </option>
										<option value="TI"> Administración de Tecnologías de Información </option>
										<option value="AU"> Arquitectura y Urbanismo </option>
										<option value="EM"> Enseñanza de la Matemática asistida por computadora </option>
										<option value="TS"> Gestión del Turismo Rural Sostenible </option>
										<option value="TS"> Gestión en Turismo Sostenible </option>
										<option value="IA"> Ingeniería Agrícola </option>
										<option value="AA"> Ingeniería Agronegocios </option>
										<option value="AI"> Ingeniería Ambiental </option>
										<option value="AG"> Ingeniería en Agronomía </option>
										<option value="IB"> Ingeniería en Biotecnología </option>
										<option value="CA"> Ingeniería en Computación </option>
										<option value="CE"> Ingeniería en Computadores </option>
										<option value="CO"> Ingeniería en Construcción </option>
										<option value="ID"> Ingeniería en Diseño Industrial </option>
										<option value="EL"> Ingeniería en Electrónica </option>
										<option value="MI"> Ingeniería en Mantenimiento Industrial </option>
										<option value="CM"> Ingeniería en Materiales </option>
										<option value="PI"> Ingeniería en Producción Industrial </option>
										<option value="SO"> Ingeniería en Seguridad Laboral e Higiene Ambiental </option>
										<option value="FO"> Ingeniería Forestal </option>
										<option value="MT"> Ingeniería Mecatrónica </option>
									</select>
								</p>
							</div>
						</div>

						<div class="row">
							<div class="12u">
								<ul class="actions">
									<li><a href="#" class="button big">Aceptar</a></li>
									<li><a href="#" class="button alt big">Cancelar</a></li>
								</ul>
							</div>
						</div>
					</div>
				</section>
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
