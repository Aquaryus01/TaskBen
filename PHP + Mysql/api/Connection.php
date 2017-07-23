<?php
    class Connection{
        private $connection;
        private $host='localhost';
        private $user='root';
        private $pass='root';
        private $database='taskingben';
        private $rows;

        function __construct() {
            $this->connection = new mysqli($this->host, $this->user, $this->pass, $this->database);
            $this->connection->set_charset("utf8");
            if ($this->connection->connect_error) {
          		die("Connection failed: " . $this->connection->connect_error);
          	}
        }

        function prepare($new_query)
        {
          return $this->connection->prepare($new_query);
        }

    		function get_connection() {
    			return $this->connection;
    		}

        function query($new_query) {
          $res = mysqli_query($this->connection,$new_query);
          if (mysql_errno()) echo mysql_error().'<br>';
            return $res;
        }

        function nr_rows($new_query) {
          return $new_query->num_rows;
          }

        function insert_id()
        {
            return $this->connection->insert_id;
        }
  }
?>
