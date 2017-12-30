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

## Contributing

First of all, thanks! Send a pull request to the dev branch of this repo.  It'll get a quick review then merged to master, then tagged.  A tag is what actually generates a formal release into GitHub releases and to the Nuget Gallery.
