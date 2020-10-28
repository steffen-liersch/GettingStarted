<?php /*--------------------------------------------------------------------*\
::
::  Copyright © 2020 Steffen Liersch
::  https://www.steffen-liersch.de/
::
\*--------------------------------------------------------------------------*/

(function()
{
  for($i=0; ; $i++)
  {
    $conn=@new mysqli(
      getenv('WP_DB_HOST'),
      getenv('WP_DB_USER'),
      getenv('WP_DB_PASSWORD'),
      null,
      getenv('WP_DB_PORT'));

    if(!$conn->connect_errno || $i>30)
      break;

    // Wait a little bit to make sure the database server is ready.
    echo "Waiting for database server...\n";
    sleep(1);
  }

  if($conn->connect_errno)
  {
    echo 'Failed to connect with database server: '.$conn->connect_error."\n";
    exit(1);
  }

  try
  {
    $sql='CREATE DATABASE IF NOT EXISTS `'.getenv('WP_DB_NAME').'`';
    if($conn->query($sql)!==true)
    {
      echo "Database command execution failed\n";
      exit(2);
    }

    echo "Database initialization succeeded\n";
    exit(0);
  }
  finally
  {
    $conn->close();
  }
})();
