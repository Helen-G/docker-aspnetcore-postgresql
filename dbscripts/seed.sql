
\connect toDodb

CREATE TABLE todo
(
    id serial PRIMARY KEY,
    title  VARCHAR (50)  NOT NULL,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    priority  VARCHAR (100)  NOT NULL
);

ALTER TABLE "todo" OWNER TO myuser;

Insert into todo(title,start_date,end_date,priority) values( 'Title 1','2019-07-1','2019-07-10','priority1');
Insert into todo(title,start_date,end_date,priority) values( 'Title 2', '2019-07-10', '2019-07-12','priority1');

