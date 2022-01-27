using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceWTech.Data.ORM.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
