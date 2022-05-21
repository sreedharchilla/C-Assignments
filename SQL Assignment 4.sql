---Assignment 4

/* 1.Write a T-SQL Program to generate complete payslip of a given employee with respect to the following condition
a)	HRA  as 10% Of sal
b)	DA as  20% of sal
c)	PF as 8% of sal
d)	IT as 5% of sal
e)	Deductions as sum of PF and IT
f)	Gross Salary as sum of SAL,HRA,DA and Deductions
g)	Net salary as  Gross salary- Deduction */

begin
declare @salary float = 32230;
declare @Sal float,@HRA float,@DA float,@PF float,@IT float
declare @Deductions float, @GrossSalary float, @NetSalary float

---a)HRA  as 10% Of sal
set @HRA = ((@salary)*10/100)
print 'HRA Salary is : '+''+cast(@HRA as varchar(12))


---b)DA as  20% of sal
set @DA =((@salary)*20/100)
print 'DA Salary is : '+''+cast(@DA as varchar(12))


---c)PF as 8% of sal
set @PF =((@salary)*8/100)
print 'PF Salary is : '+''+cast(@PF as varchar(12))


---d)IT as 5% of sal
set @IT =((@salary)*5/100)
print 'IT Salary is : '+''+cast(@IT as varchar(12))


---e)Deductions as sum of PF and IT
set @Deductions = @PF+@IT
print 'Deductions is as: '+''+cast(@Deductions as varchar(12))


---f)Gross Salary as sum of SAL,HRA,DA and Deductions
set @Sal = @salary -(@HRA+@DA+@Deductions)
set @GrossSalary = @SAL+(@HRA+@DA+@Deductions)
print 'Gross Salary is : '+''+cast(@GrossSalary as varchar(12))


---g)Net salary as  Gross salary- Deduction
set @NetSalary = @GrossSalary-@Deductions
print 'Net Salary is : '+''+cast(@NetSalary as varchar(12))
end

---2.Write a T-SQL Program to find the factorial of a given number.

begin
	declare @Num int
	declare @fact int
	set @Num=5
	set @fact=1
while @Num>0
	begin
		set @fact=@fact*@Num
		set @Num=@Num-1
	end
	print 'Factorial of a given number is : '+cast(@fact as varchar)
	
end

---3.Create a stored procedure to generate multiplication tables up to a given number.

create or alter proc Multiplication_Table(@Number1 int)
as
begin
 declare @Number2 int = 1, @result int
  
  while(@Number2<=10)
  begin
    set @result = @Number1 * @Number2
	print @result

  set @Number2 = @Number2+1
  end
end

exec Multiplication_Table @Number1=4