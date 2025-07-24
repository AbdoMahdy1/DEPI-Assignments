use MyCompany

select * from Employee

select fname, lname, salary, dno
from Employee

select pname, plocation, dnum
from Project

select fname+' '+lname as [Full Name],
(salary * 12 * 0.10) as [Annual Comm]
from Employee

select ssn, fname+' '+lname as [Full Name]
from Employee
where salary > 1000

select ssn, fname+' '+lname as [Full Name]
from Employee
where salary*12 > 10000

select fname+' '+lname as [Full Name], salary
from Employee
where sex = 'F'

select dnum, dname
from Departments 
where mgrssn = 968574

select pnumber, pname, plocation
from Project
where dnum = 10