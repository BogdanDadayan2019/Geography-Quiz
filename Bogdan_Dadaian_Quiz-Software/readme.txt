Quiz Software – Länder-Quiz

Beschreibung:
Spiel ein Länder-Quiz mit Fragen zu Hauptstädten und Flaggen. Spieler können Punkte sammeln, sich registrieren und ihre Ranglisten einsehen.

System:

Windows
.NET Framework (WinForms)
MySQL-Datenbank "quiz"
MySql.Data Bibliothek

Wichtigste Dateien:

Länder.cs: Land mit Name, Hauptstadt, Flagge, Kontinent
Spieler.cs: Spielername und Punkte
SpielErgebnis.cs: Punkte und Datum
Datenbank.cs: Datenbankzugriff
QuizConfig.cs: Lädt Einstellungen aus quiz.ini

LoginForm.cs: Formular zur Anmeldung bestehender Spieler.
RegistrationForm.cs : Formular zur Registrierung neuer Spieler.
StartForm.cs: Hauptmenü zum Starten des Quiz und Navigieren zu anderen Bereichen.
QuizForm.cs: Das Quiz selbst mit Fragen und Antwortmöglichkeiten.
FinalForm.cs: Anzeige Spielergebnis
RatingForm.cs: Ranglistenanzeige

Bilder-Ordner (img):
Dieser Ordner enthält die Bilddateien der Länderflaggen, die im Quiz angezeigt werden. Die Pfade zu den Bildern sind in der Datenbank in der Spalte flagge_img_weg gespeichert, z.B.:
img/Deutschland-flag.png

quiz.ini Beispiel:
fragetyp = hauptstadt_zu_flagge  
kontinent = Weltweit  
anzahl_fragen = 10  

MySQL-Datenbank erstellen:

CREATE DATABASE quiz;
USE quiz;

CREATE TABLE laender (
  id_land INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(50) NOT NULL,
  hauptstadt VARCHAR(50) NOT NULL,
  flagge_img_weg VARCHAR(255),
  kontinent VARCHAR(50)
);

CREATE TABLE spieler (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(255) NOT NULL UNIQUE,
  punkten_max INT NOT NULL DEFAULT 0
);

CREATE TABLE spiel_ergebnisse (
  id INT AUTO_INCREMENT PRIMARY KEY,
  spieler_name VARCHAR(255),
  punkte INT,
  datum DATETIME,
  FOREIGN KEY (spieler_name) REFERENCES spieler(name)
);

INSERT INTO laender (name, hauptstadt, flagge_img_weg, kontinent) VALUES
('Deutschland', 'Berlin', 'img/Deutschland-flag.png', 'Europa'),
('Frankreich', 'Paris', 'img/Frankreich-flag.png', 'Europa'),
('Italien', 'Rom', 'img/Italien-flag.png', 'Europa'),
('Spanien', 'Madrid', 'img/Spanien-flag.png', 'Europa'),
('Schweden', 'Stockholm', 'img/Schweden-flag.png', 'Europa'),
('China', 'Peking', 'img/China-flag.png', 'Asien'),
('Japan', 'Tokio', 'img/Japan-flag.png', 'Asien'),
('Indien', 'Neu-Delhi', 'img/Indien-flag.png', 'Asien'),
('Südkorea', 'Seoul', 'img/Südkorea-flag.png', 'Asien'),
('Türkei', 'Ankara', 'img/Türkei-flag.png', 'Asien'),
('Ägypten', 'Kairo', 'img/Ägypten-flag.png', 'Afrika'),
('Südafrika', 'Pretoria', 'img/Südafrika-flag.png', 'Afrika'),
('Nigeria', 'Abuja', 'img/Nigeria-flag.png', 'Afrika'),
('Kenia', 'Nairobi', 'img/Kenia-flag.png', 'Afrika'),
('Marokko', 'Rabat', 'img/Marokko-flag.png', 'Afrika');


Installation & Nutzung:

MySQL starten und obige Datenbank + Tabellen erstellen

Verbindungsdaten in Datenbank.cs prüfen

quiz.ini anpassen

Anwendung starten, registrieren und spielen

Autor: Bogdan Dadaian