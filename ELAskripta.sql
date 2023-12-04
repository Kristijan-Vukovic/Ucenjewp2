use master;
go
drop database if exists ELA;
go

create database ELA;
go

use ELA
create table piloti(
sifra int not null primary key identity (1,1),
ime nvarchar(50) not null,
prezime nvarchar(50) not null,
brojdozvole varchar (10) not null
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