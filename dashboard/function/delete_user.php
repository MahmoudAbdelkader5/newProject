<?php
include_once 'connection.php';
$id = $_GET['id'];
$delete_users = "DELETE FROM trainee WHERE id = $id";
$conn->query($delete_users);
header("Location:../trainee.php"); 

?>