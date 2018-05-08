<?php
/*------------------------------------------------------------------------*/

/*-----  PHP AJAX login,registration using database by php-gym.com  ------*/

/*------------------------------------------------------------------------*/
	$error = "";
	$msg ="";
	error_reporting(0);
	if(isset($_GET['method'],$_GET['code']) && $_GET['method']="activate"){
		require 'config.php';
		$mysqli = new mysqli($server,$database_user,$database_passwd,$database_name);
		$code = (int)$_GET['code'];
		$query = $mysqli->query("SELECT `id` FROM `users` WHERE `activecode`='$code' AND `status`=0");
		if($query->num_rows > 0){
			$mysqli->query("UPDATE `users` SET `status`=1 WHERE `status`=0 AND `activecode`='$code'");
			$msg = '<div class="alert alert-success">Account sucessfully activated</div>';
		}
	}
	if(isset($_POST) && isset($_POST['type'])){
	
		require 'config.php';
		$mysqli = new mysqli($server,$database_user,$database_passwd,$database_name);
		if($mysqli->connect_errno){
			echo '{"error":1,"message":"Unable to connect with database."}';
			exit();
		}
		if($_POST['type'] == "login" && isset($_POST['username'],$_POST['password'])){
			$e = htmlentities($_POST['username'],ENT_QUOTES);
			$p = md5($_POST['password']);
			$query = $mysqli->query("SELECT * FROM `users` WHERE `email`='$e' AND `password`='$p' AND `status`=1");
			
			if($query->num_rows ==1){
				session_start();
				$_SESSION['db_login'] = $query->fetch_assoc();
				echo '{"error":0,"redir":"okk"}';
			}else{
				echo '{"error":1,"message":"Invalid username or password."}';
			}
			
		}else if($_POST['type']=="register" && isset($_POST['email'],$_POST['firstname'],$_POST['lastname'],$_POST['passwd'],$_POST['confpasswd'])){
			
			$_POST['firstname'] = htmlentities($_POST['firstname'],ENT_QUOTES);
			$_POST['lastname'] = htmlentities($_POST['lastname'],ENT_QUOTES);
			$_POST['passwd'] = htmlentities($_POST['passwd'],ENT_QUOTES);
			
			$code = rand(0,999999999);
			$f = $_POST['firstname'];
			$l = $_POST['lastname'];
			$e = $_POST['email'];
			$p = md5($_POST['passwd']);
			
			if(!filter_var($_POST['email'], FILTER_VALIDATE_EMAIL)){
			
				echo '{"error":1,"message":"Please enter valid email","focus":"email"}';
				
			}else {
				$query = $mysqli->query("SELECT `id` FROM `users` WHERE `email`='$e'");
				if($query->num_rows > 0){
				
					echo '{"error":1,"message":"Email already exists.","focus":"email"}';
					
				}else if(strlen($_POST['firstname']) < 4 || strlen($_POST['firstname']) > 25){
		
					echo '{"error":1,"message":"Firstname must between 4 & 25 characters.","focus":"firstname"}';
				
				}else if(strlen($_POST['lastname']) < 4 || strlen($_POST['lastname']) > 15){
			
					echo '{"error":1,"message":"Lastname must between 4 & 15 characters.","focus":"lastname"}';
				
				}else if(strlen($_POST['passwd']) < 4 || strlen($_POST['passwd']) > 15){
			
					echo '{"error":1,"message":"Password must between 4 & 15 characters.","focus":"passwd"}';
			
				}else if($_POST['passwd'] != $_POST['confpasswd']){
			
					echo '{"error":1,"message":"Password not matched","focus":"confpasswd"}';
			
				}else{

					if($sendmail){
				
						$message = "Hello ".$_POST['firstname']." \n Please click on link below to activate your account. \n\n";
						$message .= "http://".$_SERVER[HTTP_HOST].$_SERVER[REQUEST_URI]."?method=activate&code=".$code;
						$message .= "\n\n\n Code sinppet by http://php-gym.com";
					
						if(mail($_POST['email'], $mail_subject, $message, $mail_from)){
							$mysqli->query("INSERT INTO `users` (`firstname`,`lastname`,`email`,`password`,`status`,`activecode`,`timestamp`) VALUES('$f','$l','$e','$p',0,'$code',UNIX_TIMESTAMP())");
							echo '{"error":0,"message":"Registration complete, Please check your email to activate your account","redir":"none"}';
						}else{
							echo '{"error":1,"message":"Unable to send verfication email"}';
						}
					}else{
						$mysqli->query("INSERT INTO `users` (`firstname`,`lastname`,`email`,`password`,`status`,`activecode`,`timestamp`) VALUES('$f','$l','$e','$p',1,'$code',UNIX_TIMESTAMP())") or die($mysqli->error);
						echo '{"error":0,"message":"Registration complete,<a onclick=\"$(\'#signupbox\').hide();$(\'.panel\').removeClass(\'animated shake\'); $(\'#loginbox\').show()\">Click here</a> to login","redir":"none"}';
					}
				
				}
			}
			
			
		}
		
		exit();
	}
?>
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<title>Simple php login without database by php-gym.com</title>
	<meta name="viewport" content="width=device-width, initial-scale=1">
    
	<!-- Include stylesheets for better appearance of login form -->
    
	<link href="css/bootstrap.min.css" rel="stylesheet">
	<link href="css/animate.css" rel="stylesheet">
	<style type="text/css">
		body{padding-top:20px;background-color:#f9f9f9;}
	</style>
	
	<script src="js/jquery-1.11.3.min.js"></script>
	<script src="js/bootstrap.min.js"></script>
	<style>
		.control-label{
			text-align:left!important;
		}
	</style>
	
</head>
<body>
	<div class="container">
		<div id="loginbox" style="margin-top:50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2"> 
		<div class="text-center"><a href="http://php-gym.com"><img src="php-gym.png"></a></div><br>                   
            	<div class="panel panel-info" >
                	<div class="panel-heading">
                        	<div class="panel-title">Sign In</div>
                  	</div>     
			<div style="padding-top:30px" class="panel-body">
			<?php echo $msg;?>
                        <div style="display:none" id="login-alert" class="alert alert-danger col-sm-12"></div>
                            
                        <form id="loginform" class="form-horizontal" role="form">
                                    
				<div style="margin-bottom: 25px" class="input-group">
					<span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                        <input id="login-username" type="text" class="form-control" name="username" value="" placeholder="username or email">                                        
				</div>
                                
				<div style="margin-bottom: 25px" class="input-group">
					<span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                                        <input id="login-password" type="password" class="form-control" name="password" placeholder="password">
				</div>

                                <div style="margin-top:10px" class="form-group">
                                    <!-- Button -->
					<div class="col-sm-12 controls">
						<input type="hidden" name="type" value="login">
						<button type="submit" id="btn-login" class="btn btn-success">Login  </button>
					</div>
                                </div>
                                <div class="form-group" style="margin-bottom:0px;">
					<div class="col-md-12 control">
						<div style="border-top: 1px solid #bce8f1; padding-top:15px; padding-left:10px; font-size:85%; margin: 0 -15px;" >Don't have an account! 
							<a href="#" onClick="$('#loginbox').hide(); $('.panel').removeClass('animated shake'); $('#signupbox').show()">Sign Up Here</a>
                                       		</div>
                                    	</div>
                                </div>    
			</form>     
			</div>                     
		</div>  
        	</div>
		<div id="signupbox" style="display:none; margin-top:50px" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
			<div class="text-center"><a href="http://php-gym.com"><img src="php-gym.png"></a></div><br>   
			<div class="panel panel-info">
				<div class="panel-heading">
					<div class="panel-title">Sign Up</div>
					
                        	</div>  
                        	<div class="panel-body" >
					<form id="signupform" class="form-horizontal" role="form" style="text-align:left;">
						<div id="signupalert" style="display:none" class="alert alert-danger">
							<p>Error:</p>
							<span></span>
						</div>
						<div class="form-group">
							<label for="email" class="col-md-4 control-label">Email</label>
							<div class="col-md-8">
								<input type="text" class="form-control" name="email" placeholder="Email Address">
							</div>
						</div>
						<div class="form-group">
							<label for="firstname" class="col-md-4 control-label">First Name</label>
							<div class="col-md-8">
								<input type="text" class="form-control" name="firstname" placeholder="First Name">
							</div>
						</div>
				                <div class="form-group">
				                	<label for="lastname" class="col-md-4 control-label">Last Name</label>
				                	<div class="col-md-8">
				                        	<input type="text" class="form-control" name="lastname" placeholder="Last Name">
				                    	</div>
				                </div>
				                <div class="form-group">
				                	<label for="password" class="col-md-4 control-label">Password</label>
				                	<div class="col-md-8">
				                		<input type="password" class="form-control" name="passwd" placeholder="Password">
				                	</div>
				                </div>
				                <div class="form-group">
				                	<label for="password" class="col-md-4 control-label">Confirm Password</label>
				                	<div class="col-md-8">
				                		<input type="password" class="form-control" name="confpasswd" placeholder="Confirm Password">
				                	</div>
				                </div>				                
				                
				                <div class="form-group">
				                	<!-- Button -->                                        
				                	<div class="col-md-offset-4 col-md-8">
				                		<input type="hidden" name="type" value="register">
				                        	<button id="btn-signup" type="submit" class="btn btn-info"><i class="glyphicon glyphicon-hand-right"></i> &nbsp;Sign Up</button>
				                	</div>
				                </div>
						<div class="form-group" style="margin-bottom:0px;">
							<div class="col-md-12 control">
								<div style="border-top: 1px solid #bce8f1; padding-top:15px; padding-left:10px; font-size:85%; margin: 0 -15px;" >Already have an account! 
									<a href="#" onClick="$('#signupbox').hide();$('.panel').removeClass('animated shake'); $('#loginbox').show()">Login Here</a>
				                       		</div>
				                    	</div>
				                </div> 
                   
					</form>
                         	</div>
			</div>
		</div>
		<div class="col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
			<div class="pull-left">
				Copyright &copy; 2015 <a href="http://php-gym.com">php-gym.com</a>
			</div>
			<div class="pull-right">
				<a href="http://php-gym.com/category/code-snippets">Download more</a>
			</div>
		</div>
	</div>
	<script>
		$('form').submit(function(e){
			e.preventDefault();
			var $this = $(this);
			$this.parent().parent().removeClass('animated shake');
			$this.parent().find('.alert').remove();
			var submit = true;
			var btn = $(this).find('button');
			$this.find('input[type="text"],input[type="password"]').attr('style','');
		
			$this.find('input[type="text"],input[type="password"]').each(function(){
				if($(this).val()==""){
					$(this).focus().css({'border-color':'#f44','box-shadow':'0 0 8px #f44'});
					submit = false;
					$this.parent().parent().addClass('animated shake');
					return false;
				}
			});
			if(submit == true){
				btn.button('loading');
				$.post('index.php',$(this).serialize(),function(data){
					if(data.error == 1){
						$this.parent().prepend('<div class="alert alert-danger">'+data.message+'</div>');
						$this.parent().parent().addClass('animated shake');
						if(data.focus && data.focus != "undefined"){
							$('input[name="'+data.focus+'"]').focus().css({'border-color':'#f44','box-shadow':'0 0 8px #f44'});
						}
					}else{
						if(data.redir == "okk"){
							$this.parent().prepend('<div class="alert alert-success">Login successfull, redirecting...</div>');
							window.location = 'home.php';
						}else{
							$this.parent().prepend('<div class="alert alert-success">'+data.message+'</div>');
						}
					}
				},"JSON").error(function(){
					alert('Request not complete.');
				}).always(function(){
					btn.button('reset')
				});
			}
			setTimeout(function(){
				
			},100)
			
		});
	</script>
</body>
</html>
