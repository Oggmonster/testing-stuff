# testing-stuff

# create user in postgres
sudo -u postgres psql
postgres=# create database mydb;
postgres=# create user myuser with encrypted password 'mypass';
postgres=# grant all privileges on database mydb to myuser;
postgres=# grant all privileges on table mytable to myuser;

# use dapper with postgres
https://dotnetcoretutorials.com/2020/07/11/dapper-with-mysql-postgresql-on-net-core/