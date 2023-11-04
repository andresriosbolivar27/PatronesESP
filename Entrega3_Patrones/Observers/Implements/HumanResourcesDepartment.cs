using Entrega3_Patrones.Business.Entities;
using Entrega3_Patrones.Business.Entities.Abstractions;
using Entrega3_Patrones.Observers.Abstractions;
using static Entrega3_Patrones.Business.Enums.Enumerations;

namespace Entrega3_Patrones.Observers.Implements
{
    public class HumanResourcesDepartment : DepartmentBase, INoficatorEvaluation
    {
        public string Specialization { get; }

        public HumanResourcesDepartment(string specialization, User leader)
            : base(DepartamentName[DepartmentType.HumanResources], leader)
        {
            Specialization = specialization;
        }

        public void Update(string mensaje, User user)
        {
            var employe = user as Employee;

            if (employe!.Department == DepartmentType.HumanResources)
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
