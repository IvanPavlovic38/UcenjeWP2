create  database zad1;

use zad1;

use master;

create table zupani(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(50),
);

create table zupanije(
sifra int not null primary key identity(1,1),
naziv varchar(50),
zupan int
);

create table opcine(
sifra int not null primary key identity(1,1),
zupanija int,
naziv varchar(50)
);

create table mjesta(
sifra int not null primary key identity(1,1),
opcina int,
naziv varchar(50)
);

alter table mjesta add foreign key (opcina) references opcina(sifra);
alter table opcine add foreign key (zupanija) references zupanije(sifra);
alter table zupanije add foreign key (zupan) references zupani(sifra);