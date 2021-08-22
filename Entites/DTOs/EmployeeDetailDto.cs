using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.DTOs
{
    public class EmployeeDetailDto :IDto
    {
        public int AppointmentId { get; set; }
        public string NameAndSurname { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    
    }
}
