using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class AppointmentType :IEntity
    {
        public int Id { get; set; }
        public string  Type { get; set; }
    }
}
