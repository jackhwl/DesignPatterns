IEnumerable - container role
IEnumerator - iterator role
list of data consume large amount memory
use term sequence intstead of collection
yield to replace List<int> and iterator, turn collection to sequence, lower down memory consumption

yield keyword Produces sequences without having the underlying collection
Sequences Decouple collection from iteration
if we don't use a concrete collection, then we can save a lot of memory The code may also become shorter and easier to understand

infinite sequences - When there is no underlying collection, sequence may run forever
C# lets us process long sequences without using much memory

