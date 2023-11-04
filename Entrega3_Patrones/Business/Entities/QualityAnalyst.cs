using static Entrega3_Patrones.Business.Enums.Enumerations;

namespace Entrega3_Patrones.Business.Entities
{
    internal class QualityAnalyst : Employee
    {
        public string Specialization { get; }

        public QualityAnalyst(string name, int age, string specialization, DepartmentType department)
            : base(name, age, PositionType.QualityAnalyst, department)
        {
            Specialization = specialization;
        }
    }
}
