# Tagebuch
## Larissa Lazau 

### 24.05

#### 17:29 - 19:23
### Projekterstellung und Zielsetzung:
Ich werde mein Karten Spiel mit Unity erstellen.. Mein Ziel für den Anfang wäre, dass es zumindest wie ein Soliatire-Spiel funktionieren sollte. Später möchte ich es soweit
erweitern dass es mehrere Scenes wie Menu und User-Menu hat. Im User-Menu kann man seinen Namen dann eingeben und wird dann später für die Highscores genutzt.

-------
### 26.05

#### 15:00 - 17:23
### Erstellung der Objekte für Solitaire
Ich habe das Projekt gestartet und hab versucht die wichtigsten Objekte und Skripte zu erstellen. Sowie auch die passenden Sprites für die  Karten ausgesucht.

-------
### 01.06

#### 16:00 - 18:30
### Erweiterung
Mithilfe vom Skript Solitaire können sich nun die Karten von selbst zufällig mischen. Sie werden aber noch alle auf dem Deck erstellt.

-------
### 02.06

#### 15:00 - 17:10
### Erweiterung
Die Karten werden jetzt nicht mehr am Deck erstellt sondern erscheinen nun auf den zugeordneten Feldern. jedoch teilen sich die Karten noch nicht auf, denn alle Karten
liegen grade auf einem Feld.

#### 19:00 - 22:00
Jetzt teilen sich alles Karten gerecht auf und nur die erste Karte ist richtig um, alle Karten hinter dieser Karte sind verkehrt rum.

-------
### 04.06

#### 12:00 - 16:00 / 18:00 - 20:00
### Erweiterung
Nun werden die Karten auf dem Deck auch zufällig gemischt. Die Karten können nun angeglickt werden und auf den oberen Feldern plaziert werden. Wie die Karten aufgestapelt
werden hängt von der definierten Reihenfolge ab. Sie können auch nur ausschließlich auf den oberen und unteren Feldern plaziert werden.
Die hinten liegenden Karten können auch nicht mehr angegklickt werden, da sie geblocked worden sind.

-------
### 05.06

#### 14:30 - 18:00
### Abschluss Solitaire
Habe zum Abschluss noch ein Reset Button und einen Timer erstellt. Mit dem reset Button werden alle Karten wieder zum Ursprung plaziert. Und der Timer zählt die Zeit
die man braucht bis man das Spiel gewonnen hat. Wenn man das Spiel neu startet, dann fängt der Timer von neu an zu zählen.

-------
### 11.06

#### 13:00 - 15:00
### Menu
Habe eine neue Scene erstellt und dort drei Buttons erstellt - Play, Last Games, Exit. Mit Play kann man das Spiel starten und kommt direkt in die näschte Scene rein.
In Last Games kommt man nicht in eine andere Scene rein, dort werden alle Highscore drin stehen. Und mit Exit kann man das ganze Spiel beenden.  

-------
### 12.06

#### 10:30 - 11:50
### User-Menu
Im Scene UserMenu kann man durch einen Input seinen Username eingeben. Nach der Eingabe gibt es einen kurzen Delay bevor man man dann in die näschte Scene kommt. 

-------
### 13.06

#### 14:00 - 14:30
### Menu Erweiterung
Ich habe noch zusätlich in jeder Scene ein Back Button erstellt, damit man bequem die Scenes wechseln kann.

-------
### 16.06

#### 12:30 - 18:00
### Datenbank
Mein Spiel mit einer Sqlite Datenbank verbunden - neuer Plugins Folder, mit libraries von Sqlite und Skripte. Nun werden die letzten 8 Gewonnenen Spiele in Last Games angezeigt. Es werden Username, Played Time und Time, wann es gespielen worden ist, gespeichert.



