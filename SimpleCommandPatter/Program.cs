// See https://aka.ms/new-console-template for more information
using Autofac;
using SimpleCommandPatter.Application;
using SimpleCommandPatter.Framework;

IContainer BuildContainer()
{
    var builder = new ContainerBuilder();

    builder.RegisterAssemblyTypes(typeof(Program).Assembly)
        .As(type => type.GetInterfaces()
        .Where(interfaceType => interfaceType.IsClosedTypeOf(typeof(ICommandHandler<>))))
        .InstancePerLifetimeScope();

    builder.RegisterType<AutofacCommandBus>().As<ICommandBus>().SingleInstance();

    return builder.Build();
}

//ICommandBus _bus = new DemoCommandBus();

var container = BuildContainer();
var _bus = container.Resolve<ICommandBus>();

var createCustomerCommand = new CreateCustomerCommand
{
    Name = "Customer Name"
};

_bus.Dispatch(createCustomerCommand);

var updateCustomerCommand = new UpdateCustomerCommand
{
    Name = "Customer Name"
};

_bus.Dispatch(updateCustomerCommand);

var deleteCustomerCommand = new DeleteCustomerCommand
{
    Id = Guid.NewGuid(),
};

_bus.Dispatch(deleteCustomerCommand);


Console.WriteLine();