Create proc daaily
@Acc_ID int,
@date datetime
as
begin
select Tra_balance, Tra_date from [Transaction] where YEAR(Tra_date) =YEAR(@date) and MONTH(Tra_date)=MONTH(@date) and DAY(Tra_date)=DAY(@date) and
(Acc_id_receiver=@Acc_ID or Acc_id_sender=@Acc_ID)
end
