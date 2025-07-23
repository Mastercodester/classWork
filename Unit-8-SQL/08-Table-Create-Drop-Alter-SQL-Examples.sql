---------------------------------------------------------------------------------------------------------------
--
-- DROP - remove a table and all it's data from the database
--
-- Consider referential constraints - cannot drop a parent if it has dependents
--
--      DROP TABLE table-name             - Will fail if table does not exist or if it has dependents
--
--      DROP TABLE IF EXISTS table-name   - Will run whether table exists or not; will fail if table has dependents
--
--      DROP TABLE IF EXISTS table-name  CASCADE   - Will run whether table exists or not and whether has dependents or not
--
--
--  CREATE - define a table to the database manager
--
--       CREATE TABLE table-name
--       (column-name     data-type    NOT NULL,
--        column-name     data-type,
--        column-name     data-type    DEFAULT   default-value,
--        column-name     data-type    UNIQUE,
--        CONSTRAINT constraint-name PRIMARY KEY (column(s)-in-table),
--        CONSTRAINT constraint-name FOREIGN KEY(for-key-column(s)) REFERENCES parent-table(pri-key-column(s)),
--        CONSTRAINT constraint-name  CHECK (where-predicate)
--       )
--
--       Note: CONSTRAINT is part of the set of column definitions (i.e. inside the parens for column specification)
--
-- 
-- ALTER - changing the definition of a table
--
-- Commonly used to add/remove constraints on tables or change existing table attributes
--
--
-- Add a FOREIGN KEY - Establish Parent/Dependant relationship
--
-- FOREIGN KEY must have the same-number, same-order, compatible-data-type as entire PRIMARY KEY of parent
--             and must have a matching value in the PRIMARY KEY in the parent table
--
-- When adding FOREIGN KEY after data has been loaded into table, all FOREIGN KEY values must have a match in parent
--
--      ALTER TABLE dependent-table-name ADD FOREIGN KEY(for-key-column(s)) REFERENCES parent-table(pri-key-column(s)) 
--
-- Remove a constraint from a table
--
--      ALTER TABLE table-name DROP CONSTRAINT constraint_name
--
--
-- Add a column to an existing table
--
-- Cannot add a NOT NULL column to a table with existing data
--
--      ALTER TABLE table-name ADD COLUMN new_column_name data_type constraint
--
--
-- Rename an existing column in a table
--
--      ALTER TABLE table-name RENAME column-name TO new-column-name;
--
--
-- Rename a table
--
--      ALTER TABLE table-name RENAME TO new-table-name  - Will fail if table does not exist
--
--      ALTER TABLE IF EXISTS table-name RENAME TO new-table-name  - Successful if table exists or not
--
---------------------------------------------------------------------------------------------------------------

--DRop tables

drop table if exists pet_types CASCADE;  --  CASCADE says drop even if they has dependents
drop table if exists pet_owner      CASCADE;
drop table if exists    pet   CASCADE;




--
--CReate PET_TYPES TABLE
-- (Parent table to pet - parents must be created before dependaents)
--


CREATE TABLE pet_types
(
--	Column-name 	data type			nullness
   pet_type_id     serial              not null,-- serial tells postgres to automatically generate a unique initeger value
	name			char(15)			not null,
	species 		varchar(50)			not null,
	CONSTRAINT pk_pet_type_id PRIMARY KEY (pet_type_id)

)
;


--Create Owner table

CREATE TABLE pet_owner
(
	owner_id  	serial     not null,
	last_name  varchar(50)  not null,
	first_name varchar(50)   not null,
	address 	varchar(100),     
	city 		varchar(20), 
	state 	char(2),
	CONSTRAINT pk_owner_id PRIMARY KEY (owner_id)



);






--create pet 

CREATE TABLE pet
(
pet_id		serial		not null,
name 		varchar(250)	not null,
pet_type_id   integer       not null,
owner_id      integer    not null,
CONSTRAINT pk_pet_id PRIMARY KEY (pet_id),
 
 CONSTRAINT fk_pet_type_id FOREIGN KEY(pet_type_id) 
 REFERENCES pet_types(pet_type_id),
  
  CONSTRAINT fk_owner_id FOREIGN KEY(owner_id) 
 REFERENCES pet_owner(owner_id)
);
