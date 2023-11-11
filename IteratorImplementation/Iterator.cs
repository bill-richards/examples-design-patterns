namespace gsdc.examples.design_patterns.iterator_implementation;


public interface IIterator<TContent>
{
    TContent Current { get; }
    bool MoveNext();
    void Reset();
}


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
