using Fluxor;

namespace Test1.Store.Counter;

public static class IncrementCounterReducer
{
    //Pure method
    [ReducerMethod]
    //state.CurrentCount++; // Bu ko'rinishda eski stateni o'zgartirishimiz qatiyan man etiladi!!! har doim biz yangi state jo`natishimiz kerak!
    public static CounterState OnAddCounter(CounterState state, IncrementCounterAction action) =>
        state with
        {
            CurrentCount = state.CurrentCount + 1
        };
}