CREATE DATABASE person_db
    WITH
    OWNER = postgres
    ENCODING ='UTF8'
    CONNECTION LIMIT = -1
    TEMPLATE=template0;

-- switch to database
\c person_db

CREATE TABLE IF NOT EXISTS "Person" (
    "id" SERIAL UNIQUE, 
    "name" VARCHAR NOT NULL,
    "surname" VARCHAR NOT NULL, 
    "birthdate" date,
    PRIMARY KEY(id)
);

ALTER TABLE "Person" OWNER to postgres;