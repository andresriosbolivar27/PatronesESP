using Entrega3_Patrones.Business.Entities;
using Entrega3_Patrones.Business.Entities.Abstractions;
using Entrega3_Patrones.Strategies.Abstractions;

namespace Entrega3_Patrones.Strategies.Implements
{
    public class ManagerEvaluationStrategy : IPerformanceEvaluationStrategy
    {
        public void Evaluate(User user)
        {
            Manager manager = user as Manager;

            if (manager != null)
            {
                Console.WriteLine($"Aplicando estrategia de evaluación para {manager.Name}");

                // Lógica específica de la estrategia para Gerente...
                if (manager.TeamSize >= 5)
                {
                    Console.WriteLine($"{manager.Name} tiene un equipo sólido y lidera eficientemente.");
                }
                else
                {
                    Console.WriteLine($"{manager.Name} necesita aumentar el tamaño de su equipo para mejorar su desempeño.");
                }
            }
            else
            {
                Console.WriteLine("Error: La estrategia de evaluación de Manager no es aplicable a este tipo de usuario.");
            }
        }
    }
}
