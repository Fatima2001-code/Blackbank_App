create proc Yearf
@Acc_ID int,
@date datetime
as 
begin 

select * from [Transaction]
WHERE YEAR(Tra_date) = YEAR(@date) and (Acc_id_receiver=@Acc_ID or Acc_id_sender=@Acc_ID)
end
EXEC Yearf    
     @Acc_ID = '105'   
    , @date = '2023-03-06';
GO