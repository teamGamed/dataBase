CREATE SEQUENCE APPOINTMENT_sequence
start with 1
increment by 1
maxvalue 10000;
create or replace TRIGGER APPOINTMENT_on_insert
  BEFORE INSERT ON APPOINTMENT
  FOR EACH ROW
BEGIN
  :new.ID :=APPOINTMENT_sequence.nextval;
END;
CREATE SEQUENCE MEDICINE_sequence
start with 1
increment by 1
maxvalue 10000;
create or replace TRIGGER MEDICINE_on_insert
  BEFORE INSERT ON MEDICINE
  FOR EACH ROW
BEGIN
  :new.MED_ID :=MEDICINE_sequence.nextval;
END;
CREATE SEQUENCE MEDICAL_EXAM_sequence
start with 1
increment by 1
maxvalue 10000;
create or replace TRIGGER MEDICAL_EXAM_on_insert
  BEFORE INSERT ON MEDICAL_EXAM
  FOR EACH ROW
BEGIN
  :new.ID :=MEDICAL_EXAM_sequence.nextval;
END;
CREATE SEQUENCE PATIENT_EXAM_sequence
start with 1
increment by 1
maxvalue 10000;
create or replace TRIGGER PATIENT_EXAM_on_insert
  BEFORE INSERT ON PATIENT_EXAM
  FOR EACH ROW
BEGIN
  :new.ID :=PATIENT_EXAM_sequence.nextval;
END;
CREATE SEQUENCE DISEASE_sequence
start with 1
increment by 1
maxvalue 10000;
create or replace TRIGGER DISEASE_on_insert
  BEFORE INSERT ON DISEASE
  FOR EACH ROW
BEGIN
  :new.ID :=DISEASE_sequence.nextval;
END;
