<!--
Name: Atlee Hlavinka
Project: Project 4
Description: visit page for the Idaho Souvenir Store
Log:

02/11/2022 - Created visit.php to hold the functions for visit information.
-->

<?php
function addVisit($email_address, $phone, $user_comment) {
    $db = Database::getDB();
    $query = 'INSERT INTO contact
	(email, phone, user_comment, employeeID)
        VALUES(:email_address, :phone, :user_comment, 1)';
    
    $statement = $db->prepare($query);
    $statement->bindValue(':email_address', $email_address);
    $statement->bindValue(':phone', $phone);
    $statement->bindValue(':user_comment', $user_comment);
    $statement->execute();
    $statement->closeCursor();
}

function getVisitByEmp($employeeID) {
    $db = Database::getDB();
    $queryVisit = 'SELECT contact.visitID, contact.email, contact.phone'
                . ', contact.user_comment, contact.employeeID '
                . 'FROM contact JOIN employee '
                . 'ON contact.employeeID = employee.employeeID '
                . 'WHERE employee.employeeID = :employeeID '
                . 'ORDER BY contact.email';
    $statement2 = $db->prepare($queryVisit);
    $statement2->bindValue(":employeeID", $employeeID);
    $statement2->execute();
    $contacts = $statement2;
    return $contacts;
}

function delVisit($visitID) {
    $db = Database::getDB();
    $queryDelete = 'DELETE FROM contact WHERE visitID = :visitID';
    $statement3 = $db->prepare($queryDelete);
    $statement3->bindValue(":visitID", $visitID);
    $statement3->execute();
    $statement3->closeCursor();
}

?>

