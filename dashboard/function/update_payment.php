<?php 
if(isset($_POST['submit'])){
	include_once 'connection.php';
	$id = $_POST['id'];
	$firstname = $_POST['name'];
	
	$phone = $_POST['amount'];
	$update_user ="UPDATE `payment` SET `name`='$firstname',`amount`='$phone' WHERE id = '$id'";
	$conn->query($update_user);
	header("Location:../payment.php");
}

?>