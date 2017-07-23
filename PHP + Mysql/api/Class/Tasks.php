<?php
class Tasks {
    private $id;
    private $idUser;
    private $date;
    private $dateHours;
    private $dateMinutes;
    private $reminderHours;
    private $reminderMinutes;
    private $repeat;
    private $description;
    private $title;
    private $conn;
    private $checked;

    function __construct() {
        $this->conn = new Connection();
    }

    function update($data)
    {
      $api = $data['api'];
      $this->idUser = $data['idUser'];
      $this->id = $data['id'];
      $this->date = $data['date'];
      $this->dateHours = $data['dateHours'];
      $this->dateMinutes = $data['dateMinutes'];
      $this->reminderHours = $data['reminderHours'];
      $this->reminderMinutes = $data['reminderMinutes'];
      $this->repeat = $data['repeat'];
      $this->description = $data['description'];
      $this->title = $data['title'];
      $this->checked = (int)$data['checked'];
      try{
        $sql = "UPDATE tasks SET checked = $this->checked, title = '$this->title', Id_user = '$this->idUser' ,date = '$this->date' ,dateHours = '$this->dateHours' ,dateMinutes = '$this->dateMinutes' ,reminderHours = '$this->reminderHours' ,reminderMinutes =  '$this->reminderMinutes' ,schedule = '$this->repeat' ,description = '$this->description' WHERE Id = $this->id AND Id_user = $this->idUser";
        $this->conn->query($sql);
        $this->id = $this->conn->insert_id();
        $emparray["Error"] = "";
      }catch (Exception $e) {
          $emparray["Error"] = "$e->getMessage()";
        }

        if($emparray["Error"] == "")
          echo $this->id;
        else
          echo json_encode($emparray, JSON_PRETTY_PRINT);
    }

    function add($data)
    {
        $this->idUser = $data['idUser'];
        $this->date = $data['date'];
        $this->dateHours = $data['dateHours'];
        $this->dateMinutes = $data['dateMinutes'];
        $this->reminderHours = $data['reminderHours'];
        $this->reminderMinutes = $data['reminderMinutes'];
        $this->repeat = $data['repeat'];
        $this->description = $data['description'];
        $this->title = $data['title'];
        $this->checked = (int)$data['checked'];
        try{
          $sql = "INSERT INTO tasks(Id_user,date,dateHours,dateMinutes,reminderHours,reminderMinutes,schedule,description,checked,title) VALUES ('$this->idUser','$this->date','$this->dateHours','$this->dateMinutes','$this->reminderHours','$this->reminderMinutes','$this->repeat','$this->description', $this->checked, '$this->title')";
          $this->conn->query($sql);
          $this->id = $this->conn->insert_id();
          $emparray["Error"] = "";
        }catch (Exception $e) {
            $emparray["Error"] = "$e->getMessage()";
          }

          if($emparray["Error"] == "")
            echo "$this->id";
          else
            echo json_encode($emparray, JSON_PRETTY_PRINT);
    }

    function remove($data)
    {

        $this->idUser = $data['idUser'];
        $this->id = $data['id'];

        echo $this->idUser;
        echo $this->id;

        try{
          $sql = "DELETE FROM tasks WHERE Id = '$this->id' AND Id_user = '$this->idUser'";
          $this->conn->query($sql);
          $emparray["Error"] = "";
        }catch (Exception $e) {
            $emparray["Error"] = "$e->getMessage()";
          }


          if($emparray["Error"] == "")
            echo "";
          else
            echo json_encode($emparray, JSON_PRETTY_PRINT);
    }

    function get_tasks($data)
    {
        $this->idUser = $data['idUser'];
        try{
          $query = "SELECT * FROM tasks WHERE Id_user = '$this->idUser'";
          $sql = $this->conn->query($query);
        }catch (Exception $e) {
            echo 'Caught exception: ',  $e->getMessage(), "\n";
        }

        try{
            while($row = mysqli_fetch_assoc($sql))
            {
                $emparray[] = $row;
            }
        }catch (Exception $e) {
              $emparray["Error"] = "$e->getMessage()";
        }

        if(isset($emparray)){
          $result =  json_encode($emparray);
          echo $result;
        }else{
          echo "";
        }

    }
  }
?>
