using SimpleCommandPatter.Framework;

namespace SimpleCommandPatter.Application
{
    public class UpdateCustomerCommandHandler : ICommandHandler<UpdateCustomerCommand>
    {
        public Task Handle(UpdateCustomerCommand command)
        {
            Console.WriteLine("UpdateCustomerCommand Handled!");
            return Task.CompletedTask;
        }
    }
}
