create database prototype1;
use prototype1;

create table if not exists Utilizator(
user_id int unique primary key auto_increment, CNP varchar(13),
nume varchar(30), prenume varchar(30),
adresa varchar(50), nr_tel varchar(10),
email varchar(50), IBAN varchar(25), nr_contract varchar(20),
username varchar(20) unique, password varchar(20),
tip int);

create table if not exists Student(
student_id int unique primary key, nr_ore int, an int,
constraint student_id_fk foreign key (student_id) references Utilizator(user_id)
ON DELETE CASCADE);

create table if not exists Profesor(
prof_id int unique primary key,
nr_min_ore int, nr_max_ore int,
constraint prof_id_fk foreign key (prof_id) references Utilizator(user_id)
ON DELETE CASCADE);


create table if not exists Curs(
curs_id int unique primary key auto_increment,
denumire varchar(50), nr_max_stud int);

create table if not exists Profesor_Curs(
prof_curs_id int unique primary key auto_increment,
curs_id int, prof_id int, nr_stud int,
constraint curs_id_fk foreign key (curs_id) references Curs(curs_id) ON DELETE CASCADE,
constraint prof_id_fk2 foreign key (prof_id) references Profesor(prof_id) ON DELETE CASCADE);

create table if not exists Student_Curs(
student_curs_id int unique primary key auto_increment,
student_id int, curs_id int, prof_id int, nota decimal(4,2),
constraint student_id_fk2 foreign key (student_id) references Student(student_id) ON DELETE CASCADE,
constraint curs_id_fk2 foreign key (curs_id) references Curs(curs_id) ON DELETE CASCADE,
constraint fk_prf foreign key(prof_id) references Profesor(prof_id) ON DELETE CASCADE);


create table if not exists Activitate(
activitate_id int unique primary key auto_increment, tip int,
data_incepere date, data_finalizare date,
ora int, ziua int, pondere int, prof_curs_id int, nr_max_stud int,
constraint prof_curs_id_fk foreign key (prof_curs_id) references Profesor_Curs(prof_curs_id)
ON DELETE CASCADE);

create table if not exists Participare(
participare_id int unique primary key auto_increment,
student_id int, activitate_id int, nota int,
constraint student_id_fk3 foreign key (student_id) references Student(student_id) ON DELETE CASCADE,
constraint activitate_id_fk foreign key (activitate_id) references Activitate(activitate_id) ON DELETE CASCADE);

create table if not exists Grup(
grup_id int unique primary key auto_increment, curs_id int, nume varchar(30),
constraint curs_id_fk3 foreign key (curs_id) references Curs(curs_id) ON DELETE CASCADE); 


create table if not exists  Student_Grup(
student_grup_id int unique primary key auto_increment,
student_id int, grup_id int,
constraint student_id_fk4 foreign key (student_id) references Student(student_id) ON DELETE CASCADE,
constraint grup_id_fk foreign key (grup_id) references Grup(grup_id) ON DELETE CASCADE);


create table if not exists Activitate_Grup(
activitate_grup_id int unique primary key auto_increment,
nr_min_participanti int, data_activitate date, ora int, timp_expirare int, grup_id int,
constraint grup_id_fk2 foreign key (grup_id) references Grup(grup_id) ON DELETE CASCADE);

alter table activitate_grup add column descriere varchar(50);
alter table activitate_grup add column nr_participanti int;
alter table activitate_grup add column prof_id int;  

create table if not exists Participare_Activitate_Grup(
participare_activitate_grup_id int unique primary key auto_increment,
activitate_grup_id int, student_id int,
constraint activitate_grup_id_fk foreign key (activitate_grup_id) references Activitate_Grup(activitate_grup_id) ON DELETE CASCADE,
constraint student_id_fk5 foreign key (student_id) references Student(student_id) ON DELETE CASCADE);

create table if not exists Mesaj(
mesaj_id int unique primary key auto_increment,
student_grup_id int, continut text,
constraint student_grup_id_f foreign key (student_grup_id) references Student_Grup(student_grup_id) ON DELETE CASCADE);

create table if not exists Notificare(
notificare_id int unique primary key auto_increment,
continut text,descriere_activitate varchar(50), user_id int,
data datetime,
constraint user_fk foreign key (user_id) references Utilizator(user_id) 
ON DELETE CASCADE);
