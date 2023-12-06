use master;
drop database if exists ELA;
go

create database ELA;
go

use ELA
go
create table piloti(
sifra int not null primary key identity (1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
brojdozvole varchar (15) not null
);

create table letovi(
sifra int not null primary key identity (1,1),
vrijemepolijetanja datetime not null,
vrijemeslijetanja datetime not null,
preletkm decimal (18,2),
pilot int not null,
zrakoplov int not null
);

create  table zrakoplovi(
sifra int not null primary key identity (1,1),
tipzrakoplova varchar (50) not null,
registracija varchar (15) not null
);

alter table letovi add foreign key (pilot) references piloti (sifra);
alter table letovi add foreign key (zrakoplov) references zrakoplovi (sifra);


insert into piloti (ime,prezime,brojdozvole) values
('Kristijan','Vuković','HR.SFCL.S.1012'),
('Borislav','Antolović','HR.SFCL.S.1013'),
('Dalibor','Vlašić','HR.SFCL.S.1014'),
('Igor','Ilić','HR.SFCL.S.1015'),
('Zvonimir','Blašković','HR.SFCL.S.1016'),
('Ladislav','Antić','HR.SFCL.S.1017'),
('Mato','Čizmić','HR.SFCL.S.1018'),
('Dejan','Ečimović','HR.SFCL.S.1019');

insert into zrakoplovi (tipzrakoplova,registracija) values
('Pilatus','9A-GPH'),
('KA-7','9A-GAK'),
('Pirat','9A-GAC');


insert into letovi (vrijemepolijetanja,vrijemeslijetanja,pilot,zrakoplov) values
('2023-08-24 16:00:00','2023-08-24 16:10:00',1,1),
('2023-08-24 16:00:00','2023-08-24 16:15:00',2,2),
('2023-08-24 16:00:00','2023-08-24 16:20:00',3,3),
('2023-08-24 16:11:00','2023-08-24 16:25:00',4,1),
('2023-08-24 16:16:00','2023-08-24 16:30:00',5,2),
('2023-08-24 16:21:00','2023-08-24 16:35:00',6,3),
('2023-08-24 16:26:00','2023-08-24 16:40:00',7,1),
('2023-08-24 16:31:00','2023-08-24 16:45:00',8,2);


