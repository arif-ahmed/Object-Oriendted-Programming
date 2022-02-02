﻿namespace VisitorPatternDemo.Concept
{
    public class ConcreteComponentA : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
