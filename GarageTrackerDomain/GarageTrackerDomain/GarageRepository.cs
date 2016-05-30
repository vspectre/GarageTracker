using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GarageTracker.Domain
{
    public abstract partial class GarageRepository
    {
        public abstract void Add(int vehicleId, IPrincipal owner);

        public abstract void Remove(int vehicleId, IPrincipal owner);

        public abstract void Empty(IPrincipal owner);

        public abstract IEnumerable<Vehicle> GetFor(IPrincipal owner);

        public abstract IEnumerable<Garage> All { get; }
    }
}
