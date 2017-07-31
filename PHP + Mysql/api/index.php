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

						case "add_task_group":
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

					case "update_user":
						if(JWT::verify($api_key))
						{
							include_once("Class/Users.php");
							$data["Id"] = JWT::id($api_key);
							$user = new Users();
							$user->update($data);
							break;
						}

					case "update_password":
						if(JWT::verify($api_key))
						{
							include_once("Class/Users.php");
							$data["Id"] = JWT::id($api_key);
							$user = new Users();
							$user->update_password($data);
							break;
						}

					case "get_tasks_words":
						if(JWT::verify($api_key))
						{
							include_once("Class/tasks.php");
							$data["idUser"] = JWT::id($api_key);
							$task = new Tasks();
							$task->get_tasks_words($data);
						}
						break;

					case "get_tasks_repeat":
						if(JWT::verify($api_key))
						{
							include_once("Class/tasks.php");
							$data["idUser"] = JWT::id($api_key);
							$task = new Tasks();
							$task->get_tasks_repeat($data);
						}
						break;

					case "get_groups":
							if(JWT::verify($api_key))
							{
								include_once("Class/Groups.php");
								$data["idUser"] = JWT::id($api_key);
								$group = new Groups();
								$group->get_groups($data);
							}
							break;
					case "get_group_members":
							if(JWT::verify($api_key))
							{
								include_once("Class/Groups.php");
								$group = new Groups();
								$group->get_members($data);
							}
							break;

					case "remove_group":
							if(JWT::verify($api_key))
							{
								include_once("Class/Groups.php");
								$group = new Groups();
								$group->remove($data);
							}
							break;

					case "get_group_tasks":
							if(JWT::verify($api_key))
							{
								include_once("Class/tasks.php");
								$data["idUser"] = JWT::id($api_key);
								$task = new Tasks();
								$task->get_group_tasks($data);
							}
							break;

					case "member_existence":
						if(JWT::verify($api_key))
						{
							include_once("Class/Users.php");
							$user = new Users();
							$user->member_existence($data);
						}
						break;

					case "save_group":
						if(JWT::verify($api_key))
						{
							include_once("Class/Groups.php");
							$data["idUser"] = JWT::id($api_key);
							$group = new Groups();
							$group->save($data);
						}
						break;
			}
	}
?>
