<?php
class Groups
{
    private $conn;
    private $name;
    private $description;
    private $id_user;
    private $id;

    function __construct() {
        $this->conn = new Connection();
    }

    function get_members($data)
    {
      $query = "SELECT u.Email
                FROM group_user gu
                  INNER JOIN users u
                    ON gu.Id_user=u.Id
                WHERE gu.Id_group = ?";
      $stmt = $this->conn->prepare($query);
      $stmt->bind_param('i', $data["id"]);
      $stmt->execute();
      $result = $stmt->get_result();

      while($row = mysqli_fetch_assoc($result))
      {
          $emparray[] = $row;
      }

      $result =  json_encode($emparray);
      echo $result;
    }

    function remove($data)
    {
      $this->id = $data['id'];
      $emparray["Error"] = "";

      try{
        $sql = "DELETE FROM tasks WHERE Id_group = '$this->id'";
        $this->conn->query($sql);

        $sql = "DELETE FROM group_user WHERE Id_group = '$this->id'";
        $this->conn->query($sql);

        $sql = "DELETE FROM groups WHERE Id = '$this->id'";
        $this->conn->query($sql);

      }catch (Exception $e) {
          $emparray["Error"] = "$e->getMessage()";
        }


        if($emparray["Error"] == "")
          echo "";
        else
          echo json_encode($emparray, JSON_PRETTY_PRINT);
    }

    function get_groups($data)
    {
          $emparray = array();
          $query = "SELECT g.Id, g.Name, g.Description, g.Id_user
                    FROM groups g
                      INNER JOIN group_user gu
                        ON gu.Id_group=g.Id
                    WHERE gu.Id_user = ?";
          $stmt = $this->conn->prepare($query);
          $stmt->bind_param('i', $data["idUser"]);
          $stmt->execute();
          $result = $stmt->get_result();

          while($row = mysqli_fetch_assoc($result))
          {
              $emparray[] = $row;
          }

          $result =  json_encode($emparray);
          echo $result;
    }

    function save($data)
    {
        $this->id_user = $data['idUser'];
        $this->id = $data['Id'];
        $this->name = $data['Name'];
        $this->description = $data['Description'];
        $emparray = array();
        $emparray["Error"] = "";

        try
        {
            $query = "SELECT Id from groups where Id_user = ? AND Name = ? AND Id != ?";
            $stmt = $this->conn->prepare($query);
            $stmt->bind_param('isi', $this->id_user, $this->name, $this->id);
            $stmt->execute();
            $result = $stmt->get_result();
            if(mysqli_num_rows($result)==0)
            {

                if($this->id == 0)
                {
                  $query = "INSERT INTO groups (Name, Description, Id_user) VALUES (?,?,?)";
                  $stmt = $this->conn->prepare($query);
                  $stmt->bind_param('ssi',$this->name, $this->description, $this->id_user);
                  $stmt->execute();

                  //echo $this->name." - ".$this->description." - ".$this->id_user;
                  $this->id = $this->conn->insert_id();
                  $emparray['Id'] = $this->id;


                }
                else
                {
                  $query = "UPDATE groups SET NAME = ?, Description = ? WHERE Id = ?";
                  $stmt = $this->conn->prepare($query);
                  $stmt->bind_param('ssi',$this->name, $this->description, $this->id);
                  $stmt->execute();
                }
                $query = "DELETE group_user WHERE Id = ?";
                $stmt = $this->conn->prepare($query);
                $stmt->bind_param('i', $this->id);
                $stmt->execute();

                foreach ($members as $member) {
                  $query = "INSERT INTO group_user (Id_group, Id_user)
                          SELECT ? as id_group, id as id_user
                          FROM users
                          WHERE Email = ?";
                  $stmt = $this->conn->prepare($query);
                  $stmt->bind_param('is',$this->id, $member);
                  $stmt->execute();
                }
          }
          else
          {
              $emparray["Error"] = "The name of the Group already exist for this user!";
          }
      }
      catch (Exception $e)
      {
            $emparray["Error"] = "$e->getMessage()";
      }

      $result =  json_encode($emparray);
      echo $result;
    }
}
?>
