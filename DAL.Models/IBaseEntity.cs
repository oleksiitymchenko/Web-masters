using System;

namespace DAL.Models
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
    }
}
