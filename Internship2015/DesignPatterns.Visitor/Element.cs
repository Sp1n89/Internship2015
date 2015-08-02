﻿namespace DesignPatterns.Visitor
{
    public class Element : IElement
    {
        public Element Next { get; set; }
        public Element Link { get; set; }

        public Element()
        {
            
        }

        public Element(Element next)
        {
            Next = next;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}