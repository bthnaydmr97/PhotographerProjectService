using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class AppoinmentDate : IEntity
    {
        public int Id { get; set; }
        public int AppoinmentId { get; set; }
        public int AppointmentTypeId { get; set; }
        public DateTime Date { get; set; }
    }
}
