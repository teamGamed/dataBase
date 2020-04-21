create or replace PROCEDURE book_appointment
(Aid NUMBER , doctorName VARCHAR2 , patientName VARCHAR2 , appDate VARCHAR2 , room VARCHAR2)
as
begin

insert into appointment (id , doctor_username , patient_username , appointment_date , room)
        values(aid , doctorname , patientname , appdate , room);

end;
