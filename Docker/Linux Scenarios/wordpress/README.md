# Docker Composition for WordPress

This composition includes the following containers:

- [Lighttpd with PHP support and WordPress](http://127.0.0.1:80)
- [phpMyAdmin for database administration](http://127.0.0.1:81)
- MariaDB

## Database

In the MariaDB container the database location is `/var/lib/mysql`. It is configured as volume to make the data persistent.

The database engine has the following configuration:

```
Port    : 3306
User    : root
Password: root
```

## Copyright

Copyright © 2020 Dipl.-Ing. (BA) Steffen Liersch  
http://www.steffen-liersch.de/
