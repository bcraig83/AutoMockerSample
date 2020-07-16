namespace Core.Test
{
    public class FooServiceStub : IFooService
    {
        public int Count { get; set; } = 0;

        public void DoFooThing(int number)
        {
            Count += number;
        }
    }
}
