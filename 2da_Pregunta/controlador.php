<?php
include "conexion.inc.php";
$codflujo = $_GET["codflujo"];
$codproceso = $_GET["codproceso"];
$pantalla = "controlador.".$_GET["pantalla"];
include $pantalla;

if(isset($_GET["Siguiente"])){
	$sql ="select * from proceso where codFlujo='$codflujo'and codProceso='$codproceso' ";
	$resultado = mysqli_query($con, $sql);
	$fila = mysqli_fetch_row($resultado);
	$cf = $fila[0];
	$cp = $fila[2];

}
if(isset($_GET["Anterior"])){
	$sql ="select * from proceso where codFlujo='$codflujo' and codProcesoSiguiente='$codproceso' ";	
	$resultado = mysqli_query($con, $sql);
	$fila = mysqli_fetch_row($resultado);
	$cf = $fila[0];
	$cp = $fila[1];	
}
header("Location: motor.php?cf=$cf&cp=$cp");
?>
