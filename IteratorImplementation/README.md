[« back](../README.md#do-you-need-to-know-how-to-implement-design-patterns) | [solution](./)
# The Iterator Pattern

## Interface
```CS
public interface IIterator<TContent>
{
    TContent Current { get; }
    bool MoveNext();
    void Reset();
}
```
You might recognize this interface, after all it is pretty much what the .net BCL provides with `IEnumerator`: so why then, would we want to roll out our own? (I'll discuss that later in the [Benchmarks](../Benchmarks/README.md) project).

It is not essential to provide an interface when implementing the Iterator pattern.

## Implementation
This is the quintessential `Iterator` implementation. There's not much to it, and it's pretty straight forward: It's purpose is to enable us to iterate over a collection of objects. The pattern itself says nothing about type-safety, but that is something which we can achieve by taking advantage of `.net Generics`, so it makes perfect sense for us to do that -everything that makes our lives easier is good, right?

```CS
public class Iterator<TContent> : IIterator<TContent>
{
    private readonly TContent[]? _content;
    private readonly int _maxIndex;
    private int _index = -1;

    public Iterator(TContent[] range)
    {
        _content = range;
        _maxIndex = _content is null ? -1 : _content.Length + _index;
    }

    public TContent Current => _content![_index];

    public bool MoveNext()
    {
        if(_index < _maxIndex)
        {
            _index++;
            return true;
        }

        return false;
    }

    public void Reset() => _index = -1;
}
```