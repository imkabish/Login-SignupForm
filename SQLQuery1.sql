use LOGIN;

create table userdetails(
	name varchar(50) not null,
	surname varchar(50) not null,
	contact varchar(50) unique,
	email varchar(50) unique,
	username varchar(50) primary key,
	password varchar(50) not null
);
192.168.1.69
create table login(
	username varchar(50),
	password varchar(50)
);

drop table userdetails;
drop table login;
drop trigger storeintologin;

create trigger storeintologin
on userdetails
after insert
as
begin
	insert into login(username, password)
	select inserted.username, inserted.password
	from inserted;
end;

insert into userdetails values ('pragyan', 'shrestha', '9809118469', 'pragyanstha@gmail.com', 'qwerty', 'ytrewq');

select * from userdetails;
select * from login;

delete from userdetails