using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Surname{ get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
