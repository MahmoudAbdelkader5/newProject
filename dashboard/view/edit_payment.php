<?php 
$id = $_GET['id'];
$select_update = "SELECT * FRom payment WHERE id = $id";
$result_update = $conn->query($select_update);
$array = $result_update->fetch_assoc();

?>
<form action="function/update_payment.php" method="POST" enctype="multipart/form-data">
					<input type="hidden" name="id" value="<?php echo $id; ?>">
					<input class="form-control" type="text" name="name" placeholder="Enter username" value="<?php echo $array['name'];?>" ><br>
							<select name="payment" class="form-control">
							<option selected="" disabled="">Choose</option>
							<option value="daily">daily</option>
							<option value="monthly">monthly </option>
						</select><br>
					<input class="form-control" type="text" name="amount"  value="<?php echo $array['amount'];?>" ><br>

					<input type="submit" class="btn btn-primary" name="submit" value="Edit">
				</form>