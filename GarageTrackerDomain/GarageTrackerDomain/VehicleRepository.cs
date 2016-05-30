using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageTracker.Domain
{
    public abstract partial class VehicleRepository
    {
        public abstract void Add(Vehicle vehicle);

        public abstract Vehicle Get(int id);

        public abstract void Update(Vehicle vehicle);

        public abstract Vehicle Remove(int id);
    }
}
