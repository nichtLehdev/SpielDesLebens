# Spiel des Lebens

## Disclaimer

Dieses Projekt entstand als Projektentwurf der Vorlesung "Grundlagen des Software-Engineering" des Kurses TINF21AI1 an der DHBW Mannheim.

**Sämtliche genannten Personen und Events sind frei erfunden!**

---

This project was part of the lecture "Software-Engineering Basics" at the DHBW (Baden-Wuerttemberg Coorperative State University) Mannheim. The project will be graded and was submitted by a team of 6 people from the course TINF21AI1.

**All named people or events are completely fictional!**

## Projektziel

Durch die Softwarelösung „Spiel des Lebens” wird ermöglicht, dass junge Menschen im Alter von 15 bis 25 Jahren potenzielle Karrierewege spielerisch simulieren können. Durch realitätsnahe Entscheidungen und zugehörige Konsequenzen wird den Anwendern eine realistische Lebenssimulation zwischen dem Schulabschluss und dem Start ins Berufsleben dargestellt.

## Funktionen im Spiel

-  Das Spiel verfügt über 3 Slots für Spielstände, welche zum Speichern und Laden des Spieles dienen.
-  Das Spiel ist Rundenbasiert und ist in folgende Phasen unterteilt:
   -  Bei Studium/Dualem Studium: 3 Monate / Halbes Semester
   -  Bei Ausbildung: 2 Monate
-  Name- und Alterseingabe
   -  Das Alter wird jährlich zu Beginn eines neuen Studien-/Ausbildungsjahres erhöht.
-  Auswahl zwischen folgenden vier Schulabschlüssen:
   -  Berufsbildungsreife (Hauptschulabschluss)
   -  Realschulabschluss
   -  Fachhochschulreife (Fachabitur)
   -  Allgemeine Hochschulreife (Abitur)
-  Auswahl zwischen folgenden Bildungswegen:
   -  Ausbildung
   -  Studium (nur bei Fachabitur & Abitur)
   -  Duales Studium (nur bei Fachabitur & Abitur)
-  Der Spieler hat die Möglichkeiten zwischen folgenden Berufsgruppen zu wählen:
   -  Sozialer Bereich:
      -  Krankenpflege (Ausbildung)
      -  Medizinstudium (Studium)
      -  Angewandte Gesundheits- und Pflegewissenschaften (Duales Studium)
   -  Wirtschaftlicher Bereich:
      -  Industriekaufmann (Ausbildung)
      -  BWL (Studium & Duales Studium)
   -  Naturwissenschaftlicher Bereich / Forschung:
      -  Pharmazeutisch - Technische Assistenz (Ausbildung)
      -  Physikstudium (Studium)
      -  Angewandte Physik (Duales Studium)
   -  STEM-Bereich:
      -  Fachinformatiker (Ausbildung)
      -  Informatikstudium (Studium)
      -  Angewandtes Informatikstudium (Duales Studium)
   -  Öffentlicherer Bereich:
      -  Rechtanwaltsfachangestellter
      -  Jurastudium
      -  Duales Studium Steuerwesen
-  Möglichkeit den ausgewählten Bildungsweg abzubrechen und das Spiel auf diese Weise „neu” zu beginnen. Hierbei bleibt das bereits fortgeschrittene Alter bestehen. Beschränkungen:
   -  Neue Berufsgruppe und/oder neuer Bildungsweg kann nur mit folgenden Werten gestartet werden:
      -  Alter < 55
      -  Geld: > 0
      -  Mental Health: >= 40%
      -  Motivation: >= 25%
      -  Temporäre Einschränkungen: keine
-  Der Spieler erhält jede Phase Aktionspunkte basierend auf der Länge der Phase
   -  Die Anzahl an Punkten berechnet sich aus #𝑃= 𝐿ä𝑛𝑔𝑒 𝑑𝑒𝑟 𝑃ℎ𝑎𝑠𝑒∗7
   -  Verbleibende Aktionspunkte werden am Ende jeder Phase gelöscht
-  In jeder Phase können mit Events und Aktionen interagiert werden.
   1. Events kosten 2 Aktionspunkte
   2. Aktionen kosten 1 Aktionspunkt
   3. Jedes Event hat zwischen 2 und 4 Auswahlmöglichkeiten
   4. Events sind vom ausgewählten Bildungsweg und der ausgewählten Berufsgruppe abhängig.
   5. Eine Liste mit allen Events und Aktionen werden im Laufe der Entwicklung erstellt. 
      - Bisher wurden folgende Events bereits genauer spezifiziert:
         -  In einer Klausur spicken
         -  Treffen eines neuen Schülers
         -  Einladung zu einer Party
         -  Mehr Aufwand in Präsentation/Projekt stecken
      -  Außerdem wurden folgende Aktionen bereits spezifiziert: 
         - Lernen 
         - Ins Kino gehen 
         - Uno mit Familie spielen 
         - Nebenjob
   6. Events haben einen großen Einfluss auf mindestens eine der Statistiken und beeinflussen den weiteren Verlauf der Storyline.
   7. Aktionen benötigen ein Maß an Aufwand in Form mindestens einer der Statistiken, um ein bestmögliches Resultat für 6. zu erzielen.
   8. Aktionen haben einen geringen Einfluss auf mindestens eine der Statistiken.
-  Jede Aktion hat Einfluss auf mindestens eine der Spieler-Attribute

## Technische Spezifikationen

Das Spiel ist in C# mit .NET-Framework und Windows Forms für die Grafikausgabe entwickelt. Es wird .NET-Version 4.8 mit der zugehörigen C#-Version genutzt.
