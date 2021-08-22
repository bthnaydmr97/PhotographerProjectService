using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class DailyRecord : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsPaid { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
