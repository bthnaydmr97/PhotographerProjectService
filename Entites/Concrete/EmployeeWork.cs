using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class EmployeeWork : IEntity
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public int TypeId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
