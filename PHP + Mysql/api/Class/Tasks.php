<?php
class Tasks {
    private $id;
    private $idUser;
    private $idGroup;
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
        if(isset($data['idGroup']) && $data['idGroup']>0)
        {
          $this->idUser = 0;
          $this->idGroup = $data['idGroup'];
        }
        else
        {

          $this->idUser = $data['idUser'];
          $this->idGroup = 0;
        }

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
          $sql = "INSERT INTO tasks(Id_user,Id_group,date,dateHours,dateMinutes,reminderHours,reminderMinutes,schedule,description,checked,title)
           VALUES ('$this->idUser', '$this->idGroup','$this->date','$this->dateHours','$this->dateMinutes','$this->reminderHours','$this->reminderMinutes','$this->repeat','$this->description', $this->checked, '$this->title')";
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


        try{
          $sql = "DELETE FROM tasks WHERE Id = '$this->id'";
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

    function get_group_tasks($data)
    {
      $this->idUser = $data['idUser'];
      $this->idGroup = $data['idGroup'];
      try{
        //$query = "SELECT * FROM tasks WHERE Id_user = '$this->idUser'";
        $query = "SELECT t.*, CONCAT(u.FirstName, ' ', u.LastName)  AS UserName, g.Name as GroupName
                  FROM tasks t
                      LEFT JOIN group_user gu
                        ON gu.Id_group = t.Id_group
                      LEFT JOIN groups g
                        ON g.id = t.Id_group
                      left join users u
                        ON u.Id = g.Id_user
                  WHERE gu.id_user = ?
                    AND t.Id_group = ?";

        $stmt = $this->conn->prepare($query);
        $stmt->bind_param('ii',$this->idUser, $this->idGroup);
        $stmt->execute();
        $result = $stmt->get_result();
      }catch (Exception $e) {
          echo 'Caught exception: ',  $e->getMessage(), "\n";
      }

      try{

          while($row = mysqli_fetch_assoc($result))
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

    function get_tasks($data)
    {
        $this->idUser = $data['idUser'];
        try{
          //$query = "SELECT * FROM tasks WHERE Id_user = '$this->idUser'";
          $query = "SELECT t.*, CONCAT(u.FirstName, ' ', u.LastName)  AS UserName, g.Name as GroupName
                    FROM tasks t
                    	left join `group_user` gu
                        	ON gu.id_group = t.Id_group
                        LEFT JOIN groups g
                        	ON g.id = gu.Id_group
                        left join users u
                        	ON u.Id = g.Id_user
                    WHERE t.id_user = ?
                    	OR gu.id_user = ?";
          $stmt = $this->conn->prepare($query);
          $stmt->bind_param('ii',$this->idUser, $this->idUser);
          $stmt->execute();
          $result = $stmt->get_result();
        }catch (Exception $e) {
            echo 'Caught exception: ',  $e->getMessage(), "\n";
        }

        try{

            while($row = mysqli_fetch_assoc($result))
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

    function get_tasks_words($data)
    {
        $this->idUser = $data['idUser'];
        $words = "%".$data['words']."%";
        try{
          $query = "SELECT * FROM tasks WHERE (title LIKE ? OR description LIKE ?) AND Id_user = ?";
          $stmt = $this->conn->prepare($query);
          $stmt->bind_param('ssi',$words,$words,$this->idUser);
          $stmt->execute();
          $result = $stmt->get_result();

        }catch (Exception $e) {
            echo 'Caught exception: ',  $e->getMessage(), "\n";
        }
        try{
            //echo "da";
            //print_r($result);
            while($row = mysqli_fetch_assoc($result))
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

    function get_tasks_repeat($data)
    {

        $this->idUser = $data['idUser'];
        try{
          $query = "SELECT t.*, CONCAT(u.FirstName, ' ', u.LastName)  AS UserName, g.Name as GroupName
                    FROM tasks t
                    	left join `group_user` gu
                        	ON gu.id_group = t.Id_group
                        LEFT JOIN groups g
                        	ON g.id = gu.Id_group
                        left join users u
                        	ON u.Id = g.Id_user
                    WHERE t.id_user = '$this->idUser'
                    	OR gu.id_user = '$this->idUser'";

          $sql = $this->conn->query($query);


        }catch (Exception $e) {
            echo 'Caught exception: ',  $e->getMessage(), "\n";
        }

        try{
            while($row = mysqli_fetch_assoc($sql))
            {

                date_default_timezone_set('Europe/Bucharest');
                if($row["schedule"]=="Once" && date("n/j/Y")==$row["date"])
                  $emparray[] = $row;
                else if($row["schedule"]=="Daily")
                    $emparray[] = $row;
                else if($row["schedule"]=="Working day")
                {
                  $date = $row["date"];
                  if((date('N', strtotime($date)) <= 5))
                  $emparray[] = $row;
                }
                else if($row["schedule"]=="Weekly")
                {
                    $datetime1 = date_create(date("n/j/Y"));
                    $datetime2 =  date_create(date($row["date"]));

                    if($datetime1>$datetime2)
                    {

                      $interval = date_diff($datetime1, $datetime2);

                      if($interval->days%7==0)
                        $emparray[] = $row;
                    }
                }
                if($row["schedule"]=="Monthly")
                {
                  $datetime1 = date_create(date("n/j/Y"));
                  $datetime2 =  date_create(date($row["date"]));

                  if($datetime1>$datetime2)
                  {
                    $interval = date_diff($datetime1, $datetime2);
                    if($interval->d==0)
                      $emparray[] = $row;
                  }
                }


            }
        }catch (Exception $e) {
              $emparray["Error"] = $e->getMessage();
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
