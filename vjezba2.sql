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