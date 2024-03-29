DROP TABLE RENEWALS;
DROP TABLE GOLFMEMBERSLOG;
DROP TABLE MEMBERTYPES;
DROP TABLE COUNTYLIST;
DROP TABLE MEMBERSTATUS;

CREATE TABLE MEMBERSTATUS
(

	MEMBERSTATUS NVARCHAR2(10) NOT NULL,

	CONSTRAINT MEMBERSTATUS_primary_key PRIMARY KEY (MEMBERSTATUS)

);

CREATE TABLE MEMBERTYPES
(
	TYPEID NVARCHAR2(2) NOT NULL,
	TYPENAME NVARCHAR2(50),
	TYPEPRICE NUMBER(5,2),

	CONSTRAINT MEMBERTYPES_primary_key PRIMARY KEY (TYPEID)
);

CREATE TABLE COUNTYLIST
(
    COUNTY NVARCHAR2(50) NOT NULL,
    
    CONSTRAINT COUNTYLIST_primary_key PRIMARY KEY (COUNTY)
);

CREATE TABLE GOLFMEMBERSLOG
(
	MEMBERID NUMBER(3) NOT NULL,
	FIRSTNAME NVARCHAR2(50),
	LASTNAME NVARCHAR2(150),
	STREET NVARCHAR2(30),
    TOWN NVARCHAR2(30),
    COUNTY NVARCHAR2(30),
	MOBILE NVARCHAR2(10),
	EMAIL NVARCHAR2(150),
	MEMBERSTATUS NVARCHAR2(10),
	SIGNUPDATE DATE,
    TYPEID NVARCHAR2(2) NOT NULL,
    PAID NVARCHAR2(1) NOT NULL,

	CONSTRAINT GOLFMEMBERSLOG_primary_key PRIMARY KEY (MEMBERID),
    CONSTRAINT GOLFMEMBERSLOG_foreign_key FOREIGN KEY (TYPEID) REFERENCES MEMBERTYPES (TYPEID)
);

CREATE TABLE RENEWALS
(
	RENEWALID NUMBER(2) NOT NULL,
	MEMBERID NUMBER(3) NOT NULL,
	AMOUNTPAID NUMBER(5,2) NOT NULL,
	DATEPAID DATE,

	CONSTRAINT RENEWALS_primary_key PRIMARY KEY (RENEWALID),
	CONSTRAINT RENEWALS_foreign_Key FOREIGN KEY (MEMBERID) REFERENCES GOLFMEMBERSLOG (MEMBERID)
);

INSERT INTO COUNTYLIST (COUNTY) VALUES ('Antrim');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Armagh');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Carlow');	
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Cavan');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Clare');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Cork');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Derry');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Donegal');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Down');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Dublin');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Fermanagh');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Galway');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Kerry');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Kildare');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Kilkenny');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Laois');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Leitrim');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Limerick');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Longford');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Louth');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Mayo');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Meath');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Monoghan');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Offaly');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Roscommon');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Sligo');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Tipperary');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Tyrone');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Waterford');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Westmeath');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Wexford');
INSERT INTO COUNTYLIST (COUNTY) VALUES ('Wicklow');

INSERT INTO MEMBERSTATUS (MEMBERSTATUS) VALUES ('Active');
INSERT INTO MEMBERSTATUS (MEMBERSTATUS) VALUES ('Inactive');
INSERT INTO MEMBERSTATUS (MEMBERSTATUS) VALUES ('Removed');

INSERT INTO MEMBERTYPES (TYPEID, TYPENAME, TYPEPRICE) VALUES ('SD','Student', 435.50);

INSERT INTO MEMBERTYPES (TYPEID, TYPENAME, TYPEPRICE) VALUES ('SR','Senior', 532.00);

INSERT INTO MEMBERTYPES (TYPEID, TYPENAME, TYPEPRICE) VALUES ('AD','Adult', 744.90);

INSERT INTO GOLFMEMBERSLOG (MEMBERID, FIRSTNAME, LASTNAME, STREET, TOWN, COUNTY, MOBILE, EMAIL, MEMBERSTATUS, SIGNUPDATE, TYPEID, PAID) 
VALUES (1, 'Light', 'Yagami', '21 Fairbank Avenue', 'Tralee', 'Kerry', '0876663214', 'lighty@deathnote.com', 'Active', SYSDATE, 'SD', 'y');

INSERT INTO GOLFMEMBERSLOG (MEMBERID, FIRSTNAME, LASTNAME, STREET, TOWN, COUNTY, MOBILE, EMAIL, MEMBERSTATUS, SIGNUPDATE, TYPEID, PAID) 
VALUES (2, 'Ryuzaki', 'Lawliet', '12 BlankHouse Street', 'Heuston', 'Dublin', '0835462347', 'ryuzaki@deathnote.com', 'Inactive', SYSDATE, 'AD', 'n');

INSERT INTO GOLFMEMBERSLOG (MEMBERID, FIRSTNAME, LASTNAME, STREET, TOWN, COUNTY, MOBILE, EMAIL, MEMBERSTATUS, SIGNUPDATE, TYPEID, PAID) 
VALUES (3, 'Holo', 'Yiotsu', '34 Wheat Avenue', 'Nenagh', 'Clare', '0934442345', 'holo@spicewolf.com', 'Removed', SYSDATE, 'SR', 'n');

INSERT INTO RENEWALS (RENEWALID, MEMBERID, AMOUNTPAID, DATEPAID)
VALUES (1, 1, 435.50, SYSDATE);

INSERT INTO RENEWALS (RENEWALID, MEMBERID, AMOUNTPAID, DATEPAID)
VALUES (2, 2, 744.90, SYSDATE);

INSERT INTO RENEWALS (RENEWALID, MEMBERID, AMOUNTPAID, DATEPAID)
VALUES (3, 3, 532.00, SYSDATE);

COMMIT;
