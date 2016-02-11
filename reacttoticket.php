
 <?php
        $link = mysqli_connect("localhost", "root", "7b4cd", "tickets") or die ("cannot connect to database");
        ?>

        

            <?php
            
            $id = $_GET['ticket_id'];
            $sql = "SELECT * FROM tickets WHERE id = $id";
            $result = mysqli_query($link, $sql) or die ("Cannot select data from database");

            while ($row = mysqli_fetch_array($result)) {
                
                echo '<table class="reacttoticketfield"><td style="border: 1px solid black;">'. $row['issue'] . '</td></table>';
}
            
            

?>

<html>
    <head>
        <meta charset="UTF-8">
        <title>Mijn Tickets</title>
        <link rel="stylesheet" href="style.css">
        
    </head>
    <body
        <div id="formulier">
        <form method="post">
            <div id="issue">Issue :</div>
            <div id="actie">Actie : </div><br>
            <textarea id="reactieveld" class="reactieveld" type="text" name="reactieveld" style="text-align:left"></textarea>
            <div id="reactiebtn"><input type="submit" name="reactiebtn" value="Reageer" action="customerform.php"></div>
        </form>  
        </div>    
      
            
            
    </body>
</html>