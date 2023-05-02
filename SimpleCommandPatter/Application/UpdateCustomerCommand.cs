using SimpleCommandPatter.Framework;

namespace SimpleCommandPatter.Application
{
    public class UpdateCustomerCommand : ICommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
