# windowsforms 


Windows körbar programvara. 

Programspråk
.NET, C#

Dokumenterad kod och metoder 

Beskrivning 
Kökstimer med multipla timers. 
Kan spara en lista av timers.
Programmet har en meny för ny fil, spara och öppna fil. 


## TimerManager för Kök - Kodbeskrivning

Den här koden hanterar en timer-applikation för kök, skriven i C#. Koden använder klassen `TimerManager` för att skapa, hantera och visa information om flera timers.

**Klassens komponenter:**

* `kitchenTimers`: En lista som lagrar `KitchenTimer`-objekt, vilka representerar enskilda timers.
* `currentCount`: En variabel som håller reda på en global räknare (används troligen för att hålla koll på total tid).
* `currentIndex`: En variabel som spårar den index för aktuell vald timer i listan `kitchenTimers`.

**Konstruktor (`TimerManager()`):**

* Initierar listan `kitchenTimers` och sätter värden för `currentCount` och `currentIndex`.

**Egenskaper (`CurrentCount` och `CurrentIndex`):**

* `CurrentCount`: Get- och set-metoder för att hämta och ändra värdet på `currentCount`.
* `CurrentIndex`:
    * Get-metod hämtar värdet på `currentIndex`.
    * Set-metod sätter värdet på `currentIndex` endast om indexet är giltigt (kontrolleras med `CheckIndex` metoden).

**Timerhantering:**

* `SetTimer(KitchenTimer kitchenTimer)`: Lägger till en ny `KitchenTimer` till listan `kitchenTimers`.
* `GetTimer(int index)`: Hämtar ett `KitchenTimer`-objekt från listan baserat på index, returnerar `null` om index är ogiltigt.
* `GetListLength()`: Returnerar antalet element i listan `kitchenTimers`.
* `UpdateTimers()`: Uppdaterar alla timers i listan `kitchenTimers` om deras status är `Running`.
    * Räknar ut minuter och sekunder som gått för varje timer baserat på `currentCount` och startvärden.
    * Uppdaterar värden för minuter och sekunder i `KitchenTimer`-objekten.
    * Sätter status till `Finished` om timerns tid är slut.

**Timerkontroll:**

* `DeleteTimer(int index)`: Tar bort en timer från listan `kitchenTimers` baserat på index (om index är giltigt).
* `PauseTimer(int index)`: Pausar en timer i listan `kitchenTimers` baserat på index (om index är giltigt och timern inte redan är färdig).
    * Sparar aktuella värden för minuter och sekunder i pausad timer.
* `PauseTimers()`: Pausar alla timers i listan `kitchenTimers` (om de inte redan är färdiga).
* `ResumeTimer(int index)`: Återupptar en pausad timer i listan `kitchenTimers` baserat på index (om index är giltigt och timern inte redan är färdig).
    * Sätter status till `Running` och uppdaterar globala räknaren `currentCount` till aktuell tidpunkt.

**Tidjustering:**

* `PlusMinute(int index)`: Ökar antalet minuter för en timer i listan `kitchenTimers` baserat på index (om index är giltigt).
* `MinusMinute(int index)`: Minskar antalet minuter för en timer i listan `kitchenTimers` baserat på index (om index är giltigt och antalet minuter är större än noll).

**Visning:**

* `StopTimer()`: Sätter status till `Stopped` för den valda timern (hämtas med `CurrentIndex`).
* `GetTimerText(int index)`: Returnerar en sträng med formaterad tid (minuter:sekunder) för en timer i listan `kitchenTimers` baserat på index (om index är ogiltigt returneras "00:00").
* `GetKitchenTimerStringsList()`: Returnerar en array med strängar innehållande information om alla timers i listan `kitchenTimers` (minuter, sekunder, beskrivning, status).

**Indexkontroll:**

* `CheckIndex(int index)`: Kontrollerar om ett angivet index finns i listan `kitchenTimers` och returnerar `true` om giltigt, annars `false`.

**Filhantering:**

* `ReadDataFromFile(string fileName)`: Läser data om timers från en fil med hjälp av klassen `FileManager` (antar att denna klass hanterar inläsning).
* `WriteDataToFile(string fileName)`: Skriver data om timers till en fil med hjälp av klassen `FileManager` (antar att denna klass hanterar utskrift).



