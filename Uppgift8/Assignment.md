# Uppgift 8
Detta projekt innehåller redan en applikation som bygger på en
abstrakt klass. Läs koden för att förstå vad applikationen gör.
Din uppgift är att skapa två klasser som ärver från den abstrakta
klassen. Se del A och B nedan för mer instruktioner.

Att läsa och förstå den befintliga koden är del av uppgiften. Så
uppgiftsbeskrivningen lämnar en del uppgifter osagda med flit. Det
är upp till dig att förstå koden och hur uppgiften ska lösas.

## A (6p)
Skapa en klass som ärver från den abstrakta klassen och implementerar
den abstrakta metoden så att listan med personer skrivs ut i
console:en. Alla personer som skapats av den abstrakta klassen ska
skrivas ut. Skriv ut personerna på följande format:

* Name ska vara vänsterställt med en minimal bredd på 20 tecken
* Age ska vara högerställt med en minimal bredd på 5 tecken
* Height ska vara högerställd med en minimal bredd på 7 tecken.
  Formatera värdet som en "Fixed-point" med 2 decimaler.

Varje kolumn ska också ha en header.

Ex:
```
Namn                Ålder  Längd
Adam Adamsson          34  165,3
Berit Beritsson       100  140,0
Calle Carlsson         12  190,6
```

Det finns utkommenterad kod i Program.cs som kör igång programmet.
Koden är utkommenterad nu för att den inte fungerar innan du gjort
din lösning. Lägg in din klass på det angivna stället och
avkommentera koden för att testa din lösning.

## B (6p)
Skapa en klass som ärver från den abstrakta klassen och implementerar
den abstrakta metoden så att listan av personer skrivs till en fil.
Filen ska heta persons.txt. Implementera metoden så att filen alltid
skrivs över tidigare versioner av persons.txt.

Formatet i filen ska vara samma som i del A. 11
