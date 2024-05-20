create database vjezba2;

use vjezba2;

create table decko(
sifra int not null,
indeferentno bit,
vesta varchar(34),
asocijalno bit not null
);

create table svekar(
sifra int not null,
stilfrizura varchar(48),
ogrlica int not null,
asocijalno bit not null
);

create table brat(
sifra int not null,
suknja varchar(47),
ogrlica int not null,
asocijalno bit not null,
neprijatelj int not null
);

create table zarucnica(
sifra int not null,
narukvica int,
bojakose varchar(37) not null,
novcica decimal(15,9),
lipa decimal(15,8) not null,
indeferentno bit not null
);

create table prijatelj(
sifra int not null, 
modelnaocala varchar(37),
treciputa datetime not null,
ekstroventno bit not null,
prviputa datetime,
svekar int not null
);

create table neprijatelj(
sifra int,
majica varchar(32),
haljina varchar(43),
lipa decimal(16,8),
modelnaocala varchar(49),
kuna decimal(12,6),
jmbag char(11),
cura int
);

create table cura(
sifra int not null,
haljina varchar(33) not null,
drugiputa datetime not null,
suknja varchar(38),
narukvica int,
introventno bit,
majica varchar(40) not null,
decko int
);

create table decko_zarucnica(
sifra int not null,
decko int not null,
zarucnica int not null
);