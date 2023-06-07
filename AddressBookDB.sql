--UC1
Create Database AddressBook_Service;
Use AddressBook_Service;

--UC2
Create Table address_book
(
Id int Primary Key identity(1,1),
FirstName varchar(10),
LastName varchar(10),
Address varchar(50),
City varchar(20),
State varchar(20),
ZIP varchar(6),
PhoneNumber varchar(10)
)

--UC3
Insert into address_book(FirstName,LastName,Address,City,State,ZIP,PhoneNumber) 
values('Anil','Kumar','Bengaluru','Bengaluru','Karnataka','560049','6789054321');
Insert into address_book(FirstName,LastName,Address,City,State,ZIP,PhoneNumber) 
values('Soma','Shekar','Bengaluru','Bengaluru','Karnataka','560032','7689054321');
Insert into address_book(FirstName,LastName,Address,City,State,ZIP,PhoneNumber) 
values('Bheem','Kumar','Hubbali','Gadag','Karnataka','560002','8906754321');
Insert into address_book(FirstName,LastName,Address,City,State,ZIP,PhoneNumber) 
values('Hemanth','Kumar','Bengaluru','Bengaluru','Karnataka','560087','9054678321');

Select * from address_book;

--UC4
Update address_book set Address='Agumbe', City='Shivamogga' where FirstName='Hemanth';

--UC5
Delete from address_book where FirstName='Bheem';

--UC6
Select * from address_book where City='Bengaluru' or State='Karnataka';

--UC7
Select Count(*) from address_book group by City;
Select Count(*) from address_book group by State;

--UC8
Select * from address_book where City='Bengaluru' Order by FirstName;

--UC9
Alter Table address_book Add Name varchar(20), Type varchar(30);
Update address_book set Name='Anil', Type='Family' where Id=1;
Update address_book set Name='Somu', Type='Friend' where Id=2;
Update address_book set Name='Hemanth', Type='Friend' where Id=4;

--UC10
Select Count(*) from address_book where Type='Friend' group by Type;

--UC11
Insert into address_book(FirstName,LastName,Address,City,State,ZIP,PhoneNumber,Name,Type)
values('Arjun','Janya','Hebbal','Bengaluru','Karnataka','567896','7896545624','ArjunJanya','Composer');
Insert into address_book(FirstName,LastName,Address,City,State,ZIP,PhoneNumber,Name,Type)
values('Hamsa','Lekha','Bengaluru','Bengaluru','Karnataka','567800','7896562454','HamsaLekha','Composer');

--UC12
Alter Table address_book drop column Type;

Create Table type
(
Id int primary key identity(1,1),
TypeName varchar(30),
PersonID int Foreign Key References address_book(Id)
);

Insert into Type(TypeName,PersonID) values('Freind',1);
Insert into Type(TypeName,PersonID) values('Composer',1);

Select * from Type;

--UC13
Select * From address_book;