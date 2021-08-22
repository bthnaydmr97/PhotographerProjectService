using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();

        List<Employee> GetAllByEmployeeId(int id);
        Employee GetByAppointment(DateTime date);



    }
}
