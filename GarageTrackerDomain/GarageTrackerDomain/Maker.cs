using System;

namespace GarageTracker.Domain
{
    public class Maker
    {
        public int Id { get; }

        public string Name { get; }

        public Maker(int id, string name)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id", id, "maker id cannot be negative");

            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name");

            Id = id;
            Name = name;
        }
    }
}