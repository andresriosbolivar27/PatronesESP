using static Entrega3_Patrones.Business.Enums.Enumerations;

namespace Entrega3_Patrones.Business.Entities
{
    public class Manager : Employee
    {
        public int TeamSize { get; }

        public Manager(string name, int age, int teamSize)
            : base(name, age, PositionType.Manager, DepartmentType.HumanResources)
        {
            TeamSize = teamSize;
        }
    }
}
