<?php

/*------------------------------------------------------------------------*/

/*-----  PHP AJAX login,registration using database by php-gym.com  ------*/

/*------------------------------------------------------------------------*/



	/*** Important do not change ***/
	session_start();
	if(!isset($_SESSION['db_login'])){
		header("Location: index.php");
		exit();
	}
	/*** Important END ***/
?>

<!-------- Write you stuff down here -------->
<h1 align="center">Welcome, <?php echo $_SESSION['db_login']['firstname'].$_SESSION['db_login']['lastname']; ?></h1>

<table align="center">
	<?php
		foreach($_SESSION['db_login'] as $key => $val){
	?>
			<tr>
				<td><?php echo $key;?></td>
				
				<td><?php echo $val; ?></td>
			</tr>
	<?php	
		}
	?>
</table>

<p align="center"><a href="logout.php">Logout</a></p>
 <p align="center"><a href="info/index.php">data</a></p>
