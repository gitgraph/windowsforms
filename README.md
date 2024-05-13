# windowsforms 


 Windows executable software.

 Programming language
 .NET, C#

 Documented code and methods

 Description
 Kitchen timer with multiple timers.
 Can save a list of timers.
 The program has a menu for new file, save and open file.


 ## TimerManager for Kitchen - Code description

 This code handles a kitchen timer application, written in C#.  The code uses the `TimerManager` class to create, manage, and display information about multiple timers.

 **Components of the class:**

 * `kitchenTimers`: A list that stores `KitchenTimer` objects, which represent individual timers.
 * `currentCount`: A variable that keeps track of a global counter (probably used to keep track of total time).
 * `currentIndex`: A variable that tracks the index of the currently selected timer in the `kitchenTimers` list.

 **Constructor (`TimerManager()`):**

 * Initializes the `kitchenTimers` list and sets values for `currentCount` and `currentIndex`.

 **Properties (`CurrentCount` and `CurrentIndex`):**

 * `CurrentCount`: Get and set methods to get and change the value of `currentCount`.
 * `CurrentIndex`:
     * Get method retrieves the value of `currentIndex`.
     * Set method sets the value of `currentIndex` only if the index is valid (checked with the `CheckIndex` method).

 **Timer Management:**

 * `SetTimer(KitchenTimer kitchenTimer)`: Adds a new `KitchenTimer` to the `kitchenTimers` list.
 * `GetTimer(int index)`: Gets a `KitchenTimer` object from the list based on index, returns `null` if index is invalid.
 * `GetListLength()`: Returns the number of elements in the `kitchenTimers` list.
 * `UpdateTimers()`: Updates all timers in the `kitchenTimers` list if their status is `Running`.
     * Calculates elapsed minutes and seconds for each timer based on `currentCount` and initial values.
     * Updates values for minutes and seconds in the `KitchenTimer` objects.
     * Sets the status to `Finished' if the timer time is up.

 **Timer Control:**

 * `DeleteTimer(int index)`: Deletes a timer from the `kitchenTimers` list based on index (if index is valid).
 * `PauseTimer(int index)`: Pauses a timer in the `kitchenTimers` list based on index (if index is valid and the timer is not already finished).
     * Saves current values for minutes and seconds in paused timer.
 * `PauseTimers()`: Pauses all timers in the `kitchenTimers` list (if not already finished).
 * `ResumeTimer(int index)`: Resumes a paused timer in the `kitchenTimers` list based on index (if index is valid and the timer has not already finished).
     * Sets the status to `Running` and updates the global counter `currentCount` to the current time.

 **Time adjustment:**

 * `PlusMinute(int index)`: Increases the number of minutes for a timer in the `kitchenTimers` list based on index (if index is valid).
 * `MinusMinute(int index)`: Decreases the number of minutes for a timer in the `kitchenTimers` list based on index (if index is valid and the number of minutes is greater than zero).

 **Viewing:**

 * `StopTimer()`: Sets the status to `Stopped` for the selected timer (retrieved with `CurrentIndex`).
 * `GetTimerText(int index)`: Returns a string with the formatted time (minutes:seconds) of a timer in the `kitchenTimers` list based on index (if index is null, "00:00" is returned).
 * `GetKitchenTimerStringsList()`: Returns an array of strings containing information about all timers in the `kitchenTimers` list (minutes, seconds, description, status).

 **Index Check:**

 * `CheckIndex(int index)`: Checks if a specified index exists in the `kitchenTimers` list and returns `true` if valid, otherwise `false`.

 **File Management:**

 * `ReadDataFromFile(string fileName)`: Reads data about timers from a file using the `FileManager` class (assumes this class handles loading).
 * `WriteDataToFile(string fileName)`: Writes data about timers to a file using the `FileManager` class (assumes this class handles printing).





# windowsforms - Swedish 


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



