<?php 
if(isset($_POST['submit'])){
	include_once 'connection.php';
	$firstname = $_POST['name'];
	
	$phone = $_POST['amount'];
	$gender = $_POST['payment'];
	
	 if($gender=='daily'){
		$ch_gander = 0 ;
		}else {
              $ch_gander = 1 ;
		}
	$insert_users = "INSERT INTO `payment`(`name`, `amount`, `type of Subscriptions`)
    VALUES ('$firstname','$phone','$gender')";
	$conn->query($insert_users);
	header("Location:../payment.php");
}

?>