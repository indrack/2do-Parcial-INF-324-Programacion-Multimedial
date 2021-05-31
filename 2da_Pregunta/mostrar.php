
<div style = "display: flex;
    width: 80%;
    justify-items: center;
    align-items: center;
    text-align: justify;
    flex-direction: column;
    border: 1px solid black;
    margin-left: 10%;
    margin-right: 10%;
	background: #4DBCFF;
    align-content: space-around;"
	>
<?php 
include "conexion.inc.php";
session_start();
$ci = $_SESSION["ci"];


$sqlf = "Select nombre, sigla From materia m, inscrito i ";
$sqlf.= "Where ci = ".$ci." ";
$sqlf.= "and m.id = i.id";
$resultadof = mysqli_query($con, $sqlf);
echo "<h3>Materias Inscritas</h3>";
echo "<table border="."1px".">";
echo "<tr>";
echo "<td>Materia</td>";
echo "<td>Sigla</td>";
echo "</tr>";
while ($filaf = mysqli_fetch_row($resultadof))
{

	echo "<tr>";
	echo "<td>".$filaf[0]."</td>";
	echo "<td>".$filaf[1]."</td>";
	echo "<tr>";
}
echo "</table>";


?>
<h3>Documentos Presentados</h3>
<?php 
$sqld="select d.nomdoc from documentos d, registrodoc r where d.id=r.id and  r.ciEst=".$_SESSION['ci'];
$resd=mysqli_query($con,$sqld);
echo "<table border="."1px".">";
echo "<tr>";
echo "<td>Documentos</td>";
echo "</tr>";
while ($filaf = mysqli_fetch_row($resd))
{

	echo "<tr>";
	echo "<td>".$filaf[0]."</td>";
	echo "<tr>";
}
echo "</table>";
?>

<form action = "index.php">
	<input type="submit" name="Salir" value="Salir"
	style="
	background: gray;
color: white;
padding-left: 15px;
padding-right: 15px;
margin-top: 5px;
border-radius: 50px 50px;
	"
	>

</form>
</div>