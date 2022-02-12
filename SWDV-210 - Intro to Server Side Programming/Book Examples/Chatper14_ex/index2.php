<!DOCTYPE html>
<!--
Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
Click nbfs://nbhost/SystemFileSystem/Templates/Project/PHP/PHPProject.php to edit this template
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
        <link href="main.css" rel="stylesheet" type="text/css"/>
    </head>
    <body>
        <?php
        
        include 'category.php';
        include 'product.php';
        
        $brass = new Category(4, 'Brass');
        $trumpet = new Product($brass,
                'Getzen',
                'Getzen 700SP Trumpet',
                934.23);
        $trombone = $trumpet;
        echo '<br/>Trumpet price: ' . $trumpet->getPrice();
        echo '<br/>Trombone price after assignment: ' . $trombone->getPrice();
        
        $trombone->setPrice(699.95);
        echo '<br/>Trumpet price: ' . $trumpet->getPrice();
        echo '<br/>Trumbone price: ' . $trombone->getPrice();
        
        $tuba = clone $trombone;
        echo '<br/><br/>Cloned Tuba price: ' . $tuba->getPrice();
        
        $tuba->setPrice(899.95);
        echo '<br/>Changed Tuba price: ' . $tuba->getPrice();
        echo '<br/>Trombone price after changing tuba price: ' . $trombone->getPrice();
        
        echo '<br/>Trumpet Name: ' . $trumpet->getCategory()->getName();
        $trombone->getCategory()->setName('Orchestral Brass');
        echo '<br/>Trombone Cat Name: ' . $trombone->getCategory()->getName();
        echo '<br/>Trumpet Cat Name: ' . $trumpet->getCategory()->getName();
        echo '<br/>Tuba Cat Name: ' . $tuba->getCategory()->getName();
        
        echo '<br/><br/>';
        echo '<br/>Result_1: ' . $result_1 = ($trumpet == $trombone);
        $flugelhorn = clone $trumpet;
        echo '<br/>Result_2: ' . $result_2 = ($trumpet == $flugelhorn);
        echo '<br/>Result_2: ' . $result_3 = ($trumpet === $flugelhorn);
        $trumpet_2 = $trumpet;
        echo '<br/>Result_2: ' . $result_4 = ($trumpet === $trumpet_2);
        echo '<br/>Result_2: ' . $result_4 = ($trumpet->getCategory() === $trombone->getCategory());
        
        echo '<br/>';
        
        if (is_a($trumpet, 'Product')) {
            echo 'trumpet belongs to Product class.' . '<br/>';
        }
        if (property_exists($trumpet, 'price')) {
            echo 'price is a property of the trumpet instance.' . '<br/>';
        }
        if (method_exists($trumpet, 'getPrice')) {
            echo 'getPrice is a method for the trumpet instance.' . '<br/>';
        }
        
        class Person2 {
            private $firstName, $lastName, $phone, $email;
            public function __construct($first, $last) {
                $this->firstName = $first;
                $this->lastName = $last;
            }
            public function getFirstName() {
                return $this->firstName;
            }
            public function setFirstName($value) {
                $this->firstName = $value;
            }
            public function getLastName() {
                return $this->lastName;
            }
            public function setLastName($value) {
                $this->lastName = $value;
            }
            public function getPhone() {
                return $this->phone;
            }
            public function setPhone($value) {
                $this->phone = $value;
            }
            public function getEmail() {
                return $this->email;
            }
            public function setEmail($value) {
                $this->email = $value;
            }
        }
        
        class Employee2 extends Person2 {
            private $ssn, $hireDate;
            public function __construct(
                    $first, $last, $ssn, $hireDate) {
                $this->ssn = $ssn;
                $this->hireDate = $hireDate;
                parent::__construct($first, $last);
            }
            public function getSSN() {
                return $this->ssn;
            }
            public function setSSN($value) {
                $this->ssn = $value;
            }
            public function getHireDate() {
                return $this->hireDate;
            }
            public function setHireDate($value) {
                $this->hireDate = $value;
            }
        }
        
        $emp = new Employee2('John','Doe','999-14-3456', '8-25-1996');
        $emp->setPhone('919-555-4321');
        echo '<p>' . $emp-> getFirstName() . ' '
                    . $emp-> getLastName() . ' '
                    . $emp-> getSSN() . ' '
                    . $emp-> getPhone() . '</p>';
        
        abstract class Person3 {
            private $firstName, $lastName, $phone, $email;
            public function __construct($first, $last) {
                $this->firstName = $first;
                $this->lastName = $last;
            }
//            final 
            public function getFirstName() {
                return $this->firstName;
            }
            public function setFirstName($value) {
                $this->firstName = $value;
            }
            public function getLastName() {
                return $this->lastName;
            }
            public function setLastName($value) {
                $this->lastName = $value;
            }
            public function getPhone() {
                return $this->phone;
            }
            public function setPhone($value) {
                $this->phone = $value;
            }
            public function getEmail() {
                return $this->email;
            }
            public function setEmail($value) {
                $this->email = $value;
            }
        }
        
        class Employee3 extends Person3 {
            private $ssn, $hireDate;
            public function __construct(
                    $first, $last, $ssn, $hireDate) {
                $this->ssn = $ssn;
                $this->hireDate = $hireDate;
                parent::__construct($first, $last);
            }
            
            public function getFirstName() {
                return ucwords($this->firstName);
            }
            public function getSSN() {
                return $this->ssn;
            }
            public function setSSN($value) {
                $this->ssn = $value;
            }
            public function getHireDate() {
                return $this->hireDate;
            }
            public function setHireDate($value) {
                $this->hireDate = $value;
            }
        }
        
        class Customer extends Person3 {
            private $cardNumber, $cardType;
            public function __construct($first, $last, $phone, $email) {
                $this->setPhone($phone);
                $this->setEmail($email);
                parent::__construct($first, $last);
            }
            public function getCardNumber() {
                return $this->cardNumber;
            }
            public function setCardNumber($value) {
                $this->cardNumber = $value;
            }
            public function getCardType() {
                return $this->cardType;
            }
            public function setCardType($value) {
                $this->cardType = $value;
            }
            public function getFullName() {
                return $this->getFirstName() . ' ' . $this->getLastName();
            }
        }
        
        $emp = new Employee3('John','Deere','349-14-1256', '2-1-1967');
        $customer = new Customer('Jack', 'Doe', '919-234-1234', 'jdoe@gmail.com');
        echo '<p>' . $emp->getLastName() . $emp->getHireDate() . '</p>';
        echo '<p>' . $customer->getLastName() . $customer->getEmail() . '</p>'; 
        
        interface Animal {
            public function makeSound();
        }
        class Cat implements Animal {
            public function makeSound() {
                echo " Meow ";
            }
        }
        class Dog implements Animal {
            public function makeSound() {
                echo " Bark ";
            }
        }
        class Mouse implements Animal {
            public function makeSound() {
                echo " Squeak ";
            }
        }
        
        $cat = new Cat();
        $dog = new Dog();
        $mouse = new Mouse();
        $animals = array($cat, $dog, $mouse);
        
        foreach ($animals as $animal) {
            $animal->makeSound();
        }
        
        ?>
    </body>
</html>
