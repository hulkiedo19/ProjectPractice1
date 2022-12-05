create table Equipment
(
	Id int primary key identity,
	EquipmentName nvarchar(max) not null,
	EquipmentCount int not null,
	EquipmentImage nvarchar(max) not null,
	EquipmentDescription nvarchar(max) null
);
create table Department
(
	Id int primary key identity,
	DepartmentName nvarchar(max) not null,
	DepartmentBuild nvarchar(max) not null,
	DepartmentNumber int not null,
	DepartmentMaxEmployees int not null,
	DepartmentRooms int not null,
	EquipmentId int foreign key references Equipment(Id)
);
create table Post
(
	Id int primary key identity,
	PostName nvarchar(max) not null,
	PostDescription nvarchar(max) null
);
create table Employee
(
	Id int primary key identity,
	FirstName nvarchar(max) not null,
	LastName nvarchar(max) not null,
	MiddleName nvarchar(max) not null,
	Photo nvarchar(max) not null,
	Age int not null,
	Expirience int not null,
	PostId int foreign key references Post(Id),
	DepartmentId int foreign key references Department(Id)
);