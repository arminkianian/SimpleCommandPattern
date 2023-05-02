using SimpleCommandPatter.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommandPatter.Application
{
    public class CreateCustomerCommand : ICommand
    {
        public string Name { get; set; }
    }
}
