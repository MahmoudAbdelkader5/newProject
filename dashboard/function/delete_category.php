<?php
include_once 'connection.php';
$id = $_GET['id'];
$delete_category = "DELETE FROM manager WHERE id = $id";
$conn->query($delete_category);
header("Location:../manager.php"); 

?>