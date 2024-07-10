using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    public class FullTime :Employee ,IEmployeeDepartment
    {

        public Department Department { get; set; }
        public ContractType ContractType { get; set; }
        public string GetDepartament() 
        {
            return Department.Name;
        }
        public void AssignDepartment(Department department) 
        {
            Department = department;
           
        }

        public FullTime()
        {
            ContractType = ContractType.Planilla;
        }
        public string GetSalarioFijo()
        {
            string salario = "";
            if (string.IsNullOrEmpty(Department.Name))
            {
                new NotImplementedException("Al asignar un departamento, tiene que enviar un departamento valido");
            }
            else
            {
                salario = "5000";
            }
            return salario;
        }
    }
}
