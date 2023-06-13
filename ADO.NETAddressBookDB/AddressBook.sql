create database AddressBookDB;
use AddressBookDB;

create table AddressBook
(
	Id int primary key identity(1,1),
	FirstName varchar(50) not null,
	LastName varchar(50),
	Address varchar(100),
	City varchar(50),
	State varchar(100),
	Zip varchar(10),
	PhoneNumber varchar(20),
	Email varchar(50)
)

select * from AddressBook