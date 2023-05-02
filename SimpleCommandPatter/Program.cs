// See https://aka.ms/new-console-template for more information
using SimpleCommandPatter.Application;
using SimpleCommandPatter.Framework;

ICommandBus _bus= new DemoCommandBus();

var createCustomerCommand = new CreateCustomerCommand
{
    Name = "Customer Name"
};

_bus.Dispatch(createCustomerCommand);

Console.WriteLine();