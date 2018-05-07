<?php
$file=fopen("contact_data.csv","r"); //nombre archivos
while(!feof($file)){ //lo ! not es para segurates de archivos todos este bien
$content=fgetcsv($file); // es para leer cuanta tabla 
$count=count($content); // contador
	for($i=0;$i<$count;$i++){ // para la tabla de terminas cuanto hay
echo $content[$i]."\t"; // sale pantalla la informacion
	}
	echo"<br>"; // se para 
}

?>
<html>
<button><a href="contact_data.csv">Dowload</button></a>

</html>