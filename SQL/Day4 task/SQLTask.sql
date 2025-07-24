-- Company Tasks
use MyCompany

select dnum, dname
from Departments 
where mgrssn = 968574

select pnumber, pname, plocation
from Project
where dnum = 10

-- ITI Tasks
use ITI

select distinct ins_name
from Instructor

select Instructor.ins_name, Department.Dept_Name
from Instructor
left join Department on
Instructor.Dept_Id = Department.Dept_Id
order by Instructor.Ins_Name

select Student.St_Fname+' '+Student.St_Lname as [Full Name],
STRING_AGG(Course.Crs_Name, ', ') as [Course Name]
from Student
join Stud_Course on 
Student.St_Id = Stud_Course.St_Id
join Course on Stud_Course.Crs_Id = Course.Crs_Id
where Stud_Course.Grade is not null
group by Student.St_Fname+' '+Student.St_Lname

select Topic.Top_Name, count(Course.Crs_Id) as [Number of Courses]
from Topic
left join Course on
Topic.Top_Id = Course.Top_Id
group by Topic.Top_Name

select S.St_Fname as [Student First Name], Sup.*
from Student S
LEFT JOIN Student Sup on
S.St_super = Sup.St_Id;