Master tables:

//Class table
Create table Class
(
Class_ID varchar(20) primary key,
Class_Name varchar(50)
)

//Class Table Index
Create index idx_Class_ID on Class(Class_ID);

//Subject table
create table Subject
(
Subject_ID varchar(20) primary key,
Subject_Name varchar(50),
Class_ID varchar(20) references Class(Class_ID)
)

//Subject Table Index
Create index idx_Subject_ID on Subject(Subject_ID);

//Student table 
create table Student
(
Student_ID varchar(20) primary key,
Student_Name varchar(50),
Class_ID varchar(20),
foreign key (Class_ID) references Class(Class_ID)
)

//Student Table Index
Create index idx_Student_ID on Student(Student_ID);

//Feed Class Data:
Insert into Class values ("Cl_001","Class_I");
Insert into Class values ("Cl_002","Class_II");
Insert into Class values ("Cl_003","Class_III");
Insert into Class values ("Cl_004","Class_IV");
Insert into Class values ("Cl_005","Class_V");

//Feed Subject Data:
Insert into Subject values ("Sub_001","English","Cl_001");
Insert into Subject values ("Sub_002","Kannada","Cl_001");
Insert into Subject values ("Sub_003","Maths","Cl_001");
Insert into Subject values ("Sub_004","EVS","Cl_001");
Insert into Subject values ("Sub_005","GK","Cl_001");

//Feed Student Data:
Insert into Student values ("Stud_001","Ram","Cl_001");
Insert into Student values ("Stud_002","Stephen","Cl_001");
Insert into Student values ("Stud_003","Kaushik","Cl_001");
Insert into Student values ("Stud_004","Sanjay","Cl_001");
Insert into Student values ("Stud_005","Radha","Cl_001");