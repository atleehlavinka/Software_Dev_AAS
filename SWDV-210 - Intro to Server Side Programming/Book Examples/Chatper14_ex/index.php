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
        $trumpet->comment = 'Discontinued';
        echo "<br>" . $trumpet->comment;
        $price = $trumpet->getPriceFormatted();
        echo "<br>" . $price;
        echo $trumpet->getCategory()->getName();
        
        class Person {
            const GREEN_EYES = 1;
            const BLUE_EYES = 2;
            const BROWN_EYES = 3;
            
            public $eye_color;
            
            public function getEyeColor() {
                return $this->eye_color;
            }
            
            public function setEyeColor($value) {
                if ($value == self::GREEN_EYES ||
                        $value == self::BLUE_EYES ||
                        $value == self::BROWN_EYES) {
                    $this->eye_color = $value;
                } else {
                    exit('Eye Color Not Set');
                }
            }
        }
        
        $person = new Person();
        $person->setEyeColor(Person::BROWN_EYES);
        echo "<br> " . $person->eye_color;
        $what = $person->getEyeColor();
        echo "<br> Eye Color is $what";
        
        class Category2 {
            private $id, $name;
            public static $objectCount = 0;
            public function __construct($id, $name) {
                $this->$id = $id;
                $this->$name = $name;
                self::$objectCount++;
            }
            
            public static function getObjectCount() {
                return self::$objectCount;
            }
        }
        $brass = new Category2(1, 'Guitars');
        $brass = new Category2(2, 'Bass');
        echo '<p>Object count: ' .
                Category2::getObjectCount() . '</p>';
        
        $brass = new Category2(3, 'Drums');
        echo '<p>Object count: ' .
                Category2::getObjectCount() . '</p>';
        echo '<p>Object count: ' .
                Category2::$objectCount . '</p>';
        
        class Employee {
            public $firstName, $lastName;
            private $ssn, $dob;
            
            public function __construct($first, $last) {
                $this->firstName = $first;
                $this->lastName = $last;
            }
            
            public function showAll() {
                echo '<ul>';
                foreach ($this as $name => $value) {
                    echo "<li>$name = $value</li>";
                }
                echo '</ul>';
            }
        }
        
        $employee = new Employee('John', 'Doe');
        
        $employee->showAll();
        
        echo '<ul>';
        foreach ($employee as $name => $value) {
            echo "<li>$name = $value</li>";
        }
        echo '</ul>';
        
        ?>
    </body>
</html>
