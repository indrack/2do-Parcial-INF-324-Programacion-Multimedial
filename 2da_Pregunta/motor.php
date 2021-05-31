<?php
include "cabecera.php";
?>

<?php
include "conexion.inc.php";
session_start();
if(isset($_GET["ci"])){
	$ci = $_GET["ci"];
	$nombre = $_GET["nombre"];
	
	echo "Usuario: ";
	echo $_SESSION["nombre"]."  ";

	$sqlf ="select * from estudiante ";
	$sqlf.="where ci='".$ci;
	$resp = mysqli_query($con, $sqlf);
	
	
	if($resp=!null){
	
		$sql ="insert into estudiante values (".$ci.",'".$nombre."')";
		$resp = mysqli_query($con, $sql);
	}
	else{
		echo "el estudiante ya existe";
	}
	
	

	$_SESSION["ci"]=$ci;
	$_SESSION["nombre"]=$nombre;
	

	$sqla ="select * from seguimiento ";
	$sqla.="where estudiante='".$ci."' ";
	$sqla.="and fechafin is null";
	$res = mysqli_query($con, $sqla);
	
	$op =  mysqli_fetch_row($res);
	if($op!= null){
		if(sizeof($op)> 0){
		header("Location: bentrada.php");
	}		
	}

}


$cf = $_GET["cf"];
$cp = $_GET["cp"];

$sqll ="select * from proceso ";
$sqll.="where codFlujo='$cf' ";
$sqll.="and codProceso='$cp' ";

$resultadoo = mysqli_query($con, $sqll);

$fila2=mysqli_fetch_row($resultadoo);
echo "Proceso: ".$fila2[5];

?>

<?php
include $fila2[5];
?>

<form action = "controlador.php" method="GET">


<br>
<input type="hidden" name="pantalla" value="<?php echo $fila2[5];?>"/>
<input type="hidden" name="codflujo" value="<?php echo $fila2[0];?>"/>
<input type="hidden" name="codproceso" value="<?php echo $fila2[1];?>"/>
<center>
<?php
if($fila2[5]!='mostrar.php'){
echo"<input type='submit' name='Siguiente' value='Siguiente' style='
background: gray;
color: white;
padding-left: 15px;
padding-right: 15px;
margin-top: 5px;
border-radius: 50px 50px;
'/>";
echo"<input type='submit' name='Anterior' value='Anterior' style ='
background: gray;
color: white;
padding-left: 15px;
padding-right: 15px;
margin-top: 5px;
border-radius: 50px 50px;
'/>";
}
?>
</center>
</form>
<?php
include "footer.php";
?>