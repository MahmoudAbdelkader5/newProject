				
<form action="function/insert_payment.php" method="POST" enctype="multipart/form-data">
	<input class="form-control" type="text" name="name" placeholder="Enter name"><br>
    
	<select name="payment" class="form-control">
		<option selected="" disabled="">Choose</option>
		<option value="daily">daily</option>
		<option value="monthly">monthly </option>
	</select><br>
	
	<input class="form-control" type="text" name="amount" placeholder="Enter amount"><br>
	

	<input type="submit" class="btn btn-primary" name="submit" value="ADD">
				</form>
