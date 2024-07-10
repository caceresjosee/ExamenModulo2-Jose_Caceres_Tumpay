using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    public interface IEmployeeDepartment : IEmployee
    {
       
        ContractType ContractType { get; set; }
        string GetDepartament();

         Department Department { get; set; }
        void AssignDepartment(Department department);

        //public void SetContractType( ContractType contractType);
    }
}
