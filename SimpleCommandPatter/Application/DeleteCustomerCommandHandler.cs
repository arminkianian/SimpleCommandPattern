using SimpleCommandPatter.Framework;

namespace SimpleCommandPatter.Application
{
    public class DeleteCustomerCommandHandler : ICommandHandler<DeleteCustomerCommand>
    {
        public Task Handle(DeleteCustomerCommand command)
        {
            Console.WriteLine("DeleteCustomerCommand Handled!");
            return Task.CompletedTask;
        }
    }
}
