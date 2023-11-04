using static Entrega3_Patrones.Business.Enums.Enumerations;

namespace Entrega3_Patrones.Business.Entities
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; }

        public Developer(string name, int age, string programmingLanguage, DepartmentType department)
            : base(name, age, PositionType.Developer, department)
        {
            ProgrammingLanguage = programmingLanguage;
        }
    }
}
