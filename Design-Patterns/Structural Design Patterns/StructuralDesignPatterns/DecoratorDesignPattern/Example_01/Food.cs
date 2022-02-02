using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Example_01
{
    public abstract class Food
    {
        public abstract string Description();
        public abstract double Cost();
    }
}
