<html>
    <head>
        <meta charset="UTF-8">
        <title>Mijn Tickets</title>
        <link rel="stylesheet" href="style.css">
        
    </head>
    <body
        <div id="formulier">
        <form method="post">
            Issue :<br>
            <input  method="get" id="ticket" type="text" name="ticketissue" style="width: 60em; text-align:left"></br>
            Reactie : <br>
            <textarea id="reactieveld" class="reactieveld" type="text" name="reactieveld" style="width: 60em; text-align:left"></textarea>
            <div id="verzendknop"><input type="submit" name="verzendknop" value="Reageer" action="customerform.php"></div>
        </form>  
        </div>    
      
            
            
    </body>
</html>
 <?php
        $link = mysqli_connect("localhost", "root", "7b4cd", "tickets") or die ("cannot connect to database");
        ?>

        

            <?php
            
            $id = $_GET['ticket_id'];
            $sql = "SELECT * FROM tickets WHERE id = $id";
            $result = mysqli_query($link, $sql) or die ("Cannot select data from database");

            echo $id;
            while ($row = mysqli_fetch_array($result)) {
            echo $row['issue'];
}
            
            

?>