
using FinaLC.web.Models;
using FinalCApp.DAL.Entidades;

namespace FinalCApp.DAL.Interfaces
{
    public interface IDEmployees
    {
        List<EmployeesModel> GetEmployees();
        EmployeesModel GetEmployees (int employeeID);
        void SaveEmployees(EmployeesAddModel EmployeesAdd);
        void UpdateEmployees(EmployeesUpdateModel EmployeesAdd);
        void ReEmployees(EmployeesRemoveModel EmployeesAdd);


    }
}
