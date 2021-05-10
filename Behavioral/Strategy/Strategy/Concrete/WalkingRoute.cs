using Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Strategy.Concrete
{
    public class WalkingRoute : ISearch
    {
        public List<string> RouteSearch(List<string> listPoints)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = listPoints.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                string value = listPoints[k];
                listPoints[k] = listPoints[n];
                listPoints[n] = value;
            }

            return listPoints;
        }
    }
}
