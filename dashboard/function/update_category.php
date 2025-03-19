<?php 
if(isset($_POST['submit'])){
	include_once 'connection.php';
	$id = $_POST['id'];
	$firstname = $_POST['name'];
	$password = $_POST['password'];
	$phone = $_POST['phone'];
	$image_name = $_FILES['image']['name'];
	$image_temp = $_FILES['image']['tmp_name'];
	move_uploaded_file($image_temp, "../images/$image_name");

	if(!empty($image_name))
	{
		$update_image = "UPDATE manager SET image = '$image_name' WHERE id = $id";
		$conn->query($update_image); 

	}

	$update_user = "UPDATE manager SET name = '$firstname' , password = '$password'  ,phone = '$phone' WHERE id = $id";
	$conn->query($update_user);
	

	header("Location:../manager.php");
}

?>