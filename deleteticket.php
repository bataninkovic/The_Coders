<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>

        
 <?php
        $link = mysqli_connect("localhost", "root", "7b4cd", "tickets") or die ("cannot connect to database");
        ?>

        
            <?php
            
            $id = $_POST['ticket_id'];
            $sql = "DELETE FROM tickets WHERE id = $id";
            $result = mysqli_query($link, $sql) or die ("Cannot delete data from database");


            
            if($result){
                echo "Ticket is verwijderd";
            }   else {
            echo "Error";
            }
?>

    </body>
</html>
