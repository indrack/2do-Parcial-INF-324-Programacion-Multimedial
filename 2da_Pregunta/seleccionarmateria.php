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
<h1>Seleccione a la materia que se inscribira</h1>
<?php
include "conexion.inc.php";

echo $idsem;
$sqlf ="select * from materia";
$resultadof = mysqli_query($con, $sqlf);
?>	
<form action="">
<div>
<?php
while ($filaf = mysqli_fetch_row($resultadof))
{
	echo "<input type='checkbox' name='mat[]' value=".$filaf[0].">".$filaf[1]."<br/>";
}

?>	
</div>
		<div>
		<input type="hidden" name="cf" value="F1">
		<input type="hidden" name="cp" value="P4">
		<input type="submit" name="Seleccionar" value = "Seleccionar" style="
background: gray;
color: white;
padding-left: 15px;
padding-right: 15px;
margin-top: 5px;
border-radius: 50px 50px;
"> 	
		</div>
</form>

</div>