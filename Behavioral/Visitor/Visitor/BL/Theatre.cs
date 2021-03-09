using Visitor.BL.Abstract;
using Visitor.Visitor.Abstract;

namespace Visitor.BL
{
    public class Theatre : ILocation
    {
        public string Title { get; set; }
        public int CountOfAttractions { get; set; }

        public void Accept(ICityVisitor visitor)
        {
            visitor.VisitTheatre(this);
        }
    }
}
