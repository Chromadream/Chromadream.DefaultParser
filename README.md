# Chromadream.DefaultParser

An universal parser that returns default value of the target type if parsing failed for any reason (except if the underlying type doesn't have a "Parse" method).

Supports .NET Standard 2.0.

> There is no God up here.
>
> Except me.

## Motivation

An attempt to get around the following pattern

```csharp
DateTime datetime;
string x = "aquickbrownfoxsomethingsomething";
if (DateTime.TryParse(x, var temp))
{
    datetime = temp;
}
else
{
    datetime = new DateTime();
}
```

With the following pattern:

```csharp
DateTime dateTime = DefaultParser.Parse<DateTime>("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")
```

which will guarantee that a new DateTime class to be returned, even if the input is invalid.
