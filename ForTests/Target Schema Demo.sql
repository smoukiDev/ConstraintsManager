--Test Table
CREATE TABLE SHOP
(
GoodID NUMBER(6),
Good VARCHAR2(20 CHAR),
PRICE NUMBER(8,2)
)
--Test Table 2
CREATE TABLE SHOP2
(
GoodID NUMBER(6),
Good VARCHAR2(20 CHAR),
AMOUNT NUMBER(4)
)
--Test PK Constraint
ALTER TABLE SHOP 
ADD CONSTRAINT goodid_pk PRIMARY KEY (GOODID);
--Cleaning
ALTER TABLE SCOTT.SHOP DROP CONSTRAINT GOODID_PK;
--Test FK Constraint
ALTER TABLE SHOP2
ADD CONSTRAINT fk_goodid
FOREIGN KEY (GOODID)
REFERENCES SHOP (GOODID);
--Incorrect Statement
ALTER TABLE SCOTT.SHOP DROP CONSTRAINT GOODID_PK;
--Cleaning
ALTER TABLE SCOTT.SHOP2 DROP CONSTRAINT fk_goodid;
ALTER TABLE SCOTT.SHOP DROP CONSTRAINT GOODID_PK;
--Test UNIQUE Constraint
ALTER TABLE SHOP
ADD CONSTRAINT name_unique UNIQUE(PRICE);
--Cleaning
ALTER TABLE SCOTT.SHOP DROP CONSTRAINT name_unique;
--Drop Tables
DROP TABLE SHOP CASCADE CONSTRAINTS;
DROP TABLE SHOP2 CASCADE CONSTRAINTS;