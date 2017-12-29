# DateTimeComparer
Compares C# Datetime with given precision of seconds/minutes/etc

## Installation

Easily installed via nuget:

```
nuget install DateTimeComparer
```

## Notable Upcoming
- include threshold for comparision, ie, "compare these DateTime values within 5 seconds"

## Quick Examples

```c#

  var comparer = new DateTimeComparer(DateTimeComparer.Precision.Minutes);
  
  DateTime left = DateTime.Parse("2015-Jan-01 03:00:00");
  DateTime right = DateTime.Parse("2015-Jan-01 03:00:30");
  
  Console.WriteLine("comparer.Compare(left,right) = {0}", comparer.Compare(left, right));
```

## Notes

Original code adapted from somewhere, cant remember exactly.

