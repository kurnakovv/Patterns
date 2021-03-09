using Visitor.Visitor.Abstract;

namespace Visitor.BL.Abstract
{
    public interface ILocation
    {
        void Accept(ICityVisitor visitor);
    }
}
