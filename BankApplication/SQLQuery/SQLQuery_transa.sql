create proc insetIntoTransam
@accountSender int,
@AccountReciver int,
@HowMuch int,
@dateOfTransaction date,
@employeeID int
as
begin
declare @id int;
insert into [Transaction] values(@accountSender,@AccountReciver,@HowMuch,@dateOfTransaction,@employeeID)
set @id=scope_identity();
UPDATE Account SET Acc_Balance=Acc_Balance+@HowMuch WHERE Acc_id=@AccountReciver 
UPDATE Account SET Acc_Balance=Acc_Balance-@HowMuch WHERE Acc_id=@AccountSender
end

BEGIN TRAN

BEGIN TRY

   EXEC insetIntoTransam

   COMMIT TRAN

END TRY
BEGIN CATCH
  ROLLBACK TRAN

END CATCH