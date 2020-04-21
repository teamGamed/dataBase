create or replace
PROCEDURE delete_appointment
(Aid NUMBER)
as
begin
  delete from appointment where id = aid ;
end;