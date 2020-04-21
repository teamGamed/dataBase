create or replace PROCEDURE get_user_wh
(paName VARCHAR2 , hight out NUMBER)
as
begin
SELECT  height into hight from patient ; 
end;