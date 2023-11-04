using Entrega3_Patrones.Business.Entities.Abstractions;
using static Entrega3_Patrones.Business.Enums.Enumerations;

namespace Entrega3_Patrones.Business.Entities
{
    public class Employee : User
    {
        public PositionType Position { get; }
        public DepartmentType Department { get; }

        public Employee(string name, int age, PositionType position, DepartmentType department)
            : base(name, age)
        {
            Position = position;
            Department = department;
        }
    }
}
