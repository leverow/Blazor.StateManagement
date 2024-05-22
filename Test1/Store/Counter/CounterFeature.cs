using Fluxor;

namespace Test1.Store.Counter;

public class CounterFeature : Feature<CounterState>
{
    public override string GetName() => nameof(CounterState);

    protected override CounterState GetInitialState() => new CounterState(){ CurrentCount = 0};
}