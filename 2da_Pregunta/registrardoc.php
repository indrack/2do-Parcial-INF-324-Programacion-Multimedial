<div style="
  display: flex;
    width: 80%;
    justify-items: center;
    align-items: center;
    text-align: justify;
    flex-direction: column;
    border: 1px solid black;
    margin-left: 10%;
    margin-right: 10%;
    background: #4DBCFF;
    align-content: space-around;
">
<?php
include "conexion.inc.php";
$cp = $_GET["cp"];
$cf = $_GET["cf"];
$docs = $_GET["doc"];
echo "<h3>Usted selecciono los documentos : </h3><br>";
$_SESSION["docs"] = $docs;


if(!empty($_GET['doc'])){
// Ciclo para mostrar las casillas checked checkbox.
foreach($_GET['doc'] as $selec){
$sql="select * from documentos where id=".$selec;
//echo $sql;
$res=mysqli_query($con, $sql);
$fila=mysqli_fetch_row($res);
echo $fila[1]."<br>";

$sqli="insert into registrodoc values(".$_SESSION['ci'].",".$selec.")";
mysqli_query($con,$sqli);
}
}
?>
</div>