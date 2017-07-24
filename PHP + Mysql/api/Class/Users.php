<?php
class Users {
    private $email;
    private $passsord;
    private $lastname;
    private $firstname;
    private $conn;

    function __construct() {
        $this->conn = new Connection();
    }

    function register($data)
    {
      $this->email = $data['email'];
	  $this->password = $data['password'];
	  $this->lastname =  $data['lastname'];
	  $this->firstname = $data['firstname'];
      $emparray = array();

      try{
        $query = 'SELECT * FROM users WHERE Email = ?';
        $stmt = $this->conn->prepare($query);
        $stmt->bind_param('s', $this->email);
        $stmt->execute();
        $result = $stmt->get_result();
      }catch (Exception $e) {
          $emparray["Error"] = "$e->getMessage()";
        }

      if(mysqli_num_rows($result)==0)
      {
          try{
            $query = "INSERT INTO users(Email,Password,FirstName,LastName) VALUES (?,?,?,?)";
            $stmt = $this->conn->prepare($query);
            $stmt->bind_param('ssss',$this->email,$this->password,$this->firstname,$this->lastname);
            $stmt->execute();
          }catch (Exception $e) {
              $emparray["Error"] = "$e->getMessage()";
            }
      }
      else {
          $emparray["Error"] = "The entered e-mail adress is already in use!";
      }
      if(!isset($emparray["Error"]))
        echo "";
      else
        echo $emparray["Error"];
    }
	
	function update($data)
	{
		$emparray = array();
		$emparray["Error"] = "";
		$this->email = $data['email'];
		$this->lastname =  $data['lastname'];
		$this->firstname = $data['firstname'];
		try{
			
			$query = "UPDATE users SET Email = ?, LastName = ?, FirstName = ?";
            $stmt = $this->conn->prepare($query);
            $stmt->bind_param('sss',$this->email,$this->firstname,$this->lastname);
            $stmt->execute();
		}
		catch (Exception $e) {
          $emparray["Error"] = "$e->getMessage()";
        }
		
		$result =  json_encode($emparray);
		echo $result;
        /*if($emparray["Error"] == "")
          echo "";
        else
          echo json_encode($emparray, JSON_PRETTY_PRINT);*/
	}

    function login($data)
    {
      $this->email = $data['email'];
			$this->password = $data['password'];
      try{
        $query = "SELECT * FROM users";
        $stmt = $this->conn->prepare($query);
        $stmt->execute();
        $result = $stmt->get_result();
        /*$query = "SELECT * FROM users WHERE Email = ? AND Password = ?";
        $stmt = $this->conn->prepare($query);
        $stmt->bind_param('ss', $this->email,$this->password);
        $stmt->execute();
        $result = $stmt->get_result();
        */
      }catch (Exception $e) {
          $emparray["Error"] =  $e->getMessage();
        }

      $ok = 0;
      while($row =mysqli_fetch_assoc($result))
      {
          $emparray = $row;
          if(Bcrypt::checkPassword($this->password, $emparray["Password"]))
          {
              if($this->email==$emparray["Email"])
              {
                $ok = 1;
                break;
              }
          }
      }
      //if(mysqli_num_rows($result)==1)
      if($ok==1)
      {
          try{

            while($row =mysqli_fetch_assoc($result))
                $emparray = $row;

            $token = array();
        		$token['id'] = $emparray["Id"];
        		$emparray["Jwt"] = JWT::encode($token, JWT::$key);
            $emparray["Error"] = "";



          }catch (Exception $e) {
              $emparray["Error"] = "$e->getMessage()";
            }
      }else {
          $emparray["Error"] = "The username and password didn't match!";
      }

      $result =  json_encode($emparray);
      echo $result;
    }

    function set_email($new_email) {
			$this->email = $new_email;
		}

		function get_email() {
			return $this->email;
		}

    function set_password($new_password) {
			$this->password = $new_password;
		}
		function get_password() {
			return $this->password;
		}
    function set_lastname($new_lastname) {
			$this->lastname = $new_lastname;
		}
		function get_lastname() {
			return $this->lastname;
		}
    function set_firstname($new_firstname) {
			$this->firstname = $new_firstname;
		}
		function get_firstname() {
			return $this->firstname;
		}
}
?>
