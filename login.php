<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<?php
$link = mysqli_connect("localhost", "root", "7b4cd", "test");
?>

<html>
    <head>
        <meta charset="UTF-8">
        <title>Ticketsysteem</title>
        <link rel="stylesheet" href="style.css">
    </head>
    <body>
        <div class='Ticksys'>
            <header>
                <h1>Logo</h1>
            </header>
            <content>
                <section>
                    <?php
                    // Gebruikersnaam en wachtwoord controleren
                    if ($_SERVER['REQUEST_METHOD'] == 'POST' && isset($_POST['submit'])) {
                        // Verstuurde gegevens
                        $username = $_POST['inlog'];
                        $password = $_POST['wachtwoord'];

                        // Controleer of alle gegevens zijn ingevuld
                        if (empty($username) || empty($password)) {
                            echo "<p class='error'>Gebruikersnaam of wachtwoord onjuist!</p>";
                        } else {
                            // Versleuteling toepassen
                            $password = hash('sha512', $password);

                            // Controleer of de gebruikersgegevens kloppen in de database
                            $stmt = mysqli_prepare($link, "SELECT medewerkernr, naam FROM tickets WHERE inlog = ? AND wachtwoord = ?");
                            mysqli_stmt_bind_param($stmt, "ss", $username, $password);
                            mysqli_stmt_execute($stmt);
                            mysqli_stmt_bind_result($stmt, $userID, $name);
                            mysqli_stmt_store_result($stmt);
                            mysqli_stmt_fetch($stmt);

                            // Gebruiker mag wel inloggen en inloggegevens zijn correct
                            $_SESSION['medewerkernr'] = $userID;
                            $_SESSION['loggedin'] = true;
                            $_SESSION['username'] = $username;
                            

                            
                            // Doorsturen naar beheerderspaneel
                            header("Location: index.php");
                        }
                        mysqli_stmt_free_result($stmt);
                        mysqli_stmt_close($stmt);
                    }
                    ?>

                    <form method="post" action="">
                        <table>
                            <tr>
                                <td>Gebruikersnaam: </td>
                                <td><input type="text" name="inlognaam" /></td>
                            </tr>
                            <tr>
                                <td>Wachtwoord: </td>
                                <td><input type="password" name="wachtwoord" /></td>
                            </tr>
                            <tr>
                                <td><input type="submit" name="submit" value="Inloggen" /></td>
                            </tr>
                        </table>
                    </form>
                    
                    
                </section>
            </content>

            <footer>Footer</footer>
        </div>
    </body>
</html>