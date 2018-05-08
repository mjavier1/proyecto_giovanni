<?php

/*------------------------------------------------------------------------*/

/*-----  PHP AJAX login,registration using database by php-gym.com  ------*/

/*------------------------------------------------------------------------*/

$error = ""; $success = "";
if(isset($_POST['db_name'],$_POST['db_username'],$_POST['db_pass'])){
	$db_name = $_POST['db_name'];$db_username = $_POST['db_username'];$db_pass=$_POST['db_pass'];
	if(strlen($db_name)<2 || strlen($db_username)<2 || strlen($db_pass)<2){
		$error="All fields are required.";
	}else{
		$mysqli = @new mysqli('localhost',$db_username,$db_pass,$db_name);
		if(mysqli_connect_errno()){
			$error = "<b>Connect failed:</b> ".mysqli_connect_error();
		}else{
			$query = $mysqli->query("SHOW TABLES In $db_name WHERE TABLES_IN_$db_name='users'") or die($mysqli->error);
			if($query->num_rows > 0){
				$error = "<b>Error:</b> Some tables are already exists which is used by this project, Please select seprate database instead of this.";
			}else{
				$sql = file_get_contents('login.sql');
	$data= '<?php'."\n".'$server="localhost";'."\n".'$database_user="'.$db_username.'";'."\n".'$database_passwd="'.$db_pass.'";'."\n".'$database_name="'.$db_name.'";'."\n".'?>';
				$fh = fopen('db_conn.php', 'w');
				fwrite($fh, $data);
				fclose($fh);
				if($mysqli->multi_query($sql)){
					$success = "<b>Installation Successfull</b> (Please Remove <b>install.php</b> & <b>login.sql</b> files.)";
				}else{
					$error = "<b>MYSQL ERROR:</b> $mysqli->error";
				}
			}
		}
	}
}
?>
<!doctype html>
<html>
	<head>
		<title>Database installation - php-gym.com</title>
		
		<style type="text/css">
			body{
				margin:0px;
				padding:0px;
				background-color:#fff;
				font-family: "Museo",Helvetica,Arial,sans-serif !important;
				font-size:12px
			}
			.highlight {
				background: #f3f3f3;
				border: 1px solid #ccc;
				width:500px;
				margin:0px auto 0px auto;
				margin-top:100px;
				padding:10px;
			}
			
			h1{
				font-size:16px;
				margin:0px;
				padding:0px;
				margin-bottom:5px;
				font-weight:bold;
			}
			form input[type="text"],form input[type="password"]{
				width:250px;
				border:1px solid #ccc;
				outline:none;
				height:27px;
				padding-left:5px;
			}
			form input[type="submit"]{
				width:60px;
				height:30px;
				cursor:pointer;
				font-size:14px;
				background-color:#70bc46;
				color:#f3f3f3;
				border:1px solid #e9e9e9;
				font-weight:bold;
			}
			table tr>td{
				padding-top:10px;
			}

			div#error{
				font-size:13px;
				color:#f44;
			}
			
			div#error b{
				font-weight:bold;
				font-size:14px;
			}
			
			div#success{
				font-size:14px;
				color:#70bc46;
			}

			div#success b{
				font-weight:bold;
			}
			
		</style>
	</head>
	<body>
		<div class="highlight">
			<h1>Database Installation - php-gym.com</h1>
			<form name="install" id="install" action="install.php" method="POST">
				<table width="80%" align="center">
					<tr>
						<td><lable for="db_name">Database Name:</lable></td>
						<td><input type="text" name="db_name" id="db_name" value="<?php echo @$_POST['db_name']; ?>" required></td>
					</tr>
					<tr>
						<td><lable for="db_username">Database Username:</lable></td>
						<td><input type="text" name="db_username" id="db_username" value="<?php echo @$_POST['db_username']; ?>" required></td>
					</tr>
					<tr>
						<td><lable for="db_pass">Database Password:</lable></td>
						<td><input type="password" name="db_pass" id="db_pass" value="<?php echo @$_POST['db_pass']; ?>" required></td>
					</tr>
					<tr>
						<td>&nbsp;</td>
						<td><input type="submit" value="Save"></td>
					</tr>
					<tr>
						<td colspan="2">
							<div id="error"><?php echo $error; ?></div>
							<div id="success"><?php echo $success; ?></div>
						</td>
					</tr>
				</table>
			</form>
		</div>
	</body>
</html>
