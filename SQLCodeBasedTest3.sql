Create database EmpManagement
use EmpManagement

create table Code_Employee(
Empno int primary key,
Empname varchar(50) not null,
Empsal numeric(10,2) check (Empsal>=25000),
Emptype varchar(1) check(Emptype in('C','P')))

insert into Code_Employee values
(1,'sreedhar',50000,'P'),
(2,'kiran', 32000,'C')



select * from Code_Employee



create or alter procedure AddNewEmployee @Ename varchar(50), @Esal numeric(10,2), @Etype varchar(1)
as
begin
declare @Eid int = (select max(Empno) from Code_Employee)
begin
declare @Empid int = @eid + 1;
insert into Code_Employee values(@Empid, @Ename, @Esal, @Etype)
end
end

