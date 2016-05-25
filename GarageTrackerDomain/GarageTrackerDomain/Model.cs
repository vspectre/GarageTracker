using System;

namespace GarageTracker.Domain
{
    public class Model
    {
        public int Id { get; }

        public int MakerId { get; }

        public string Name { get; }

        
        public Model(int id, int makerId, string name)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id", id, "model id cannot be negative");
            if (makerId < 0)
                throw new ArgumentOutOfRangeException("makerId", makerId, "maker id cannot be negative");
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name");

            Id = id;
            MakerId = makerId;
            Name = name;
        }
    }
}