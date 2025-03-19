<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
body 
<body>
	<div class="row">
		<div class="col-xs-10 col-xs-offset-1 col-sm-8 col-sm-offset-2 col-md-4 col-md-offset-4">
			
{font-family: Arial, Helvetica, sans-serif;}
form {border: 3px solid #f1f1f1;}

input[type=text], input[type=password] {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}

button {
  background-color: #04AA6D;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
}

button:hover {
  opacity: 0.8;
}

.cancelbtn {
  width: auto;
  padding: 10px 18px;
  background-color: #f44336;
}

.imgcontainer {
  text-align: center;
  margin: 24px 0 12px 0;
}

img.avatar {
  width: 40%;
  border-radius: 50%;
}

.container {
  padding: 16px;
}

span.psw {
  float: right;
  padding-top: 16px;
}

/* Change styles for span and cancel button on extra small screens */
@media screen and (max-width: 300px) {
  span.psw {
     display: block;
     float: none;
  }
  .cancelbtn {
     width: 100%;
  }
}
</style>
</head>
<body>

<h2>Login</h2>

<form action="function/login.php" method="post">
  <div class="imgcontainer">
    <img src="https://i0.wp.com/post.healthline.com/wp-content/uploads/2020/11/Male_Gym_Mask_732x549-thumbnail-732x549.jpg?w=756&amp;h=567" alt="Avatar" class="avatar">
  </div>

  <div class="container">
    <label for="uname"><b>E-mail</b></label>
    <input type="text" placeholder="Enter Your E-mail" name="username" required>

    <label for="psw"><b>Password</b></label>
    <input type="password" placeholder="Enter Password" name="password" required>
        
    <input type="submit" class="btn btn-primary" name="submit" value="Login">
    <label>
      <input type="checkbox" checked="checked" name="remember"> Remember me
    </label>
  </div>

  <div class="container" style="background-color:#f1f1f1">
  </div>
                            <button type="submit" class="site-btn login-btn">Sign In</button>
                            <form action="http://localhost/Gym/register.php" method="post">
                        <div class="switch-login">
                            <a href="http://localhost/Gym/register.php" class="or-login">Or Create An Account</a>
                        </div>
  </div>
</form>


</body>
</html>