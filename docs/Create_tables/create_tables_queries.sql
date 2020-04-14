create table Doctor (
    username varchar2(20) not null constraint doctor_tb_pk primary key,
    department varchar2(20) not null,
    shift varchar2(20) not null,
    degree varchar2(20) not null
);
create table user_tb (
    username varchar2(20) not null constraint user_tb_pk primary key,
    password varchar2(20) not null,
    name varchar2(20) not null,
    email varchar2(4000) not null,
    phone varchar2(20),
    address varchar2(4000),
    photo_URL varchar2(4000),
    type varchar2(20),
    sex varchar2(1) not null
);
/

alter table user_tb add constraint user_tb_email_uq unique (email);
alter table user_tb add constraint user_tb_phone_uq unique (phone);

ALTER TABLE Doctor
ADD FOREIGN KEY(username)
REFERENCES  user_tb (username);

create table Patient (
    username varchar2(20) not null constraint patient_tb_pk primary key,
    weight varchar2(20),
    height varchar2(20),
    birthday varchar2(20) not null,
    blood_type varchar2(2) not null,
    university varchar2(10)
);
/
ALTER TABLE Patient
ADD FOREIGN KEY(username)
REFERENCES  user_tb (username);
create table Appointment (
    id number not null constraint appointment_pk primary key,
    doctor_username varchar2(20) not null,
    patient_username varchar2(20) not null,
    appointment_date varchar2(20),
    room varchar2(20) not null
);

ALTER TABLE Appointment
ADD FOREIGN KEY(doctor_username)
REFERENCES  Doctor (username);

ALTER TABLE Appointment
ADD FOREIGN KEY(patient_username)
REFERENCES  Patient(username);

create table Medicine (
    med_id number not null constraint medicine_pk primary key,
    name varchar2(20) not null,
    description varchar2(4000)
);
/
create table Prescription (
    appointment_id number not null constraint prescription_pk primary key,
    med_id number not null,
    dosage varchar2(4000) not null
);
ALTER TABLE Prescription
ADD FOREIGN KEY(Appointment_id)
REFERENCES  Appointment (id);

ALTER TABLE Prescription
ADD FOREIGN KEY(Med_id)
REFERENCES  Medicine  (Med_id);

create table Medical_Exam (
    id number not null constraint medical_exam_pk primary key,
    name varchar2(20) not null,
    min_val number ,
    max_val number
);
/
create table Patient_Exam (
    id number not null constraint patient_exam_pk primary key,
    exam_id number not null,
    patient_username varchar2(20) not null,
    value varchar2(20) not null,
    note varchar2(4000)
);
/
ALTER TABLE Patient_Exam
ADD FOREIGN KEY(exam_id)
REFERENCES  Medical_Exam   (id);

ALTER TABLE Patient_Exam
ADD FOREIGN KEY(patient_username)
REFERENCES  Patient(username);

create table Disease (
    ID number not null constraint disease_pk primary key,
    Name varchar2(20) not null,
    chronic varchar2(4000),
    Description varchar2(4000)
);

create table Patient_Disease (
    Patient_username varchar2(20) not null,
    Disease_id number not null,
    state varchar2(20),
    Diagnosis_data varchar2(20),
    constraint patient_disease_pk primary key (Patient_username, Disease_id)
);

ALTER TABLE Patient_Disease
ADD FOREIGN KEY(Patient_username)
REFERENCES  Patient(username);

ALTER TABLE Patient_Disease
ADD FOREIGN KEY(Disease_id)
REFERENCES  Disease (ID);