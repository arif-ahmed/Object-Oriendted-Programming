using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Example_01.Applied
{
    public class Square : Shape
    {
        public Square(IColor color) : base(color) { }
        public override void Draw()
        {
            color.ApplyColor();
        }
    }
}
