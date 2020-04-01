create table Doctor (
    ID number not null constraint doctor_tb_pk primary key,
    Department varchar2(20) not null,
    shift varchar2(20) not null,
    Degree varchar2(20) not null
);
create table user_tb (
    ID number not null constraint user_tb_pk primary key,
    User_name varchar2(20) not null,
    Password varchar2(20) not null,
    Name varchar2(20) not null,
    Email varchar2(4000) not null,
    Phone varchar2(20),
    Address varchar2(4000),
    Photo_URL varchar2(4000),
    Type varchar2(20),
    Sex varchar2(1) not null
);
/
 
alter table user_tb add constraint user_tb_user_name_uq unique (User_name);
alter table user_tb add constraint user_tb_email_uq unique (Email);
alter table user_tb add constraint user_tb_phone_uq unique (Phone);
ALTER TABLE Doctor 
ADD FOREIGN KEY(ID)  
REFERENCES  user_tb (ID);
create table Patient (
    ID number not null constraint patient_tb_pk primary key,
    Weight number,
    Height number,
    Birthday date not null,
    Blood_type varchar2(2) not null,
    University varchar2(10)
);
/
ALTER TABLE Patient
ADD FOREIGN KEY(ID)  
REFERENCES  user_tb (ID);
create table Appointment (
    ID number not null constraint appointment_pk primary key,
    Doctor_id number not null,
    Patient_id number not null,
    Appointment_date date,
    Room number not null
);
//
ALTER TABLE Appointment 
ADD FOREIGN KEY(Doctor_id)  
REFERENCES  Doctor (ID);
 
ALTER TABLE Appointment 
ADD FOREIGN KEY(Patient_id)  
REFERENCES  Patient(ID);
create table Medicine (
    Med_id number not null constraint medicine_pk primary key,
    Name varchar2(20) not null,
    Description varchar2(4000)
);
/
create table Prescription (
    Appointment_id number not null,
    Med_id number not null,
    dosage varchar2(4000) not null,
    constraint prescription_pk primary key (Appointment_id, Med_id)
);
ALTER TABLE Prescription 
ADD FOREIGN KEY(Appointment_id )  
REFERENCES  Appointment (ID);
 
ALTER TABLE Prescription 
ADD FOREIGN KEY(Med_id )  
REFERENCES  Medicine  (Med_id );
 
create table Medical_Exam (
    ID number not null constraint medical_exam_pk primary key,
    Name varchar2(20) not null,
    Min_val number ,
    Max_val number
);
/
create table Patient_Exam (
    ID number not null constraint patient_exam_pk primary key,
    Exam_id number not null,
    patient_id number not null,
    value varchar2(20) not null,
    Note varchar2(4000)
);
/
ALTER TABLE Patient_Exam 
ADD FOREIGN KEY(Exam_id )  
REFERENCES  Medical_Exam   (ID  );
ALTER TABLE Patient_Exam 
ADD FOREIGN KEY(patient_id )  
REFERENCES  Patient(ID);
create table Disease (
    ID number not null constraint disease_pk primary key,
    Name varchar2(20) not null,
    chronic varchar2(4000),
    Description varchar2(4000)
);
/
create table Patient_Disease (
    Patient_id number not null,
    Disease_id number not null,
    state varchar2(20),
    Diagnosis_data date,
    constraint patient_disease_pk primary key (Patient_id, Disease_id)
);
ALTER TABLE Patient_Disease 
ADD FOREIGN KEY(Patient_id )  
REFERENCES  Patient(ID);
 
ALTER TABLE Patient_Disease 
ADD FOREIGN KEY(Disease_id )  
REFERENCES  Disease (ID);