using Entrega3_Patrones.Business.Entities;
using Entrega3_Patrones.Business.Entities.Abstractions;
using Entrega3_Patrones.Strategies.Abstractions;

namespace Entrega3_Patrones.Strategies.Implements
{
    internal class DeveloperEvaluationStrategy : IPerformanceEvaluationStrategy
    {
        public void Evaluate(User user)
        {
            Developer developer = user as Developer;

            if (developer != null)
            {
                Console.WriteLine($"Aplicando estrategia de evaluación para el {developer.Name}");

                if (developer.ProgrammingLanguage.Equals("C#"))
                {
                    Console.WriteLine($"{developer.Name} es experto en C# y contribuye significativamente al desarrollo del proyecto.");
                }
                else
                {
                    Console.WriteLine($"{developer.Name} puede mejorar su desempeño al aprender y utilizar más eficientemente el lenguaje de programación.");
                }
            }
            else
            {
                Console.WriteLine("Error: La estrategia de evaluación de Developer no es aplicable a este tipo de usuario.");
            }
        }
    }
}
