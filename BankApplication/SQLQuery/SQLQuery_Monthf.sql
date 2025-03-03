create proc Monthf
@Acc_ID int,
@date datetime
as 
begin 

select * from [Transaction]
WHERE YEAR(Tra_date) = YEAR(@date) AND MONTH(Tra_date) = MONTH(@date) and (Acc_id_receiver=@Acc_ID or Acc_id_sender=@Acc_ID)
end
EXEC Monthf
     @Acc_ID = '4'   
    , @date = '2023-03-06';
GO