<?php
include "cabecera.php";
?>

<div style = "
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
<h2>Seguimiento</h2>
<?php
session_start();
$_SESSION["ci"] = $_SESSION["ci"];
include "conexion.inc.php";
$sql ="select * from seguimiento where estudiante='".$_SESSION["ci"]."' and fechafin is null";
$resultado = mysqli_query($con, $sql);
?>
<table border="1px">
	<tr>
		<td>Tramite</td>
		<td>Flujo</td>
		<td>Proceso</td>
		<td>Fecha Inicial</td>
		<td>Operaciones</td>
	</tr>

<?php
while ($fila = mysqli_fetch_row($resultado))
{
	echo "<tr>";
	echo "<td>".$fila[0]."</td>";
	echo "<td>".$fila[1]."</td>";
	echo "<td>".$fila[2]."</td>";
	echo "<td>".$fila[4]."</td>";
	echo "<td><a href='motor.php?cf=".$fila[1]."&cp=".$fila[2]."'>Ver</a></td>";
	echo "<tr>";
}
?>
</table>
</div>
<?php
include "footer.php";
?>