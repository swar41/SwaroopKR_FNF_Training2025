use SQL_Assignments
go
create table employee_manager_table(
    emp_id int primary key identity(1,1) ,
    name varchar(40) not null,
    salary bigint not null,
    manager_id INT not null
)
go
insert into employee_manager_table values('Rohit',2300,3)
insert into employee_manager_table values('Sangeetha',2300,1)
insert into employee_manager_table values('Sanjay',2300,4)
insert into employee_manager_table values('Arun',2300,3)
insert into employee_manager_table values('Zaheer',2300,3)
go

select
e.name as employee_name, m.name as manager_name
from employee_manager_table e
left join 
employee_manager_table m on e.manager_id = m.emp_id
order by 
e.name;
