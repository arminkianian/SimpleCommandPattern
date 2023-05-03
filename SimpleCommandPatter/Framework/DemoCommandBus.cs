using SimpleCommandPatter.Application;

namespace SimpleCommandPatter.Framework
{
    public class DemoCommandBus : ICommandBus
    {
        List<object> _handlers = new List<object>()
        {
            new CreateCustomerCommandHandler(),
            new UpdateCustomerCommandHandler(),
            new DeleteCustomerCommandHandler(),
        };

        public async Task Dispatch<T>(T command) where T : ICommand
        {
            var candidates = _handlers.OfType<ICommandHandler<T>>().ToList();

            foreach (var item in candidates)
            {
                await item.Handle(command);
            }
        }
    }
}
