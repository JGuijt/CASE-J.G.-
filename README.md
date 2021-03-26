# CASE-J.G.-

Start van EndCase

Repo bestaat uit frontend en backend

Frontend
Op ze zetten met ng serve.
Te bereiken op http://localhost:4200

Geeft momenteel in een tabel weer de doorgestuurde json waarden vanuit de backend.




Backend
Te bereiken op: https://localhost:44354/api/home

Voor de applicatie kan draaien moet er eerst een database aangemaakt worden.

De database is op te zetten met EF Core:
in de Package Manager Console
    I: Add-Migration
   II: Update-Database


De huidige database heeft de naam CursusDb.
De ConnectionString voor de database is te vinden en te wijzigen in appsettings.json
 
 
 
Momenteel bestaat de database uit een Cursussen tabel en een CursusInstanties tabel.
Cursussen bevat:
Id,
Duur,
Titel,
Code

CursusInstanties bevat:
Id,
StartDatum,
CursusId

Momenteel is de database nog leeg.
De beide tabellen zijn te vullen met enkele testwaarden in SSMS. Of handmatig toe te voegen als de situatie daar om vraagt,

DECLARE @CursussenId INT;
INSERT INTO Cursussen (Duur, Titel, Code)
   VALUES (1,'TestCursus1', 'Test1' )

SELECT @CursussenId = SCOPE_IDENTITY();
INSERT INTO CursusInstanties(StartDatum, CursusId)
   VALUES ('2021-01-10', @CursussenId)

INSERT INTO Cursussen (Duur, Titel, Code)
   VALUES (2,'TestCursus2', 'Test2' )

SELECT @CursussenId = SCOPE_IDENTITY();
INSERT INTO CursusInstanties(StartDatum, CursusId)
   VALUES ('2021-01-01', @CursussenId)


   
   





