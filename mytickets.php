<!DOCTYPE html>

<html>
    <head>
        <meta charset="UTF-8">
        <title>Mijn Tickets</title>
        <link rel="stylesheet" href="style.css">
    </head>
    <body
        <?php
        $link = mysqli_connect("localhost", "root", "7b4cd", "tickets") or die ("cannot connect to database");
        ?>
            <?php
            $buttonref = "<a>href='?page=reacttoticket'></a>";
            $sql = "SELECT * FROM tickets";
            $result = mysqli_query($link, $sql) or die ("Cannot select data from database");
            

            echo "<div id='mijntickets'>";                   
            
            echo "<table class='ticketweergave'";
            echo "<tr><td><strong>Onderwerp</strong></td><td><strong>Issue</strong></td><td><strong>Datum/Tijd</strong></td><br></tr>";
            
            while($row = mysqli_fetch_array($result)){
                $onderwerp = $row['subject'];
                $issue = $row['issue'];
                $tijd = $row['timestamp'];
                
                echo "<tr><td>".$onderwerp."</td><div id='myissue'><td>".$issue."</td></div><td>".$tijd."</td><td><div id='reageerknop'><a href='?page=reacttoticket'><input type='button' value='Reageer' </div></a></td></tr>";  
            }
              echo "</table><br/><br/></div>";
              mysqli_close($link)
              
              
            ?>
            </content>
</section>
    </body>
</html>