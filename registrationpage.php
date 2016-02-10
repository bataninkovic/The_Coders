<!DOCTYPE html>
<?php
$link = mysqli_connect("localhost", "root", "powers00", "tickets");
?>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Ticketsysteem</title>
        <link rel="stylesheet" href="style.css">
    </head>
    <body>
        <?php
        // Variabelen voor het formulier
        $username = "";
//        $name = "";
        // Formulier is opgestuurd
        if ($_SERVER['REQUEST_METHOD'] == 'POST' && isset($_POST['submit'])) {
            // Verstuurde gegevens
            $username = $_POST['username'];
//            $name = $_POST['naam'];
            $password = $_POST['password'];
            $password2 = $_POST['wachtwoord2'];

            // Controleer of alle///  empty($name) ||  /// verplichte velden zijn ingevuld
            if (empty($username) || empty($password)) {
                echo "<p class='error'>Een of meer verplichte velden zijn niet ingevuld!</p>";
            } else {
                // Controleren of de wachtwoorden overeenkomen
                if ($password != $password2) {
                    echo "<p class='error'>De wachtwoorden komen niet overeen!</p>";
                } else {
                    // Controleren of het wachtwoord voldoet aan de eisen
                    if (strlen($password) < 8 || !preg_match('/[^a-zA-Z\d]/', $password)) {
                        // Het wachtwoord heeft minder dan 8 karakters
                        echo "<p class='error'>Het wachtwoord voldoet niet aan de minimale eisen!<br /> Het wachtwoord moet bestaan uit minimaal 8 karakters en moet alfanumerieke tekens bevatten.</p>";
                    } else {
                        // Controleren of de gebruikersnaam al bestaat in de database
                        $stmt = mysqli_prepare($link, "SELECT * FROM user WHERE username = ?");
                        mysqli_stmt_bind_param($stmt, "s", $username);
                        mysqli_stmt_execute($stmt);
                        mysqli_stmt_store_result($stmt);
                        if (mysqli_stmt_num_rows($stmt) > 0) {
                            echo "<p class='error'>De gebruikersnaam bestaat al!</p>";
                        } else {
                            // Wachtwoord versleutelen
                            $password = hash('sha512', $password);

                            // Nieuwe gebruikersgegevens opslaan in de database
                            $insert = mysqli_prepare($link, "INSERT INTO user (username, password) VALUES (?, ?)");
                            mysqli_stmt_bind_param($insert, "ss", $username, $password);
                            mysqli_stmt_execute($insert);

                            // Doorverwijzen pagina
                            //                                        header("Location: index.php?page=users");

                            mysqli_stmt_free_result($insert);
                            mysqli_stmt_close($insert);
                            die();
                        }

                        mysqli_stmt_free_result($stmt);
                        mysqli_stmt_close($stmt);
                    }
                }
            }
        }
        ?>

        <form method="post" action="">
            <table>
                <tr>
                    <td>Gebruikersnaam: *</td>
                    <td><input type="text" name="username" value="<?php echo $username; ?>" /></td>
                </tr>
<!--                <tr>
                    <td>Naam: *</td>
                    <td><input type="text" name="naam" value="<?php echo $name; ?>"/></td>
                </tr>-->
                <tr>
                    <td>Wachtwoord: *</td>
                    <td><input type="password" name="password" /></td>
                </tr>
                <tr>
                    <td>Wachtwoord herhalen: *</td>
                    <td><input type="password" name="wachtwoord2" /></td>
                </tr>
                <tr>
                    <td><input type="submit" name="submit" value="Aanmaken" class="button" /></td>
                    <td></td>
                </tr>
            </table>
        </form>
    </body>
</html>