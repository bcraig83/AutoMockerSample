namespace Core
{
    public class BarService : IBarService
    {
        private readonly IFooService _fooService;

        public BarService(IFooService fooService)
        {
            _fooService = fooService;
        }

        public void DoBarThing()
        {
            for (int i = 0; i < 10; i++)
            {
                _fooService.DoFooThing(i);
            }
        }
    }
}
