using Core.DataAccess;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Absract
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
        //ürüne ait özel operasyonlar için.

        List<EmployeeDetailDto> GetAppointmentEmployeeDetails();
        
    }
}
