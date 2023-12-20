create  database zad1;

use zad1;

use master;

create table zupani(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
);

create table zupanije(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
zupan int
);

create table opcine(
sifra int not null primary key identity(1,1),
zupanija int,
naziv varchar(50) not null
);

create table mjesta(
sifra int not null primary key identity(1,1),
opcina int,
naziv varchar(50) not null
);

alter table mjesta add foreign key (opcina) references opcine(sifra);
alter table opcine add foreign key (zupanija) references zupanije(sifra);
alter table zupanije add foreign key (zupan) references zupani(sifra);

insert into zupani(ime, prezime) values
('Stjepan','Kozic'),
('Zeljko','Kolar'),
('Ivan','Celjak'),
('Darko','Koren');

insert into zupanije(naziv) values
('Zagrebacka zupanija'),
('Krapinsko-zagorska zupanija'),
('Sisacko-moslavacka zupanija'),
('Koprivnicko-krizevacka zupanija');

insert into opcine(naziv) values
('Bale'),
('Cerna'),
('Dicmo'),
('Gradac');

insert into mjesta(naziv) values
('')
('')
('')
('');

select * from zupani;

select * from zupanije;

select * from opcine;