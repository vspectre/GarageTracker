using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageTracker.Domain
{
    public abstract class ModelProvider
    {
        public abstract IEnumerable<Maker> All { get; }

        public abstract Maker Get(int id);
    }
}
