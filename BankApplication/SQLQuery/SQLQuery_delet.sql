create proc delet
@Customer_name varchar(50),
@AccId int
as 
begin
delete from Account where @AccId=Acc_id
end
