


create table Persons
(
PersonID int ,
FristName nvarchar(100),
LastName nvarchar(100),
DateOfBirth date,
constraint PK_Persons primary key (PersonID),
constraint UN_Emial unique  (Email),
constraint UN_PhoneNumber unique  (PhoneNumber),
)

create table Patients
(
PatientID int,
PersonID int,
constraint FK_Patients foreign key  (PersonID) references Persons(PersonID)

)

create table Doctors
(
DoctorID int,
PersonID int,
constraint FK_Doctors foreign key  (PersonID) references Persons(PersonID)

)

create table AppointmentStatus
(AppointmentStatusID tinyint primary Key,
AppointmentStatusName nvarchar(40),
)

select AppointmentStatusName from AppointmentStatus  join Appointments 
on AppointmentStatus.AppointmentStatusID = Appointments.AppointmentStatusID;

create table Appointments
(AppointmentID int,
constraint FK_App_Doctor foreign key (DoctorID) references Doctors(DoctorID),
constraint FK_App_Status foreign key (AppointmentStatusID) references AppointmentStatus(AppointmentStatusID),
constraint FK_App_MedicalRec foreign key (MedicalRecordID) references MedicalRecords(MedicalRecordID),
constraint FK_App_Payment foreign key (PaymentID) references Payments(PaymentID),
)

select * from Appointments

create table MedicalRecords
(MedicalRecordID int,

)

create table Prescriptions
(PrescriptionID int,
constraint FK_Prescription_MedicalRec foreign key (MedicalRecordID) references MedicalRecords(MedicalRecordID),
)

create table Payments
(PaymentID int,

)



SELECT DoctorID , FristName	,LastName ,Specialization	,DateOfBirth,	Gender	,PhoneNumber,	Email,	Address
FROM Doctors join Persons 
on Doctors.PersonID =1;

SELECT PatientID, FristName ,LastName,	DateOfBirth,Gender,	PhoneNumber,	Email,	Address
FROM Patients join Persons 
on Patients.PersonID=Persons.PersonID;

PatientID	FristName	LastName	DateOfBirth	Gender	PhoneNumber	Email	Address
DoctorID Specialization		FristName	LastName	DateOfBirth	Gender	PhoneNumber	Email	Address


SELECT DoctorID , FristName	,LastName ,Specialization	,DateOfBirth,
                                    Gender	,PhoneNumber,	Email,	Address
                                FROM Doctors join Persons 
                                on Doctors.PersonID = Persons.PersonID and DoctorID = 1 ;


SELECT*  FROM Doctors join Persons 
                                on Doctors.PersonID =Persons.PersonID;
DELETE FROM Patients join Persons 
                                on Patients.PersonID=Persons.PersonID;

SELECT TOP 1 Found = 'yes' FROM Doctors WHERE DoctorID=1



SELECT DoctorID ,Doctors.PersonID, FristName	,LastName ,Specialization,
                                    DateOfBirth, Gender	,PhoneNumber,	Email,	Address
                                FROM Doctors join Persons 
                                on   Doctors.PersonID = Persons.PersonID and DoctorID =1

DELETE FROM Persons WHERE PersonID =9

DoctorID	PersonID	FristName	LastName	Specialization	DateOfBirth	Gender	PhoneNumber	Email	Address