
create database SMS
use SMS

create table tblCourses
(CourseId int primary key,CourseName varchar(20),Courseduration int, Coursefees float)

insert into tblCourses values(108,'Java',60,34500),(109,'J2EE',46,12000),(110,'DOTNET',37,28000);

select * from tblCourses

create table tblStudents
(StudentId int primary key,StudentName varchar(20),studentDOB date)

insert into tblstudents values(10,'raju','05/1/2000'),
(20,'Manoj','06/5/1999'),(26,'Naveen','07/6/1997')

select * from tblStudents

create table tblEnrollDetails
(Courseid int foreign key references tblCourses(CourseId),
 StudentId int foreign key references tblStudents(StudentId),
 EnrollDate date)

 insert into tblEnrollDetails values(111,10,'2021/8/5'),
 (112,20,'2021/10/8'),(113,30,'2021/10/21')


 select * from tblEnrollDetails
