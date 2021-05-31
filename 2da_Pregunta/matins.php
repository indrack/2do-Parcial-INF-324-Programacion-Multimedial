<?php
session_start();
$cp = $_GET["cp"];
$cf = $_GET["cf"];
$mat = $_GET["mat"];
$_SESSION["mat"] = $mat;
$sql="select * from materia where id=".$materia;

echo "<h4>Usted selecciono la materia : ".$fila[1]."<h4>";

if(!empty($_GET['mat'])){
// Ciclo para mostrar las casillas checked checkbox.
foreach($_GET['mat'] as $selec){
$sql="select * from materia where id=".$selec;
//echo $sql;
$res=mysqli_query($con, $sql);
$fila=mysqli_fetch_row($res);
echo $fila[1]."<br>";
$sqli="insert into inscrito values(".$_SESSION['ci'].",".$selec.")";
mysqli_query($con,$sqli);
}
}
?>
