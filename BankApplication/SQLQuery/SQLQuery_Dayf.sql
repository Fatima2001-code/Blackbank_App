create proc Dayf
@Acc_ID int,
@date datetime
as
begin
select * from [Transaction] where Tra_date =@date and Acc_id_receiver=@Acc_ID or Acc_id_sender=@Acc_ID 

end
EXEC Dayf    
     @Acc_ID = '6'   
    , @date = '2023-03-06';
GO