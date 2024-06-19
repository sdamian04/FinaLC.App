

using FinalCApp.DAL.Interfaces;

namespace FinalCApp.DAL.DAOS
{
    public class EmployeesDb : IDEmployees
    {

        private readonly ShopContext context;

        public EmployeesDb(ShopContext context)
        {
            this.context = context;
        }

        public EmployeesDb GetEmployeesDb(int employeeID)

        { throw new NotImplementedException(); }

        public List<EmployeesModel> GetEmployees();
    }
}
