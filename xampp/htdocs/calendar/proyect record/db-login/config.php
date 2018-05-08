<?php

/*------------------------------------------------------------------------*/

/*-----  PHP AJAX login,registration using database by php-gym.com  ------*/

/*------------------------------------------------------------------------*/



/*------------------- Database Connection --------------------------*/

	require('db_conn.php');
	
	
/*------------------- Sendmail configuration ------------------------*/	

	$sendmail	  = false;   // true to enable it
	$mail_from        = "From: admin@phpgym.com";
	$mail_subject     = "Activate account";
	
?>
