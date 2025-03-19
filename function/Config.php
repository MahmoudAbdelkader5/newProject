<?php
define('HOSTNAME', 'localhost');
define('USERNAME', 'root');
define('PASSWORD', '');
define('DBNAME', 'gym');



// oop connection
//$conn = new mysqli("localhost" ,"root" ,"" , "iti");
$conn = new mysqli(HOSTNAME,USERNAME,PASSWORD,DBNAME);

