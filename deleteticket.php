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
        $link = mysqli_connect("localhost", "root", "powers00", "tickets") or die("cannot connect to database");
        ?>






        <?php
        $url = "?page=mytickets.php";
        $id = $_POST['ticket_id'];
        $sql = "DELETE FROM tickets WHERE id = $id";
        $result = mysqli_query($link, $sql) or die("Cannot delete data from database");



        if ($result) {
            echo "<script type='text/javascript'>alert('Ticket is verwijderd');"
            . "window.location.href='index.php?page=mytickets';</script>";
        } else {
            echo "Error";
        }
        ?>

    </body>
</html>
