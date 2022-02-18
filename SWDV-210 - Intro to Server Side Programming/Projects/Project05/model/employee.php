<!--
Name: Atlee Hlavinka
Project: Project 4
Description: employee page for the Idaho Souvenir Store
Log:

02/11/2022 - Created employee.php to hold the Employee classes.
-->

<?php

class Employee {
    private $first_name, $last_name;
    
    public function __construct($first_name, $last_name) {
        $this->first_name = $first_name;
        $this->last_name = $last_name;
    }
    
    public function getFirstName() {
        return $this->first_name;
    }
    
    public function getLastName() {
        return $this->last_name;
    }
}

class EmployeeDB{
    public static function getEmployees() {
        $db = Database::getDB();
        $query = 'SELECT first_name, last_name FROM employee ORDER BY last_name';
        $statement = $db->prepare($query);
        $statement->execute();
        $rows = $statement->fetchAll();
        $statement->closeCursor();
        
        $employees = array();
        foreach ($rows as $row){
            $employeeObject = new Employee($row['first_name'], $row['last_name']);
            $employees[] = $employeeObject;
        }
        return $employees;
    }
    
    public static function getEmp() {
        $db = Database::getDB();
        $queryEmployee = 'SELECT * FROM employee';
        $statement1 = $db->prepare($queryEmployee);
        $statement1->execute();
        $employees = $statement1;
        return $employees;
    }
}

?>

