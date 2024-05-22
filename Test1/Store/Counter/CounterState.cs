namespace Test1.Store.Counter;

/// <summary>
/// VERY IMPORTANT: Propertylarning setterlari bo`lmaydi!!
/// </summary>
public record CounterState
{
    public int CurrentCount { get; init; }
}