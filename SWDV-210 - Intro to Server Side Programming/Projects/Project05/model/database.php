<!--
Name: Atlee Hlavinka
Project: Project 4
Description: database page for the Idaho Souvenir Store
Log:

02/11/2022 - Created database.php to hold the Database class.
-->

<?php

class Database {
    private static $dsn = 'mysql:host=localhost;dbname=IdahoSouvenir';
    private static $username = 'onlineuser';
    private static $password = 'pa55word';
    private static $db;
    
    private function __construct() {
        
    }
    
    public static function getDB() {
        if (!isset(self::$db)) {
            try {
                self::$db = new PDO(self::$dsn,
                        self::$username,
                        self::$password);
            } catch (PDOException $ex) {
                $error_message = $e->getMessage();
                exit();
            }
        }
        return self::$db;
    }
}


    $dsn = 'mysql:host=localhost;dbname=IdahoSouvenir';
        $username = 'onlineuser';
        $password = 'pa55word';
        $db = new PDO($dsn, $username, $password);

?>

