using Entrega3_Patrones.Business.Entities;
using Entrega3_Patrones.Business.Entities.Abstractions;
using Entrega3_Patrones.Observers.Abstractions;
using static Entrega3_Patrones.Business.Enums.Enumerations;

namespace Entrega3_Patrones.Observers.Implements
{
    public class RequirementsEngineeringDepartment : DepartmentBase, INoficatorEvaluation
    {
        public string Hability { get; }

        public RequirementsEngineeringDepartment(string hability, User leader)
            : base(DepartamentName[DepartmentType.RequirementsEngineering], leader)
        {
            Hability = hability;
        }

        public void Update(string mensaje, User user)
        {
            var employe = user as Employee;

            if (employe!.Department == DepartmentType.RequirementsEngineering)
            {
                Console.WriteLine($"{name} recibe la notificación: {mensaje}");
                if (Leader != null)
                {
                    Console.WriteLine($"Líder de {name}: {Leader.Name}, recibe la notificación: {mensaje}");
                }
            }
        }
    }
}
