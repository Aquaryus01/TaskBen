<?php
	include("Connection.php");
	include("Class/JWT.php");
	include("Class/Bcrypt.php");
	$api_key = isset($_SERVER['HTTP_AUTHENTIFICATION_JWT']) ? $_SERVER['HTTP_AUTHENTIFICATION_JWT'] : NULL;



	if ( $_SERVER['REQUEST_METHOD'] === 'POST')
	{
			$postData = file_get_contents('php://input');
			$data = json_decode($postData, true);
			$method = $data['action'];
			switch($method)
			{
					case "login":
						include_once("Class/Users.php");
						$user = new Users();
						$user->login($data);
						break;

					case "register":
						include_once("Class/Users.php");
						$user = new Users();
						$user->register($data);
						break;

					case "add_task":
						if(JWT::verify($api_key))
						{
							include_once("Class/tasks.php");
							$task = new Tasks();
							$task->add($data);
							break;
						}

					case "remove_task":
						if(JWT::verify($api_key))
						{
							include_once("Class/tasks.php");
							$task = new Tasks();
							$task->remove($data);
							break;
						}

					case "get_tasks":
						if(JWT::verify($api_key))
						{
							include_once("Class/tasks.php");
							$task = new Tasks();
							$task->get_tasks($data);
							break;
						}

					case "update_task":
						if(JWT::verify($api_key))
						{
								include_once("Class/tasks.php");
								$task = new Tasks();
								$task->update($data);
								break;
						}
			}
	}
?>
