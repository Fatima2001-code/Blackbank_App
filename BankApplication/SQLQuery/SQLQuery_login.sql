create proc LoggIn
@username varchar(50),
@password varchar(50)
as
begin
select Employee_id,Employee_jobName from Employee
where Employee_name=@username and Employee_password=@password
end

exec LoggIn
@username='admin',@password='admin'
