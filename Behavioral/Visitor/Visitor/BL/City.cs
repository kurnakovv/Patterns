using System.Collections.Generic;
using Visitor.BL.Abstract;
using Visitor.Visitor.Abstract;

namespace Visitor.BL
{
    public class City
    {
        private readonly ICollection<ILocation> _locations 
            = new List<ILocation>();

        public void Add(ILocation location)
        {
            _locations.Add(location);
        }

        public void Delete(ILocation location)
        {
            _locations.Remove(location);
        }

        public void Accept(ICityVisitor cityVisitor)
        {
            foreach (ILocation location in _locations)
            {
                location.Accept(cityVisitor);
            }
        }
    }
}
