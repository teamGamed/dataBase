create or replace
PROCEDURE get_all_disease
(disease out SYS_REFCURSOR)
as
begin
open disease for SELECT * from disease;
end;
