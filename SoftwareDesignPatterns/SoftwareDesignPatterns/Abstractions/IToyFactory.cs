using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Abstractions
{
    public interface IToyFactory
    {
        Toy CreateNew();
    }
}
