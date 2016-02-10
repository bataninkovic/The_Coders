<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->

<html>
    <head>
        <meta charset="UTF-8">
        <title>customerform</title>
        <link rel="stylesheet" href="style.css">
    </head>
    <body>
        <content>
            <section>
                <div id="tickettitel">Dien hier uw ticket in.<div>
                <div id="formulier">
        <form method="post">
            Onderwerp :<br>
            <input  method="post" id="onderwerp" type="text" name="onderwerp" style="width: 60em; text-align:left"></br>
            Issue : <br>
            <textarea id="issueveld" class="issueveld" type="text" name="issueveld"></textarea>
            <div id="verzendknop"><input type="submit" name="verzendknop" value="Verzenden" action="customerform.php"></div>
        </form>    
            </div>
            </section>
       </content>     
    </body>
</html>

<?php

if ($_SERVER["REQUEST_METHOD"] == "POST"){
$link = mysqli_connect('localhost', 'root', '7b4cd', 'tickets')or die("Cannot connect to database");

$onderwerp = $_POST['onderwerp'];
$issueveld = $_POST['issueveld'];
$timestamp = $_SERVER['REQUEST_TIME'];
$date = date('d-m-y',$timestamp);
$time = (date('h:i:s', $timestamp));



    $sql="INSERT INTO tickets(subject, issue, timestamp) VALUES('$onderwerp','$issueveld','$date,$time')";


mysqli_query($link, $sql);
$result= mysql_errno();

if($result){?>
<div id="errormsg"> Error </div>
<?php 
}else{    
?>
    
<div id="succesmsg"> Uw ticket is verzonden.</div>
<?php
}

}
?>

