using Entrega3_Patrones.Business.Entities;
using Entrega3_Patrones.Business.Entities.Abstractions;
using Entrega3_Patrones.Strategies.Abstractions;

namespace Entrega3_Patrones.Strategies.Implements
{
    public class QualityAnalystEvaluationStrategy : IPerformanceEvaluationStrategy
    {
        public void Evaluate(User user)
        {
            QualityAnalyst qaAnalyst = user as QualityAnalyst;

            if (qaAnalyst != null)
            {
                Console.WriteLine($"Aplicando estrategia de evaluación para el {qaAnalyst.Name}");
                Console.WriteLine($"{qaAnalyst.Name} se especializa en {qaAnalyst.Specialization} y realiza pruebas funcionales de alta calidad.");
            }
            else
            {
                Console.WriteLine("Error: La estrategia de evaluación de QualityAnalyst no es aplicable a este tipo de usuario.");
            }
        }
    }
}
