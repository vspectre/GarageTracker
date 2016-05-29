using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GarageTracker.Domain
{
    public class Garage
    {
        public IPrincipal Owner { get; private set; }

        public IList<Vehicle> Vehicles { get; private set; }

        public Garage(IPrincipal owner)
        {
            if (owner == null)
                throw new ArgumentNullException("owner");

            Owner = owner;
            Vehicles = new List<Vehicle>();
        }
    }
}
