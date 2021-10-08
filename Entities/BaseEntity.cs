using System;

namespace CoreSchool.Entities
{
    /// 
    /// This base entity will declare the properties UniqueId and Name.
    /// 
    public class BaseEntity
    {
        public string UniqueId { get; protected set; }
        public string Name { get; set; }

        public BaseEntity() => UniqueId = Guid.NewGuid().ToString();
    }
}