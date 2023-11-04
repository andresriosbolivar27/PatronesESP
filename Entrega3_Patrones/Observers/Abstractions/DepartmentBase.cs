using Entrega3_Patrones.Business.Entities;
using Entrega3_Patrones.Business.Entities.Abstractions;

namespace Entrega3_Patrones.Observers.Abstractions
{
    public abstract class DepartmentBase
    {
        protected string name;
        public User Leader { get; }
        private List<Employee> Employees { get; } = new List<Employee>();

        public DepartmentBase(string name, User leader)
        {
            this.name = name;
            Leader = leader;
        }

        public virtual void AssignEmployee(Employee employee)
        {
            Employees.Add(employee);
            Console.WriteLine($"{employee.Name} ha sido asignado a {name}");
        }

        public virtual void ShowEmployees()
        {
            Console.WriteLine($"Empleados en {name}:");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Position} del departamento {name} liderado por {Leader.Name}");
            }
        }
    }
}
