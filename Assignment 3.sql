-----Assignment 3

create table Department
(
Deptno int primary key ,
Dname varchar (20) Not null ,
loc varchar(15) Not null
)

insert into Department
values(10,'ACCOUNTING','NEW YORK'),
(20,'RESEARCH','DALLAS'),
(30,'SALES','CHICAGO'),
(40,'OPERATIONS','BOSTON')

create table employee
(Empno int primary key,
Ename varchar(20)Not null,
Job varchar (20)Not null,
MGR_Id int ,
HireDate varchar(10),
Sal float,
Comm float,
Deptno int
)
insert into employee
values(7369,'SMITH','CLERK',7902,'17-DEC-80',800,NULL,20),
(7499,'ALLEN' ,'SALESMAN',7698,'20-FEB-81',1600 ,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,NULL,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,NULL,30),
(7782,'CLARK' ,'MANAGER',7839,'09-JUN-81',2450,NULL,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,NULL,20),
(7839,'KING' ,'PRESIDENT',NULL ,'17-NOV-81' ,5000,NULL,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,NULL,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950,NULL,30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,NULL,20),
(7934,'MILLER','CLERK',7782 ,'23-JAN-82',1300,NULL,10)

select * from employee
select * from Department


---1. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
select Ename, sal from employee where sal not between 1500 and 2850

---2. Display the name and job of all employees who do not have a MANAGER. 
select Ename, job from employee where MGR_Id is null

---3. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select Ename,job,sal from employee where job in('MANAGER','ANALYST') and sal not in(1000,3000,5000)

---4. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 
select Ename,sal,comm from employee where comm > sal+sal*.10

---5. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
 select Ename from employee where Ename like '%LL%' and deptno in (30) or MGR_Id =7782

---6. Display the names of employees with experience of over 10 years and under 20 yrs.Count the total number of employees. 
 update employee set hiredate='28-SEP-10' where Empno in(7654,7900)

  SELECT COUNT(hiredate) AS NO_OF_EMPLOYEES,Ename
  FROM employee
  WHERE CONVERT(varchar(3),DATEDIFF(YEAR, HIREDATE, GETDATE()))>10
  AND CONVERT(varchar(3),DATEDIFF(YEAR, HIREDATE, GETDATE()))<20
  GROUP BY Ename


---7. Retrieve the names of departments in ascending order and their employees in descending order.
 select Dname,Ename from Department join employee on Department.DeptNo = employee.Deptno
 order by Dname asc , Ename desc

---8. Find out experience of MILLER. 
select convert(varchar(5),datediff(year,hiredate,getdate())) as'Experience'
from employee where Ename='MILLER'

---9. How many different departments are there in the employee table. 
 select Dname,count(*) as 'no of departments' from employee join Department on
 Department.Deptno= employee.deptno
 group by Dname

---10. Find out which employee either work in SALES or RESEARCH department. 
 select Ename, Dname from employee join Department on employee.Deptno=Department.DeptNo 
 where DName in('SALES','RESEARCH')

---11. Print the name and average salary of each department. 
 select Dname, avg(sal) as AverageSalary from employee join Department on employee.Deptno=Department.DeptNo
 group by DName

---12. Select the minimum and maximum salary from employee table. 
 select min(sal) as minimumsalary, max(sal) as maximumsalary from employee

---13. Select the minimum and maximum salaries from each department in employee table.
 select Dname,min(sal) as minimum_salary,max(sal) as maximum_salary from employee join Department
 on employee.Deptno=Department.DeptNo 
 group by Dname 

---14. Select the details of employees whose salary is below 1000 and job is CLERK. 
 select * from employee where sal<1000 and job = 'CLERK'
