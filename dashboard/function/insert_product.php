<?php 
if(isset($_POST['submit'])){
	include_once 'connection.php';
	$firstname = $_POST['name'];
	$password = $_POST['password'];
	$email = $_POST['email'];
	$phone = $_POST['phone'];
	$image_name = $_FILES['image']['name'];
	$image_temp = $_FILES['image']['tmp_name'];
	move_uploaded_file($image_temp, "../images/$image_name");
	

	$insert_users = "INSERT INTO trainer(name,image,email,phone,password)VALUES('$firstname'  , '$image_name','$email','$phone','$password')";
	$conn->query($insert_users);
	header("Location:../trainer.php");
}

?>