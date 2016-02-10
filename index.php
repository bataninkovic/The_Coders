<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->

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
                <ul class='nav'>
                    <li><a href='#'>Home</a></li>
                    <li><a href='?page=customerform'>Ticket aanmaken</a></li>
                    <li><a href='?page=mytickets'>Mijn Tickets</a></li>
                    <li><a href='#'>pagina3</a></li>
                </ul>
            </header>

            
            
            <content>
                <section>
                    <?php
                    // Pagina
                    if (!isset($_GET['page'])) {
                        $page = 'index.php';
                    } else {
                        $page = $_GET['page'];
                    }

                    switch ($page) {
                        case 'customerform':
                            // Inlogpagina beheerderspaneel
                            include ("customerform.php");
                            break;
                        case 'registration':
                            // Inlogpagina beheerderspaneel
                            include ("Registrationpage.php");
                            break;
                        case 'mytickets':
                            // Pagina met eigen tickets
                            include ("mytickets.php");
                            break;
                        case 'reacttoticket':
                            // Pagina met eigen tickets
                            include ("reacttoticket.php");
                            break;
                    }


?>
                </section>
            </content>
            <footer>Footer</footer>
        </div>
    </body>
</html>

