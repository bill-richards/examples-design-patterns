[« back](../README.md#do-you-need-to-know-how-to-implement-design-patterns) | [next](../PatternMatching/README.md) | [solution](./) 
# Use the .net Iterator implementation

In this example we make explicit use of the `Iterator` -implemented through `IEnumerable`

```CS
IEnumerable<string> Stars;

IEnumerator<string> iterator = Stars.GetEnumerator();

if (!iterator.MoveNext()) return;

while (iterator.MoveNext()) { /* do something */ }
```

It's quite unusual to use this approach however, and mostly the .net engineer will use the `Iterator` without being fully aware, for example:

```CS
List<string> Stars;         // implements IEnumerable<string>
foreach(var star in Stars)  // uses .GetEnumerator(), iterator.MoveNext(), etc.
{
    /* do something */
}

```