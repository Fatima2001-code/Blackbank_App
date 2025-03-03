create TRIGGER AFTER_InsertNewCustm
ON Customer 
AFTER INSERT, UPDATE
AS
SELECT * FROM Customer
WHERE Customer_id>=1;