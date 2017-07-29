<?php
class Users {
    private $email;
    private $passsord;
    private $oldpassword;
    private $lastname;
    private $firstname;
    private $id;
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
      $this->id = $data['Id'];

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
    			$query = "UPDATE users SET Email = ?, LastName = ?, FirstName = ? WHERE Id = ?";
          $stmt = $this->conn->prepare($query);
          $stmt->bind_param('sssi',$this->email,$this->lastname,$this->firstname,$this->id);
          $stmt->execute();
    		}
    		catch (Exception $e) {
              $emparray["Error"] = "$e->getMessage()";
            }


      }
      else {
          $emparray["Error"] = "Email already taken!";
      }

      $result =  json_encode($emparray);
      echo $result;
  	}

    function update_password($data)
    {
      $emparray = array();
      $emparray["Error"] = "";
      $this->oldpassword = $data['oldPassword'];
      $this->password = $data['newPassword'];
      $this->id = $data['Id'];

      try{
        $query = "SELECT * FROM users WHERE Id = ?";
        $stmt = $this->conn->prepare($query);
        $stmt->bind_param('i', $this->id);
        $stmt->execute();
        $result = $stmt->get_result();
      }
      catch (Exception $e) {
          $emparray["Error"] =  $e->getMessage();
      }

      $ok = 0;
      $result = mysqli_fetch_assoc($result);
      if(Bcrypt::checkPassword($this->oldpassword, $result["Password"]))
            $ok = 1;

      if($ok==1){

          if(Bcrypt::checkPassword($this->oldpassword,$this->password))
            $emparray["Error"] = "The old password is the same with the new one!";
          else {
            try{
              $query = "UPDATE users SET Password = ? WHERE Id = ?";
              $stmt = $this->conn->prepare($query);
              $stmt->bind_param('si',$this->password, $this->id);
              $stmt->execute();
            }
            catch (Exception $e) {
                  $emparray["Error"] = "$e->getMessage()";
                }
          }
      }
      else {
          $emparray["Error"] = "The password specified is invalid!";
      }
      $result =  json_encode($emparray);
      echo $result;

    }

    function member_existence($data)
    {
      $emparray = array();
      $emparray["Error"] = "";
      $this->email = $data['memberName'];

      try{
        $query = "SELECT * FROM users Where Email = ?";
        $stmt = $this->conn->prepare($query);
        $stmt->bind_param('s', $this->email);
        $stmt->execute();
        $result = $stmt->get_result();

      }catch (Exception $e) {
          $emparray["Error"] =  $e->getMessage();
        }

      if(mysqli_num_rows($result)==1)
        $emparray["Answer"] = "1";
      else
        $emparray["Answer"] = "0";

      $result =  json_encode($emparray);
      echo $result;
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
          if(Bcrypt::checkPassword($this->password, $row["Password"]) && $this->email==$row["Email"])
          {
                $emparray = $row;
                $ok = 1;
                break;
          }
      }
      //if(mysqli_num_rows($result)==1)
      if($ok==1)
      {
          try{
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
