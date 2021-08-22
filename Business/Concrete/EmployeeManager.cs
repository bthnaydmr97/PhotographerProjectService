using Business.Abstract;
using DataAccess.Absract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        //Injection
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public List<Employee> GetAllByEmployeeId(int id)
        {
            return _employeeDal.GetAll(e => e.Id == id);
        }

        public Employee GetByAppointment(DateTime date)
        {
            return _employeeDal.Get(e => e.CreatedOn == date);
        }
    }
}
