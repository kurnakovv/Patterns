using Visitor.BL.Abstract;
using Visitor.Visitor.Abstract;

namespace Visitor.BL
{
    public class Restaurant : ILocation
    {
        public string Title { get; set; }
        public int CountOfTables { get; set; }

        public void Accept(ICityVisitor visitor)
        {
            visitor.VisitRestaurant(this);
        }
    }
}
