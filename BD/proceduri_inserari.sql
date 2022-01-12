use prototype1;

drop procedure if exists creare_utilizator;
delimiter // 
create procedure creare_utilizator(CNP varchar(13),
nume varchar(30), prenume varchar(30),
adresa varchar(50), nr_tel varchar(10),
email varchar(50), IBAN varchar(25), nr_contract varchar(20),
username varchar(20), password varchar(20),
tip int, var1 int, var2 int)
begin
	insert into Utilizator (CNP,nume,prenume,adresa,nr_tel,email,IBAN,nr_contract,username,password,tip) 
    values (CNP,nume,prenume,adresa,nr_tel,email,IBAN,nr_contract,username,password,tip);
    set @tmp = (Select utilizator.user_id from Utilizator where Utilizator.username=username);
    if tip = 0 then 
		insert into Student values (@tmp,var1,var2);
    elseif tip = 1 then 
		insert into Profesor values (@tmp,var1,var2);
	end if;
end; //
delimiter ;

drop procedure if exists student_cautare_curs;
delimiter // 
create procedure student_cautare_curs(in nume varchar(20))
begin
	select curs.denumire,utilizator.nume,utilizator.prenume
    from Curs join profesor_curs on curs.curs_id=profesor_curs.curs_id  join profesor on profesor_curs.prof_id = profesor.prof_id join 
    utilizator on profesor.prof_id = utilizator.user_id
    where curs.denumire like concat('%',nume,'%');
end; //
delimiter ;

drop procedure if exists student_inscriere_curs;
delimiter // 
create procedure student_inscriere_curs(in studentID int, nume_curs varchar(20))
begin
	set@prof=(select profesor_curs.prof_id from profesor_curs join curs on curs.curs_id=profesor_curs.curs_id 
    where curs.denumire like nume_curs group by profesor_curs.curs_id order by nr_stud asc limit 1);
    set@curs=(select profesor_curs.curs_id from profesor_curs join curs on curs.curs_id=profesor_curs.curs_id 
    where curs.denumire like nume_curs limit 1);
    if (@prof is not null and @curs is not null) then
		insert into student_curs (student_id, curs_id, prof_id, nota) values (studentID,@curs,@prof,0);
        update profesor_curs set nr_stud=nr_stud+1 where profesor_curs.prof_id=@prof and profesor_curs.curs_id=@curs;
	end if;
end; //
delimiter ;

drop procedure if exists student_vizualizare_note;
delimiter // 
create procedure student_vizualizare_note(in studentID int)
begin
    select curs.denumire, student_curs.nota from student_curs join curs on student_curs.curs_id = curs.curs_id 
    where student_curs.student_id = studentID;

end; //
delimiter ;

drop procedure if exists student_vizualizare_act;
delimiter // 
create procedure student_vizualizare_act(in studentID int)
begin
    select activitate.tip,activitate.pondere, participare.nota
    from student join participare on student.student_id = participare.student_id
    join activitate on participare.activitate_id = activitate.activitate_id 
    join profesor_curs on activitate.prof_curs_id = profesor_curs.prof_curs_id
    join curs on curs.curs_id = profesor_curs.curs_id
    
     ;

end; //
delimiter ;

drop procedure if exists asign_prof_curs;
delimiter // 
create procedure asign_prof_curs(in profID int, in cursID int)
begin
    insert into profesor_curs (curs_id,prof_id,nr_stud) values (cursID,profID,0);
end; //
delimiter ;

drop procedure if exists prof_asign_act;
delimiter // 
create procedure prof_asign_act(in profID int, in den varchar(50), ora_act int, zi_act int,pond int, nr_max int, tip_act int, data_inc date, data_fin date)
begin
	set @cursID_tmp = (select curs.curs_id from curs where curs.denumire = den limit 1);
    set @id_tmp = (select profesor_curs.prof_curs_id from profesor_curs where profesor_curs.curs_id = @cursID_tmp and profesor_curs.prof_id = profID limit 1);
    insert into activitate (tip, data_incepere,data_finalizare, ora, ziua, pondere, prof_curs_id,nr_max_stud) values (tip_act, data_inc, data_fin, ora_act,zi_act,pond,@id_tmp,nr_max);

end; //
delimiter ;


drop procedure if exists prof_nota_act;
delimiter // 
create procedure prof_nota_act(in notaNoua int, in cursID int, in profID int, in tipActivitate int, in studID int)
begin

    declare notaOld, pondereAct int;

    select participare.nota, activitate.pondere into notaOld, pondereAct from participare 
    join activitate on participare.activitate_id = activitate.activitate_id
    join profesor_curs on activitate.prof_curs_id = profesor_curs.prof_curs_id 
    where profesor_curs.curs_id = cursID 
    and profesor_curs.prof_id = profID
    and activitate.tip = tipActivitate 
    and participare.student_id = studID;

    update participare join activitate on participare.activitate_id = activitate.activitate_id
    join profesor_curs on activitate.prof_curs_id = profesor_curs.prof_curs_id
    set participare.nota= notaNoua
    where profesor_curs.curs_id = cursID and profesor_curs.prof_id = profID
    and activitate.tip = tipActivitate and participare.student_id = studID;

    set @notaOldDecimal = cast(notaOld as decimal(4,2));
    if pondereAct >= 100 then set @pondereActDecimal = 1;
    else set @pondereActDecimal = cast(cast(pondereAct as decimal(4,2))/100 as decimal(4,2));
    end if;

    set @notaNewDecimal = cast(notaNoua as decimal(4,2));
    set @toAdd =cast((@notaNewDecimal - @notaOldDecimal)*@pondereActDecimal as decimal(4,2));
   # select @notaOldDecimal, @notaNewDecimal, @pondereActDecimal,@toAdd;
   # update student_curs set
   update student_curs set nota = nota+@toAdd where student_id = studID and prof_id = profId and curs_id = cursID;

end; //
delimiter ;

drop function if exists pondere_locala;
delimiter // 
create function pondere_locala(profID int,den varchar(50)) returns int
deterministic
BEGIN
DECLARE sum INT;
DECLARE c_id INT;

select curs.curs_id from curs where curs.denumire = den limit 1 into c_id;

select sum(pondere) from (
select tip, pondere, row_number() over (partition by tip) rn 
from activitate join profesor_curs using (prof_curs_id)
where profesor_curs.curs_id=c_id and profesor_curs.prof_id=profID 
) a where rn = 1 into sum;

if sum is NULL then return 0;
end if;
return sum;
    
end;//
delimiter ;


#inserare mesaj
drop procedure if exists inserare_mesaj;
delimiter //
create procedure inserare_mesaj(in studID int, in grupID int, in msg text)
begin
    declare studentGrupID int;
    select student_grup_id from student_grup where student_id = studID and grup_id = grupID into studentGrupID;
    insert into mesaj(student_grup_id,continut) values (studentGrupID,msg);
end; //
delimiter ;

drop procedure if exists auto_inserare;
delimiter //
create procedure auto_inserare(in studID int)
begin
    declare latest_act int;
    select activitate_grup_id from activitate_grup order by activitate_grup_id desc limit 1 into latest_act;
    insert into participare_activitate_grup (activitate_grup_id,student_id) values (latest_act,studID);
end; //
delimiter ;



drop procedure if exists init_search_table;
delimiter //
create procedure init_search_table()
begin 
	drop table if exists freq_search;
	create table freq_search (
	freq int default 0,
	ora int, 
	ziua int,
	primary key(ora, ziua)
	);

	insert into freq_search(ora, ziua) values
	(8,2),(8,3),(8,4),(8,5),(8,6),(8,7),(8,1),
	(9,2),(9,3),(9,4),(9,5),(9,6),(9,7),(9,1),
	(10,2),(10,3),(10,4),(10,5),(10,6),(10,7),(10,1),
	(11,2),(11,3),(11,4),(11,5),(11,6),(11,7),(11,1),
	(12,2),(12,3),(12,4),(12,5),(12,6),(12,7),(12,1),
	(13,2),(13,3),(13,4),(13,5),(13,6),(13,7),(13,1),
	(14,2),(14,3),(14,4),(14,5),(14,6),(14,7),(14,1),
	(15,2),(15,3),(15,4),(15,5),(15,6),(15,7),(15,1),
	(16,2),(16,3),(16,4),(16,5),(16,6),(16,7),(16,1),
	(17,2),(17,3),(17,4),(17,5),(17,6),(17,7),(17,1),
	(18,2),(18,3),(18,4),(18,5),(18,6),(18,7),(18,1),
	(19,2),(19,3),(19,4),(19,5),(19,6),(19,7),(19,1),
	(20,2),(20,3),(20,4),(20,5),(20,6),(20,7),(20,1);
end; // 
delimiter ;



drop procedure if exists sugerare_fereastra;
delimiter //
create procedure sugerare_fereastra(in grupID int)
begin
	
	declare ora_param int default 0;
    declare ziua_param int default 0;
    declare freq_param int default 0;
    declare finished int default 0;
    
	declare mycursor cursor for select count(student_id) as freq, ora, ziua
    from (
		select student_id,ora as ora,ziua as ziua 
        from activitate join participare using(activitate_id)
		where student_id in (select student_id as student_id from student_grup where student_grup.grup_id=grupID)
        union
        select student_id,ora as ora,dayofweek(data_activitate) as ziua 
        from participare_activitate_grup join activitate_grup using(activitate_grup_id) 
        where activitate_grup.grup_id=grupID and weekofyear(current_date())=weekofyear(activitate_grup.data_activitate)
    ) T
    group by T.ora, T.ziua order by freq desc;
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET finished = 1;
    
    call init_search_table(); 
    
    open mycursor;
    mycursor: loop 
		IF finished = 1 THEN 
			LEAVE mycursor;
		end if;
		fetch mycursor into freq_param, ora_param, ziua_param;
        update freq_search set freq = freq_param where ora = ora_param and ziua = ziua_param;
	end loop mycursor;
    close mycursor;
    
end; //
delimiter ;



call creare_utilizator('5211202019351','Popa','Matei','Aiud, Aleea Trandafirilor Nr. 21','0763123559','popa.matei@yahoo.com',
'RO09PORL8297336485969785','100001','popamatei','12345678',0,28,1);

call creare_utilizator('5212202029423','Anton','Daniel','Arad, Strada Calil Petrescu Nr. 13','0770234244','anton_daniel@gmail.com',
'RO58RZBR8384245567247153','100002','antondaniel','12345678',0,30,2);

call creare_utilizator('2752202079883','Sima','Ionela','Blaj, Strada Orhideelor Nr. 76','0770589634','simaionela@yahoo.com',
'RO90PORL2998549326977255','102563','simaionela','pass',1,20,40);

call creare_utilizator('1720920677183','Micu','Ilie','Brasov, Strada Avantului Nr. 3','0753711276','iliemicu@yahoo.com',
'RO37RNCB3976873674854577','106810','micuilie','parola',1,10,35);

insert into curs (denumire, nr_max_stud) values ('ALGA','200'), ('Analiza',210), ('Analiza II',210), ('Lb. Engleza',100), ('Lb. Spaniola', 120);

insert into profesor_curs (curs_id, prof_id, nr_stud) values (1,4,0), (4,3,0), (2,4,0), (3,4,0), (5,3,0);

call creare_utilizator('2700619386572','Admin','Adina','Timisoara, Strada Adminilor Nr. 1','0701031111','admin.adina@gmail.com',
'RO27PORL2173785662357396','110000','admin','admin',2,0,0);

call creare_utilizator('5010515112233','Iftene','Florin','Sibiu, Strada Tiglarilor','0735539291','floriniftene01@gmail.com',
'RO27BTRL2173785662357396','111111','florin','pass',3,0,0);

call creare_utilizator('2854617895632','Super','Admin','Cluj-Napoca, Strada Ceahlau, nr. 77','0785631242','super@gmail.com',
'RO27BTRL217375984262316','786641','superadmin','superadmin',3,0,0);

insert into grup (curs_id, nume) values (2, "Pregatire examen Analiza");

insert into student_grup (student_id, grup_id) values (1,1);

select continut, descriere_activitate, data from notificare where student_id=1;

select student_id,nume,prenume from utilizator
join student_curs on student_curs.student_id = utilizator.user_id 
where student_curs.curs_id= (select curs_id from grup where grup.grup_id = 1)
and student_id not in (select student_id from student_grup where grup_id = 1);

