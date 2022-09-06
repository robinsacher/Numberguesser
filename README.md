# Projekt-Dokumentation

Sacher

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|    23.08.2022   | 0.0.1 | Heute habe ich mein Projekt teilweise geplant |
|    27.08.2022   | 0.0.2 | Heute habe ich meinen Numberguesser realisiert |                                                       |
|    06.09.2022   | 0.0.3 | Heute hab eich eine Stopuhr implementiert, welche die Zeit misst bis die richtige Zahl eingegeben wurde und die Funktion hinzugefügt, dass der Spieler seinen Zahlenbereich in dem er spielen möchte selbst bestimmen kann.  |                                

## 1 Informieren

### 1.1 Ihr Projekt

In meinem Projekt will ich einen Numberguesser programmieren, in dem die Zeit gestoppt wird die man braucht bis man die richtige Zahl erraten hat.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    Muss         |    Funktionale Anforderung                | Als Spieler möchte ich eine Zahl zwischen 0 und 100 eingeben können, damit ich gewinnen kann.|
| 2    |       kann      |    Qualitätsanforderung                   |   Als Spieler möchte ich die Zeit, die ich benötigt habe sehen,damit ich weis, wann ich mich verbessert habe.|
| 3    |       kann     |  Qualitätsanforderung   |Als Spieler möchte ich wenn ich die Zahl richtig erraten habe, einen kleinen Text angezeigt bekommen der sagt das ich gewonnen habe.|
|4| Muss| Funktionale Anforderung | Ich als Spieler möcht eden Zahlenbereich in dem ich spiele selber festlegen könnem.|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|1.1   | Programm wird gestartet | 
|1.2 |  Programm wird gestartet | eine Zahl | Text welcher sagt, dass meine Zahl zu tief ist. |
| 1.3  |      Programm wird gestartet      | Zahl wird eingegeben         |  Text welcher sagt, dass meine Zahl zu hoch ist. |
| 1.4| Programm wird gestartet |eine Zahl wird eingegeben | Eint Text welcher sagt, dass meine Zahl richtig ist
| 1.5  |      Programm wird gestartet         |  Zahl und Enter  |        Stoppuhr wird gestartet und zählt so lange die Zeit, bis die Zahl richtig eingegeben wurde, dann setzt sie sich zurück.       |
|1.6| Stoppuhr ist am laufen | Enter | Stoppuhr wird beendet und zeigt Zeit an. |
| 1.7|Programm wird gestarrtet |Zahlenbereich in dem man spielen möchte | Erstellt eine random zahl zwischen 1 und deiner Eingabe |




### 1.4 Diagramme

<img width="629" alt="image" src="https://user-images.githubusercontent.com/110891559/186109925-6686c3bb-1996-4fef-be36-e315830bf7e4.png">


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 2022.08.23 11:30 Uhr      |   Sacher  | Planung des Projektes             |   2 Stunden|
| 1.B |     2022.08.30 11:30 | Sacher          |   Progarmmieren von meinem Numberguesser         |     2 Stunden          |
|1.C | 2022.08.30. 11:30 | Sacher | Stoppuhr implementieren| 1 Stunde|
|1.D | 2022.09.06 | Sacher | frei wählbarer Zahlenbereich implemeniert | 30 Minuten|

Total: 



## 3 Entscheiden
Ich habe mich dazu entschieden eine Stoppuhr zu implementieren 
Ich habe mich dazu entschieden, dass der Spieler seinen Zahlenbereich in dem er spielen möcht eselbst bestimmen kann.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  27.08.2022 | Sacher | 2 Stunden  |         1 Stunde 30 Minuten |
| 1.B  |  30.08.2022 | Sacher | 1 Stunde   |     1 Stunde 30 Minuten     |
|1.C   |  06.09.2022 | Sacher | 30 Minuten | 1 Stunde | 30 Minuten       |
|1.D   |  06.09.2022 | Sacher | 30 Minuten | noch in bearbeitung         |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 30.08.2022  |  Wenn richtig steht trotzdem Zahl zu niedrig    |     Sacher   |
| 1.2  |     06.09.2022  |     Alles funktioniert so wie es soll     |   Sacher     |

Fazit: Mein Projekt war meiner meinung sehr erfolgreicht, nicht nur weil Alles so funktioniert wie es soll, sondern auch, weil ich persöhnlich sehr viel dabei gelernt habe.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
