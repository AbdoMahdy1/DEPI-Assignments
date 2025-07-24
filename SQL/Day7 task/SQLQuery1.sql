use ITI

-- Q.1
create or alter proc SP_GetStuNumPerDept @deptid int
as
begin
	select Dept_Id, count(St_Id) as NumberOfStudents
	from Student
	where Dept_Id = @deptid
	group by Dept_Id
end

SP_GetStuNumPerDept 20

------------------------------

use Mycompany

-- Q.2

create or alter proc SP_CheckNumOfEmpInProj @pid int
as
begin
	declare @count int, @message varchar(max)
	select @count = count(ESSn)
	from Works_for
	where Pno = @pid

	if(@count >= 3)
	  begin
		set @message = 'The number of employees in the project is 3 or more'
		select @message as Message
	  end

	else
	  begin
		set @message = 'The following employees work for the project'
		select @message as Message
		select e.Fname, e.Lname
		from Employee e join Works_for w on
		e.SSN = w.ESSn
		where w.Pno = @pid
	  end
end

SP_CheckNumOfEmpInProj 100

select *
from Project

create or alter proc ReplaceEmpInProj @oldId int, @newId int, @prID int
as
begin
	update Works_for
	set ESSn = @newId
	where Pno = @prID and ESSn = @oldId
end

ReplaceEmpInProj 223344, 112233, 200

select * from [dbo].[Works_for]