using SimpleCommandPatter.Framework;

namespace SimpleCommandPatter.Application
{
    public class CreateCustomerCommandHandler : ICommandHandler<CreateCustomerCommand>
    {
        public Task Handle(CreateCustomerCommand command)
        {
            Console.WriteLine("CreateCustomerCommand Handled!");
            return Task.CompletedTask;
        }
    }
}
