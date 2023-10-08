


create table Persons
(
PersonID int ,
FristName nvarchar(100),
LastName nvarchar(100),
DateOfBirth date,Gender nvarchar(1),PhoneNumber nvarchar(20),Email nvarchar(100),Address nvarchar(200),
constraint PK_Persons primary key (PersonID),
constraint UN_Emial unique  (Email),
constraint UN_PhoneNumber unique  (PhoneNumber),
)

create table Patients
(
PatientID int,
PersonID int,constraint PK_Patients primary key (PatientID),
constraint FK_Patients foreign key  (PersonID) references Persons(PersonID)

)

create table Doctors
(
DoctorID int,
PersonID int,Specialization nvarchar(100),constraint PK_Doctors primary key (DoctorID),
constraint FK_Doctors foreign key  (PersonID) references Persons(PersonID)

)

create table AppointmentStatus
(AppointmentStatusID tinyint primary Key,
AppointmentStatusName nvarchar(40),
)

select AppointmentStatusName from AppointmentStatus  join Appointments 
on AppointmentStatus.AppointmentStatusID = Appointments.AppointmentStatusID;

create table Appointments
(AppointmentID int,PatientID int,DoctorID int,AppointmentDateTime datetime unique not null,AppointmentStatusID tinyint not null,MedicalRecordID int,PaymentID int,constraint PK_Appointments primary key (AppointmentID),constraint FK_App_Patient foreign key (PatientID) references Patients(PatientID),
constraint FK_App_Doctor foreign key (DoctorID) references Doctors(DoctorID),
constraint FK_App_Status foreign key (AppointmentStatusID) references AppointmentStatus(AppointmentStatusID),
constraint FK_App_MedicalRec foreign key (MedicalRecordID) references MedicalRecords(MedicalRecordID),
constraint FK_App_Payment foreign key (PaymentID) references Payments(PaymentID),
)

select * from Appointments

create table MedicalRecords
(MedicalRecordID int,VisitDescription nvarchar(200),Diagnosis nvarchar(200),AdditionalNotes nvarchar(200),constraint PK_MedicalRecords primary key (MedicalRecordID)

)

create table Prescriptions
(PrescriptionID int,MedicalRecordID int,MedicationName nvarchar(100) not null,Dosage nvarchar(50) not null,Frequency nvarchar(50) not null,StartDate date ,EndDate date,SpecialInstructions nvarchar(200),constraint PK_Prescription primary key (PrescriptionID),
constraint FK_Prescription_MedicalRec foreign key (MedicalRecordID) references MedicalRecords(MedicalRecordID),
)

create table Payments
(PaymentID int,PaymentDate datetime not null,PaymentMethod nvarchar(50) not null,AmountPaid decimal not null,AdditionalNotes nvarchar(200) null,constraint PK_Payments primary key (PaymentID),

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