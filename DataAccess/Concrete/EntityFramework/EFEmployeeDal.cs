using Core.DataAccess.EntityFramework;
using DataAccess.Absract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFEmployeeDal : EntityRepositoryBase<Employee, PhotographerContext>, IEmployeeDal
    {
        public List<EmployeeDetailDto> GetAppointmentEmployeeDetails()
        {
            using (PhotographerContext context = new PhotographerContext())
            {
                var data = from e in context.Employees
                           join x in context.EmployeeWorks
                           on e. // TODO
                            select new EmployeeDetailDto
                            {

                            };

                return data.Tolist();

            }
        }
    }
}
