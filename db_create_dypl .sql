CREATE TABLE Tsiny (
id  int NOT NULL PRIMARY KEY,
Vyd_z_k VarChar(20) NOT NULL,
Chystka int NOT NULL,
Sushka int NOT NULL
);


CREATE TABLE Prognoz (
Rik int (10) PRIMARY KEY,
Zhyto DOUBLE,
Pshenitsya DOUBLE,
Proso DOUBLE,
Yachmin DOUBLE,
Oves DOUBLE,
Grechyha DOUBLE,
Polba DOUBLE,
Soya DOUBLE,
Fasol DOUBLE,
Goroh DOUBLE
);


CREATE TABLE Zberigannya (
id int NOT NULL PRIMARY KEY,
Vyd_z_k VarChar (10),
Elevator int,
Rukav int,
Angar int
);

