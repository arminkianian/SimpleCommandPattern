using SimpleCommandPatter.Framework;

namespace SimpleCommandPatter.Application
{
    public class DeleteCustomerCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}
