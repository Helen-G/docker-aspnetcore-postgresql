
\connect toDodb

CREATE TABLE toDo
(
    id serial PRIMARY KEY,
    title  VARCHAR (50)  NOT NULL,
    startDate DATE NOT NULL,
    endDate DATE NOT NULL,
    priority  VARCHAR (100)  NOT NULL
);

ALTER TABLE "toDo" OWNER TO myuser;

Insert into toDo(title,startDate,endDate,priority) values( 'Title 1','2019-07-1','2019-07-10','priority1');
Insert into toDo(title,startDate,endDate,priority) values( 'Title 2', '2019-07-10', '2019-07-12','priority1');

