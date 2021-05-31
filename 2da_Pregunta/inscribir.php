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
    align-content: space-around;">
<?php 

session_start();
$cp = $_GET["cp"];
$cf = $_GET["cf"];
$mat = $_GET["mat"];
$_SESSION["mat"] = $mat;
$sql="select * from materia where id=".$materia;

echo "<h4>Usted se inscribio a las materias : ".$fila[1]."<h4>";

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
</div>