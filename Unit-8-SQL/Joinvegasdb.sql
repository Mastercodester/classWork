-- list all the gamblers
select * from gambler;

--list all the rows in the host table
select * from host;


--Show the name of each gambler and the casino name that hosts them
--gambler_ is in the gambler table
--casino_name is in the host table
--when you need data from more than one table you must find out what connects them
-- the id of the gambler connects the gambler to the host table

-- whenever you need data from more than one table its a join

select gambler_name,casino_name
from gambler, host
where gambler.id = host.id
;


select gambler_name, casino_name
from gambler
inner join -- type of join (instead of ,)
		host --code the other table
		on gambler.id = host.id
		;

select gambler_name, casino_name
from gambler inner join host
on gambler.id = host.id
;