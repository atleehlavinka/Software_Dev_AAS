<?php

$name = filter_input(INPUT_POST, 'name');

if ($name == null) {
    $error = 'Invalid category name. Please check & try again.';
    include('error.php');
} else {
    require_once('database.php');
    $query = "INSERT INTO categories (categoryName) "
            . "VALUES (:name)";
    $statement = $db->prepare($query);
    $statement->bindValue(':name', $name);
    $statement->execute();
    $statement->closeCursor();
    
    include('category_list.php');
}
?>
