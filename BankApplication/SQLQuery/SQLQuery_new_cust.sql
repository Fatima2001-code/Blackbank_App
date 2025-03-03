create proc InsertNewCustm
@name varchar(50),
@phone varchar(50),
@address varchar(50),
@email nvarchar(50),
@Deposite_date date,
@Acc_Type varchar(50),
@Acc_Balance int
as
begin
declare @id int;
insert into Customer values 
(@name,@phone,@address,@email)
set @id=scope_identity();
insert into Account values(@Acc_Type,@Acc_Balance,@id,@Deposite_date)
end
