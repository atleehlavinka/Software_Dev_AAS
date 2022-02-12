<!--
Name: Atlee Hlavinka
Project: Project 3
Description: Admin page for the Idaho Souvenir Store
Log:

02/02/2022 - Created admin.php page. Entered text giving plan for webpage.
02/04/2022 - Implemented logic for displaying all 
employees and a list of comments by employeeID. Added functionality to 
delete records.
-->

<?php 

try {
//        $dsn = 'mysql:host=localhost;dbname=idahoSouvenir';
//        $username = 'online';
//        $password = 'Pa$$w0rd';
//        $db = new PDO($dsn, $username, $password);
        require_once ('./model/database.php');
        require_once ('./model/visit.php');
        require_once ('./model/employee.php');
    } catch (PDOException $ex) {
        $error_message = $ex->getMessage();
        echo 'DB Error: ' .$error_message;
    }
    
$action = filter_input(INPUT_POST, 'action');
if ($action == NULL) {
    $action = filter_input(INPUT_GET, 'action');
    if ($action == NULL) {
        $action = 'list_visits';
    }
}

if ($action == 'list_visits') {
    $employeeID = filter_input(INPUT_GET, 'employeeID', FILTER_VALIDATE_INT);
    if ($employeeID == NULL || $employeeID == FALSE) {
        $employeeID = filter_input(INPUT_POST, 'employeeID', FILTER_VALIDATE_INT);
        if ($employeeID == NULL || $employeeID == FALSE) {
            $employeeID = 1;
        }
    }
    try {
        $employees = EmployeeDB::getEmp();
        $contacts = getVisitByEmp($employeeID);
        
    } catch (PDOException $ex) {
        $error_message = $e->getMessage();
        echo 'DB Error: ' . $error_message;
    }
} else if ($action == 'delete_visit') {
    $visitID = filter_input(INPUT_POST, 'visitID', FILTER_VALIDATE_INT);
    $employeeID = filter_input(INPUT_POST, 'employeeID', FILTER_VALIDATE_INT);
//    $queryDelete = 'DELETE FROM contact WHERE visitID = :visitID';
//    $statement3 = $db->prepare($queryDelete);
//    $statement3->bindValue(":visitID", $visitID);
//    $statement3->execute();
//    $statement3->closeCursor();
    delVisit($visitID);
    header("Location: admin.php?employeeID=$employeeID");
    } 
//$email_address = filter_input(INPUT_POST, 'email_address');
//$phone = filter_input(INPUT_POST, 'phone');
//$user_comment = filter_input(INPUT_POST, 'user_comment');
//
//
//if ($email_address == null || $phone == null || $user_comment == null) {
//    $error = "Invalid input data. Please re-enter fields.";
//    echo "Form Data Error: " . $error;
//    exit();
//} else {
//    try {
//        $dsn = 'mysql:host=localhost;dbname=idahoSouvenir';
//        $username = 'online';
//        $password = 'Pa$$w0rd';
//        $db = new PDO($dsn, $username, $password);
//    } catch (PDOException $ex) {
//        $error_message = $e->getMessage();
//        echo 'DB Error: ' .$error_message;
//    }
//    
//    $query = 'INSERT INTO contact
//	(email, phone, user_comment, employeeID)
//        VALUES(:email_address, :phone, :user_comment, 1)';
//    
//    $statement = $db->prepare($query);
//    $statement->bindValue(':email_address', $email_address);
//    $statement->bindValue(':phone', $phone);
//    $statement->bindValue(':user_comment', $user_comment);
//    $statement->execute();
//    $statement->closeCursor();
//}

?>

<!doctype html>
<html lang="en">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <script defer src="js/lib/fontawesome-all.min.js"></script>

        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css" rel="stylesheet" >
        <link href="css/stylesheet.css" rel="stylesheet" >
        <link href="css/carousel.css" rel="stylesheet" >

        <title>The Idaho Souvenir Store</title>
    </head>
    <body class="backgroundimg">
    
        <header>
            <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark mb-5">
                <div class="container-fluid">
                    <div class="container-fluid row">
                        <div class="container container-fluid col">
                            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
                                <span class="navbar-toggler-icon"></span>
                            </button>
                            <div class="collapse navbar-collapse" id="navbarCollapse">
                                <ul class="navbar-nav me-auto mb-2 mb-md-0">
                                    <li class="nav-item mt-1">
                                        <a class="navbar-brand" href="index.html">The Idaho Souvenir Store</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" aria-current="page" href="index.html">Home</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="about.html">About</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="contact.html">Contact</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="store.html">Store</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="admin.php">Admin</a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" href="listemployees.php">EmpList</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
              </nav>
        </header>
        
        <main>
        
          <div class="container sectiontitle">
            <h1 class="mt-5 text-center ">Admin</h1>
            <h3 class="mt-5 text-center">Plan: 1. Successfully connect to DB. 2. Get list of employees to show.
                        3. Get a list of the contact info to show based on emplyoeeID
                        4. Be able to delete Users 5. Stay on the same page after deleting
                        users.</h3>
          </div>
          <div class="container marketing sectioncontent mt-5 py-5 px-5 mb-5 bg-dark">
            <section class="container-fluid secondary" id="contact">
                <br><br><br>
                <div class="container-fluid text-sm-center">
<!--                    <h1>Admin</h1>
                    <h4>Plan: 1. Successfully connect to DB. 2. Get list of employees to show.
                        3. Get a list of the contact info to show based on emplyoeeID
                        4. Be able to delete Users 5. Stay on the same page after deleting
                        users.
                    </h4>-->
                    <aside>
                        <ul style="list-style-type: none;">
                            <?php foreach ($employees as $employee) : ?>
                            <li>
                                <a href="?employeeID=<?php echo $employee['employeeID'] ?>">
                                    <?php echo $employee['first_name'] . ' ' . $employee['last_name']; ?>
                                </a>
                            </li>
                            <?php endforeach; ?>
                        </ul>
                    </aside>
                </div>
            </section>
          </div>
          <div class="container marketing sectioncontent mt-5 py-5 px-5 mb-5 bg-dark">
            <section class="container-fluid secondary" id="contact">
                <br><br><br>
                <div class="container-fluid text-sm-center">
<!--                    <h1>Admin</h1>
                    <h4>Plan: 1. Successfully connect to DB. 2. Get list of employees to show.
                        3. Get a list of the contact info to show based on emplyoeeID
                        4. Be able to delete Users 5. Stay on the same page after deleting
                        users.
                    </h4>-->
                    <table>
                        <tr>
                            <th>ID</th>
                            <th>Email</th>
                            <th>Phone</th>
                            <th>Comment</th>
                            <th></th>
                        </tr>
                        <?php foreach ($contacts as $contact) : ?>
                        <tr>
                            <td><?php echo $contact['visitID']; ?></td>
                            <td><?php echo $contact['email']; ?></td>
                            <td><?php echo $contact['phone']; ?></td>
                            <td><?php echo $contact['user_comment']; ?></td>
                            <td>
                                <form action="admin.php" method="post">
                                    <input type="hidden" name="employeeID"
                                           value="<?php echo $contact['employeeID']; ?>">
                                    <input type="hidden" name="action"
                                           value="delete_visit">
                                    <input type="hidden" name="visitID"
                                           value="<?php echo $contact['visitID']; ?>">
                                    <input type="submit" value="Delete">
                                </form>
                            </td>
                        </tr>
                        <?php endforeach; ?>
                    </table>
                </div>
            </section>
          </div>
        </main>
        
          <footer class="bg-dark d-flex justify-content-center">
            <section class="layout-social py-5">
                <a class="text-light px-2" href="https://twitter.com/planetoftheweb">
                    <i class="layout-icon fab fa-twitter"></i>
                </a>
    
                <a class="text-light px-2" href="https://linkedin.com/in/planetoftheweb">
                    <i class="layout-icon fab fa-linkedin"></i>
                </a>
    
                <a class="text-light px-2" href="https://github.com/planetoftheweb">
                    <i class="layout-icon fab fa-github"></i>
                </a>
    
                <a class="text-light px-2" href="https://www.youtube.com/user/planetoftheweb">
                    <i class="layout-icon fab fa-youtube"></i>
                </a>
            </section>
          </footer>

      <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
      <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>
      <script src="./js/contact.js"></script>
    </BODY>
</HTML>

