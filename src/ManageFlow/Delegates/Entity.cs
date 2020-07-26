using System;

namespace ManageFlow.Delegates
{
    public class Entity : IEntity
    {
        public int Id { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool Removed { get; set; }
    }
}