<?php

/**
 * @author Steffen Liersch <S.Liersch@gmx.de>
 * @copyright Copyright © 2020 Dipl.-Ing. (BA) Steffen Liersch
 */

(function()
{
  // Wait a little bit to make sure the database server is ready.
  sleep(10);

  $conn=@new mysqli(
    getenv('WP_DB_HOST'),
    getenv('WP_DB_USER'),
    getenv('WP_DB_PASSWORD'),
    null,
    getenv('WP_DB_PORT'));

  if($conn->connect_errno)
  {
    echo 'Failed to connect: '.$conn->connect_error."\n";
    exit(1);
  }

  try
  {
    $sql='CREATE DATABASE IF NOT EXISTS '.getenv('WP_DB_NAME');
    if($conn->query($sql)!==true)
    {
      echo "Command execution failed\n";
      exit(2);
    }

    exit(0);
  }
  finally
  {
    $conn->close();
  }
})();
