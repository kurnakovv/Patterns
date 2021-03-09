
using Visitor.BL;

namespace Visitor.Visitor.Abstract
{
    public interface ICityVisitor
    {
        void VisitMonument(Monument monument);
        void VisitTheatre(Theatre theatre);
        void VisitRestaurant(Restaurant restaurant);
    }
}
