INSERT INTO Flight (Flight_ID, Flight_Class, Departure_City, Departure_Time, Available_Seats, Aircraft_ID)
VALUES (1, 'Economy', 'New York', '2024-05-20', 150, 10);

INSERT INTO Flight (Flight_ID, Flight_Class, Departure_City, Departure_Time, Available_Seats, Aircraft_ID)
VALUES (2, 'Business', 'Los Angeles', '2024-05-21', 50, 11);

INSERT INTO Aircraft (Air_ID, Number_of_Seats, Type)
VALUES (101, 200, 'Boeing 737');

INSERT INTO Aircraft (Air_ID, Number_of_Seats, Type)
VALUES (102, 300, 'Airbus');

DELETE FROM Flight
WHERE Flight_ID = 1;

DELETE FROM Flight
WHERE Departure_City = 'Los Angeles';

DELETE FROM Aircraft
WHERE Air_ID = 101;

DELETE FROM Aircraft
WHERE Type = 'Airbus A330';

UPDATE Flight
SET Available_Seats = 140
WHERE Flight_ID = 1;

UPDATE Flight
SET Flight_Class = 'First Class'
WHERE Flight_ID = 2;

UPDATE Aircraft
SET Number_of_Seats = 250
WHERE Air_ID = 101;

UPDATE Aircraft
SET Type = 'Boeing 777'
WHERE Air_ID = 102;


SELECT * FROM Flight

SELECT f.Flight_ID, f.Departure_City, f.Departure_Time, a.Admin_ID, a.First_Name, a.Last_Name
FROM Modify_Flight mf
JOIN Flight f ON mf.Flight_ID = f.Flight_ID
JOIN Admin a ON mf.Admin_ID = a.Admin_ID;

