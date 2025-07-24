use ITI

-- Q.1
create function GitMonthFromDate(@date date)
returns varchar(max)
as
begin
	return datename(month, @date)
end

select dbo.GitMonthFromDate('2025-07-15') as Month

-- Q.2
create or alter function GetNumbersBetween(@stnum int, @endnum int)
	returns @t table (result int)
	as
		begin
			declare @diff int  = @endnum - @stnum
			while @diff > 1
			begin
				set @stnum += 1
				insert into @t
				values(@stnum)
				set @diff -=1
			end
			return
		end

select * from GetNumbersBetween(11, 15)

-- Q.3
create function GitStData(@stid int)
returns table
as
	return
	(
		select s.St_Fname+' '+s.St_Lname as [Full Name], d.Dept_Name
		from Student s
		join Department d on s.Dept_Id=d.Dept_Id
		where s.St_Id = @stid
	)

select * from GitStData(21)

-- Q.4
create function ChickNameOfStudent(@stid int)
returns varchar(max)
as 
begin
	declare @fname varchar(max), @lname varchar(max), @message varchar(max)
	select @fname=St_Fname, @lname=St_Lname
	from Student
	where St_Id = @stid

	if @fname is null and @lname is null 
		set @message = 'First name & last name are null'
	else if @fname is null
		set @message = 'First name is null'
	else if @lname is null
		set @message = 'Last name is null'
	else
		set @message = 'First name & last name are not null'
	return @message
end

select dbo.ChickNameOfStudent(21)

-- Q.5
create or alter function GetManagerData(@hireDate date)
returns table 
	as
	return
	(
		select i.Ins_Name as ManagerName, d.Dept_Name, d.Manager_hiredate
		from Instructor i, Department d
		where i.Ins_Id = d.Dept_Manager and d.Manager_hiredate = @hireDate
	)

select * from GetManagerData('2000-01-01')

/*                  null ﬁÌ„ Â„ Dept_Manager ﬂ· «· 
select i.Ins_Name as ManagerName, d.Dept_Name, d.Manager_hiredate
from Instructor i, Department d
where i.Ins_Id = d.Dept_Manager

select Manager_hiredate from Department
select * from Instructor
-- 1,10  8,30  9,50  11,70  15,40  13,20
update Department
set Dept_Manager = 13
Where Dept_Id = 20
*/

-- Q.6
create function GetStNameByString(@string varchar(20))
	returns @t table 
	(
		stuName varchar(max)
	)

	as 
		begin
			if @string = 'first name'
			insert into @t
			select St_Fname
			from Student
			else if @string = 'last name'
			insert into @t
			select St_Lname
			from Student
			else if @string = 'full name'
			insert into @t
			select St_Fname+' '+St_Lname
			from Student
			return
		end

select * from GetStNameByString('first name')

-- Using MyCompany

use MyCompany

create function GetProjectEmplyees(@pnum int)
returns table
as
	return(
		select e.Fname+' '+e.Lname as [Full Name], p.Pnumber
		from Employee e, Project p
		where e.Dno = p.Dnum and p.Pnumber = @pnum
			)

select * from GetProjectEmplyees(100)