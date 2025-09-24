create database Medicos
go
use Medicos
go

create table Rol(
idRol int identity (1,1) primary key,
nombreRol varchar (50)
);
go
INSERT INTO Rol (nombreRol) VALUES
('Administrador'),
('Médico'),	
('Recepcionista');
go

create table Especialidad (
idEspecialidad int identity (1,1) primary key,
nombreEspecialidad varchar (100)
);
go
INSERT INTO Especialidad (nombreEspecialidad) VALUES
('Medicina General'),
('Pediatría'),
('Cardiología'),
('Dermatología'),
('Neurología'),
('Ginecología'),
('Traumatología'),
('Oftalmología'),
('Otorrinolaringología'),
('Psiquiatría');
go

create table Paciente (
idPaciente int identity (1,1) primary key,
nombrePaciente varchar (100),
email varchar (100),
telefono varchar (8)
);
go
INSERT INTO Paciente (nombrePaciente, email, telefono) VALUES
('Juan Pérez', 'juan.perez@gmail.com', '71234567'),
('María Gómez', 'maria.gomez@yahoo.com', '72345678'),
('Carlos López', 'carlos.lopez@hotmail.com', '73456789'),
('Ana Rodríguez', 'ana.rodriguez@gmail.com', '74567890'),
('Luis Martínez', 'luis.martinez@gmail.com', '75678901'),
('Sofía Hernández', 'sofia.hernandez@gmail.com', '76789012'),
('Pedro Ramírez', 'pedro.ramirez@gmail.com', '77890123'),
('Carmen Torres', 'carmen.torres@yahoo.com', '78901234'),
('Diego Castro', 'diego.castro@gmail.com', '79012345'),
('Laura Morales', 'laura.morales@gmail.com', '70123456');
go

create table Usuarios (
idUsuario int identity (1,1) primary key,
idRol int,
nombreUsuario varchar (100),
clave varchar (100),
email varchar (100),
foreign key (idRol) references Rol (idRol)
);
go
INSERT INTO Usuarios (idRol, nombreUsuario, clave, email) VALUES
(1, 'admin1', 'admin123', 'admin1@clinica.com'),
(1, 'admin2', 'admin456', 'admin2@clinica.com'),
(2, 'medico1', 'medico123', 'medico1@clinica.com'),
(2, 'medico2', 'medico456', 'medico2@clinica.com'),
(2, 'medico3', 'medico789', 'medico3@clinica.com'),
(3, 'recepcion1', 'recep123', 'recepcion1@clinica.com'),
(3, 'recepcion2', 'recep456', 'recepcion2@clinica.com'),
(3, 'recepcion3', 'recep789', 'recepcion3@clinica.com'),
(2, 'medico4', 'medicoabc', 'medico4@clinica.com'),
(2, 'medico5', 'medicoxyz', 'medico5@clinica.com');
go

create table Medicos (
idMedico int identity (1,1) primary key,
idEspecialidad int,
nombreMedico varchar (100),
dui int unique,
telefono varchar (8),
foreign key (idEspecialidad) references Especialidad (idEspecialidad)
);
go
INSERT INTO Medicos (idEspecialidad, nombreMedico, dui, telefono) VALUES
(1, 'Dr. José Herrera', 12345670, '70011223'),
(2, 'Dra. Marta López', 12345671, '70022334'),
(3, 'Dr. Carlos Méndez', 12345672, '70033445'),
(4, 'Dra. Ana Torres', 12345673, '70044556'),
(5, 'Dr. Luis Ramírez', 12345674, '70055667'),
(6, 'Dra. Sofía Morales', 12345675, '70066778'),
(7, 'Dr. Pedro Castillo', 12345676, '70077889'),
(8, 'Dra. Carmen Aguilar', 12345677, '70088990'),
(9, 'Dr. Diego Sánchez', 12345678, '70099001'),
(10, 'Dra. Laura Campos', 12345679, '70100112');
go

create table Diagnostico (
idDiagnostico int identity (1,1) primary key,
idMedico int,
descripcion varchar (250),
medicamentos varchar (250),
foreign key (idMedico) references Medicos (idMedico)
 );
 go
 INSERT INTO Diagnostico (idMedico, descripcion, medicamentos) VALUES
(1, 'Gripe común', 'Paracetamol'),
(2, 'Faringitis', 'Amoxicilina'),
(3, 'Arritmia leve', 'Beta-bloqueadores'),
(4, 'Dermatitis alérgica', 'Cremas tópicas'),
(5, 'Migraña', 'Ibuprofeno'),
(6, 'Diabetes tipo 2', 'Metformina'),
(7, 'Fractura de brazo', 'Yeso + analgésicos'),
(8, 'Conjuntivitis', 'Colirio antibiótico'),
(9, 'Sinusitis crónica', 'Antibióticos + antihistamínicos'),
(10, 'Depresión leve', 'Sertralina');
 go

 create table Citas (
 idCita int identity (1,1) primary key,
 idDiagnostico int,
 idPaciente int,
 fechaCita date,
 foreign key (idDiagnostico) references Diagnostico (idDiagnostico),
 foreign key (idPaciente) references Paciente (idPaciente)
 );
 go
INSERT INTO Citas (idDiagnostico, idPaciente, fechaCita) VALUES
(1, 1, '2025-09-10'),
(2, 2, '2025-09-11'),
(3, 3, '2025-09-12'),
(4, 4, '2025-09-13'),
(5, 5, '2025-09-14'),
(6, 6, '2025-09-15'),
(7, 7, '2025-09-16'),
(8, 8, '2025-09-17'),
(9, 9, '2025-09-18'),
(10, 10, '2025-09-19');
