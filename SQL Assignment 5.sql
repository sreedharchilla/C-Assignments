create database SpecialAssig5
use SpecialAssig5

---Creating Table Clients
create table Clients
(Client_ID int Primary Key,Cname nVARCHAR(40) not null,
 Addres nVARCHAR(30),Email nVARCHAR(30) Unique,phoneNo Bigint,
 Business nVARCHAR(20) not null)

---inserting  into clients table values

 insert into Clients
 values(1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing'),
(1002,'Trackon Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant'),
(1003,'MoneySaver Distributors','Kolkata','save@moneysaver.com',7799886655,'Reseller'),
(1004,	'Lawful Corp',	'Chennai',	'justice@lawful.com',	9210342219,	'Professional')
select*from Clients

 
--- Creating table Department
 create table Departments
 (DeptNo int Primary key, Dname VARCHAR(15) not null,Loc VARCHAR(20))

 ---inserting  into departments values in  table
 insert into Departments
 values(10,'Design','Pune'),
 (20,'Development','pune'),
 (30,'Testing','Mumbai'),
 (40,'Document','Mumbai')

 select* from Departments

---Creating  table Employee
 create table Employees
 (EmpNo int primary key,Ename VARCHAR(20) not null,job VARCHAR(15),
  salary Float check(Salary>0),
  DeptNo int Foreign key references Departments(DeptNo))

 ---inserting  into Employees values in table
  
  insert into Employees
Values(7001,'Sandeep','Analyst',25000,10),
(7002,'Rajesh','Designer',30000,10),
(7003,'Madhav','Developer',40000,20),
(7004,'Manoj','Developer',40000,20),
(7005,'Abhay','Designer',35000,10),
(7006,'Uma','Tester',30000,30),
(7007,'Gita','Tech.Writer',30000,40),
(7008,'Priya','Tester',35000,30),
(7009,'Nutan','Developer',45000,20),
(7010,'Smita','Analyst',20000,10),
(7011,'Anand','Project Mgr',65000,10)

select *from Employees

--- Creating  table project

 create table Project
(Project_ID int Primary key,
Descr VARCHAR(30) not null,
Start__Date Date,
Planned_End_Date Date,
Actual_End_Date Date, Check(Actual_End_Date>Planned_End_Date),
Budget Bigint, Check(Budget>0),
Client_Id int Foreign key references Clients(Client_ID))

---inserting into project values in table

insert into Project

Values(401,'Inventory','01-Apr-11','01-Oct-11','31-Oct-11',150000,1001),
(402,'Accounting','01-Aug-11','01-Jan-12',null, 500000,1002),
(403,'Payroll','01-Oct-11','31-Dec-11',null, 75000,1003),
(404,'Contact Mgmt','01-Nov-11','31-Dec-11',null,50000,1004)

 select* from Project

 ---Creating Table  ProjectTasks

 create table ProjectTasks
 (Project_Id int Foreign key references project(project_ID),
  Empno int Foreign key references Employees(EmpNo),
  Start__Date Date, End_Date Date, Task VARCHAR(25) not null,
  Pro_status VARCHAR(15) not null, Primary key(Project_ID,Empno))

  ---inserting  into ProjectTasks values in Table

  insert into ProjectTasks 
 
Values (401,7001,'01-Apr-11','20-Apr-11','System Analysis','Completed'),
 (401,7002,'21-Apr-11','30-May-11','System Design','Completed'),
 (401,7003,'01-Jun-11','15-Jul-11','Coding','Completed'),
 (401,7004,'18-Jul-11','01-Sep-11','Coding',	'Completed'),
 (401,7006,'03-Sep-11','15-Sep-11','Testing','Completed'),
 (401,7009,'18-Sep-11','05-Oct-11','Code Change','Completed'),
 (401,7008,'06-Oct-11','16-Oct-11','Testing','Completed'),
 (401,7007,'06-Oct-11','22-Oct-11','Documentation','Completed'),
 (401,7011,'22-Oct-11','31-Oct-11','Sign off','Completed'),
 (402,7010,'01-Aug-11','20-Aug-11','System Analysis','Completed'),
 (402,7002,'22-Aug-11','30-Sep-11','System Design','Completed'),
 (402,7004,'01-Oct-11',null,	'Coding','In Progress')

  select* from ProjectTasks

