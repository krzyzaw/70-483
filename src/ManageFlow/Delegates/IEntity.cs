using System;

namespace ManageFlow.Delegates
{
    public interface IEntity
    {
        public int Id { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool Removed { get; set; }
    }
}