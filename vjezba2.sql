create database vjezba2;

use vjezba2;

create table decko(
sifra int not null primary key identity(1,1),
indeferentno bit,
vesta varchar(34),
asocijalno bit not null
);

create table svekar(
sifra int not null primary key identity(1,1),
stilfrizura varchar(48),
ogrlica int not null,
asocijalno bit not null
);

create table brat(
sifra int not null primary key identity(1,1),
suknja varchar(47),
ogrlica int not null,
asocijalno bit not null,
neprijatelj int not null
);

create table zarucnica(
sifra int not null primary key identity(1,1),
narukvica int,
bojakose varchar(37) not null,
novcica decimal(15,9),
lipa decimal(15,8) not null,
indeferentno bit not null
);

create table prijatelj(
sifra int not null primary key identity(1,1), 
modelnaocala varchar(37),
treciputa datetime not null,
ekstrovertno bit not null,
prviputa datetime,
svekar int not null
);

create table neprijatelj(
sifra int not null primary key identity(1,1),
majica varchar(32),
haljina varchar(43) not null,
lipa decimal(16,8),
modelnaocala varchar(49) not null,
kuna decimal(12,6) not null,
jmbag char(11),
cura int
);

create table cura(
sifra int not null primary key identity(1,1),
haljina varchar(33) not null,
drugiputa datetime not null,
suknja varchar(38),
narukvica int,
introvertno bit,
majica varchar(40) not null,
decko int
);

create table decko_zarucnica(
sifra int not null primary key identity(1,1),
decko int not null,
zarucnica int not null
);

alter table cura add foreign key (decko) references decko(sifra);
alter table neprijatelj add foreign key (cura) references cura(sifra);
alter table brat add foreign key (neprijatelj) references neprijatelj(sifra);
alter table prijatelj add foreign key (svekar) references svekar(sifra);
alter table decko_zarucnica add foreign key (decko) references decko(sifra);
alter table decko_zarucnica add foreign key (zarucnica) references zarucnica(sifra);
alter table prijatelj add foreign key (svekar) references svekar(sifra);

insert into neprijatelj (kuna)
values (560),
values (780),
values (630);

insert into cura (introvertno)
values (1),
values (0),
values (1);

insert into decko_zarucnica ()
values ();