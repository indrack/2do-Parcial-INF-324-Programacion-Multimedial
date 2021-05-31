<?php
include "cabecera.php";
?>

<div style="
    display: flex;
    width: 80%;
    justify-items: center;
    align-items: center;
    text-align: center;
    flex-direction: column;
    border: 1px solid black;
    margin-left: 10%;
    margin-right: 10%;
    margin-top: 50%;
    align-content: space-around;
    background: #4DBCFF;
">
<h1>ALUMNOS NUEVOS</h1>
<h3>
Ingrese sus datos para registrarte</h3>
<form action="motor.php">
<div>
<font style="color:blue; font-size: 18px">Carnet de identidad</font>
<br>
<input type="text" value="" name="ci"/><br>
<font style="color:blue; font-size: 18px">Nombre</font>
<br>
<input type="text" value="" name="nombre"/><br>
<input type="submit" name="materia" value="Siguiente" style="
background: gray;
color: white;
padding-left: 15px;
padding-right: 15px;
margin-top: 5px;
border-radius: 50px 50px;
">
<input type="hidden" name="cp" value="P1">
<input type="hidden" name="cf" value="F1">
</div>
</form>
</div>


<?php
include "footer.php";
?>