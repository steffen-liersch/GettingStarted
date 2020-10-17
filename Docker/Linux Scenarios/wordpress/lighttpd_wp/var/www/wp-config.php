<?php

define('DB_HOST', getenv('WP_DB_HOST').':'.getenv('WP_DB_PORT'));
define('DB_NAME', getenv('WP_DB_NAME'));
define('DB_USER', getenv('WP_DB_USER'));
define('DB_PASSWORD', getenv('WP_DB_PASSWORD'));
define('DB_CHARSET', 'utf8');
define('DB_COLLATE', '');

define('AUTH_KEY',         '...');
define('SECURE_AUTH_KEY',  '...');
define('LOGGED_IN_KEY',    '...');
define('NONCE_KEY',        '...');
define('AUTH_SALT',        '...');
define('SECURE_AUTH_SALT', '...');
define('LOGGED_IN_SALT',   '...');
define('NONCE_SALT',       '...');

$table_prefix='wp_';
define('WP_DEBUG', false);

if(!defined( 'ABSPATH' ))
  define('ABSPATH', dirname( __FILE__ ).'/');

require_once(ABSPATH.'wp-settings.php');
