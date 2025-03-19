<?php 

if(isset($_POST['submit']))
{
	include_once 'Config.php';
	$username = $_POST['username'];
	$password = $_POST['password'];

	$select_admin = "SELECT * FROM trainee WHERE email = '$username' AND password = '$password'";
	$result_admin = $conn->query($select_admin);
	$row_admin = $result_admin->fetch_assoc();
	$count = $result_admin-> num_rows;

	if($count ==1){

		header("Location:/Gym/gym.html");
	}
	else
	{
		header("Location:http://localhost/Gym/login.php");
	}
}

?>