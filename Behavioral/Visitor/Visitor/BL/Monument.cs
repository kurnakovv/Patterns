using System;
using Visitor.BL.Abstract;
using Visitor.Visitor.Abstract;

namespace Visitor.BL
{
    public class Monument : ILocation
    {
        public string Name { get; set; }
        public DateTime DateOfCreate { get; set; }

        public void Accept(ICityVisitor visitor)
        {
            visitor.VisitMonument(this);
        }
    }
}
