#event decrement timp_expirare
drop event if exists decrease;
delimiter //
create event decrease
on schedule every 1 minute
starts now()
on completion preserve
do
begin

update activitate_grup SET timp_expirare = case 
when timp_expirare = 0 then 0
else (timp_expirare - 1) end;

delete from activitate_grup where 
(timp_expirare < 1 and nr_participanti < nr_min_participanti) or
datediff(data_activitate, curdate()) < 0;

end; //
delimiter ;

#trigger increment nr participanti
drop trigger if exists increment_nr_part;
delimiter //
create trigger increment_nr_part after insert on participare_activitate_grup
for each row begin 
    update activitate_grup 
    join participare_activitate_grup using(activitate_grup_id) 
    set nr_participanti = nr_participanti + 1 
    where activitate_grup_id = new.activitate_grup_id;

end; // 
delimiter ;

#trigger send notificare after grup_activitate delete
drop trigger if exists sterge_act;
delimiter //
create trigger sterge_act before delete on activitate_grup
for each row begin
    declare profID int;
    if datediff(old.data_activitate, curdate()) > 0 then
        insert into notificare(continut,descriere_activitate, user_id, data) 
        select "Activitatea a fost anulata",descriere, student_id, curtime()
        from participare_activitate_grup join activitate_grup using(activitate_grup_id)
        where activitate_grup_id = old.activitate_grup_id;
        select prof_id from activitate_grup where activitate_grup_id=old.activitate_grup_id into profID;
        if profID is not null then insert into notificare
        (continut,descriere_activitate, user_id, data)
        values
        ("Activitatea a fost anulata", (select descriere from activitate_grup where activitate_grup_id = old.activitate_grup_id),profID,curtime());
        end if;
    end if;
end; //
delimiter ;

delete from activitate_grup where activitate_grup_id = 2;

#trigger incrementare numar de studenti pentru un profesor la un curs
drop trigger if exists increment_stud_prof_curs;
delimiter //
create trigger increment_stud_prof_curs after insert on student_curs
for each row begin
    update profesor_curs set nr_stud=nr_stud+1 
    where curs_id = new.curs_id 
    and prof_id=new.prof_id;
end; //
delimiter ;

#trigger verificare grup gol dupa student exit
drop trigger if exists stergere_grup;
delimiter //
create trigger stergere_grup after delete on student_grup
for each row begin
    declare grup_aparitii int;
    select count(*) from student_grup where grup_id = old.grup_id into grup_aparitii;
    if grup_aparitii = 0 then delete from grup where grup_id=old.grup_id; end if;
end; //
delimiter ;