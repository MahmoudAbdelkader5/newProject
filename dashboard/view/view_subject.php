<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
	<?php 
	$id = $_GET['id'];
	$select_mess = "SELECT * FROM message WHERE id = $id";
	$result_mess = $conn->query($select_mess);
	$row_mess = $result_mess->fetch_Assoc();

	$update_mess = "UPDATE message SET view = '1' WHERE id = $id";
	$conn->query($update_mess);


	  ?>
	  <p>Date :<?php echo $row_mess['m_date']; ?></p>

	<p>Message:<?php echo $row_mess['message']; ?></p>
	<a href="messages.php" class="btn btn-info">Back</a>
	

</body>
</html>