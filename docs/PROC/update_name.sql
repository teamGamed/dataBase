create or replace PROCEDURE update_name
(usernameP VARCHAR2,nameP VARCHAR2)
as
begin
  UPDATE user_tb set name = nameP where username = usernameP ;
end;