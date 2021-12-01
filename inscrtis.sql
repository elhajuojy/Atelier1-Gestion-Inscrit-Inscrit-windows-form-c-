
create database inscrits
use inscrits

create table utilisateurs(
    code_utilisateur int identity(1,1) not null,
	login varchar(30) primary key  ,
	pw varchar(30),
	profile char(1),
	nom varchar(30),
	prenom varchar(30),
	fonction varchar(30),
	constraint chk_profile check(profile in ('a','o','u'))
)


create table modules (
    code_module int identity not null primary key,
    lib_module varchar(50))



select * from modules
DELETE FROM modules 
insert into modules values('');


-- PROCEDURE sp_authentification

CREATE PROCEDURE sp_authentification
@login varchar(30),
@pw varchar(30)
AS
SELECT * FROM utilisateurs
WHERE login=@login AND pw=@pw
GO

sp_authentification'mehdi','elhjuojy'



create table filieres (
    num_filiere int identity not null primary key,
    lib_filiere varchar(50))

select * from filieres


create table inscrits(
    num_inscrit char(5) not null primary key,
    nom_inscri varchar(30),
    prenom_inscri varchar(30),
    adresse varchar(70),
    date_naiss datetime,
    date_inscription datetime,
    num_filiere int,
constraint fk_inscrit_num_filiere foreign key(num_filiere)
references filieres(num_filiere))



create table notes(
   code_module int not null,
   num_inscrit char(5) not null,
   num_semestre int not null,
   note float,
   constraint pk_notes primary
   key(code_module,num_inscrit,num_semestre),
   constraint fk_notes_num_module foreign key(code_module)
   references modules(code_module) ,
   constraint fk_notes_num_inscrit foreign key(num_inscrit)
   references inscrits(num_inscrit))
 



insert into utilisateurs values ('mehdi123','elhjuojy','o','ELMAHDI','ELHJUOJY','Admis');
insert into utilisateurs values ('ahmed123 ','bounacer','o','bounacer','bounacer','Admis');
insert into utilisateurs values ('zineb123 ','belhaid','o','zineb','belhaid','Admis');
insert into utilisateurs values ('mustapha123','1111','o','sobbi','mustafa','Admis');
insert into utilisateurs values ('HASNA123','2222','u','fahmi','hasna','Admis');
insert into utilisateurs values ('khalil123 ','3333','u','madraoui','khalil','Admis');
insert into utilisateurs values ('fatima123','4444','u','bousserhame','fatima','Admis');
insert into utilisateurs values ('houssam123','jebaar','a','jebaar','houssam','Admis');



DELETE FROM utilisateurs where login=''

select * from utilisateurs order by code_utilisateur

select * from utilisateurs where code_utilisateur=3037;

UPDATE utilisateurs
SET login = '', pw = '', profile='',nom='',prenom=''
where login='' and pw='' and nom='' and prenom=''


select login , pw  from utilisateurs where login ='mehdi' and pw ='elhjuojy';

select nom ,prenom ,login , fonction from utilisateurs where code_utilisateur =3;



select login,pw,nom ,prenom from utilisateurs where login='' and pw=''and nom=''and prenom=''


alter table utilisateurs add constraint PK_utilisateurs primary key(login,code_utilisateur);

