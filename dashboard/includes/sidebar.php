
	<div id="sidebar-collapse" class="col-sm-3 col-lg-2 sidebar">
		<div class="profile-sidebar">
			<div class="profile-userpic">
				<img src="images/<?php echo $_SESSION['img']; ?>" class="img-responsive" alt="">
			</div>
			<div class="profile-usertitle">
				<div class="profile-usertitle-name"><?php echo $_SESSION['username'] ?></div>
				<div class="profile-usertitle-status"><span class="indicator label-success"></span>Online</div>
			</div>
			<div class="clear"></div>
		</div>
		<div class="divider"></div>
		<form role="search">
			<div class="form-group">
				<input type="text" class="form-control" placeholder="Search">
			</div>
		</form>
		<ul class="nav menu">
			<li><a href="index.php"><em class="fa fa-dashboard">&nbsp;</em>Admin</a></li>
			
			<li><a href="trainee.php"><em class="fa fa-users">&nbsp;</em>trainee</a></li>

			<li><a href="manager.php"><em class="fa fa-users">&nbsp;</em>manager</a></li>

			<li><a href="trainer.php"><em class="fa fa-product-hunt">&nbsp;</em>trainer</a></li>
			<li><a href="payment.php"><em class="fa fa-product-hunt">&nbsp;</em>payment</a></li>


			

			<li><a href="function/logout.php"><em class="fa fa-power-off">&nbsp;</em>Logout</a></li>
		</ul>
	</div><!--/.sidebar-->