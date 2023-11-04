using Entrega3_Patrones.Business.Entities.Abstractions;
using Entrega3_Patrones.Observers.Abstractions;
using Entrega3_Patrones.Strategies.Abstractions;

namespace Entrega3_Patrones.Observers.Implements
{
    public class PerformanceEvaluator
    {
        private List<INoficatorEvaluation> observers = new List<INoficatorEvaluation>();

        public void AddObserver(INoficatorEvaluation observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(INoficatorEvaluation observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string mensaje, User user)
        {
            Console.WriteLine($"Notificación a todos los observadores: {mensaje}");
            foreach (var observer in observers)
            {
                observer.Update(mensaje, user);
            }
        }

        // Método para simular la evaluación de desempeño
        public void EvaluateEmployee(User user, IPerformanceEvaluationStrategy evaluationStrategy)
        {
            Console.WriteLine($"Iniciando evaluación de desempeño para {user.Name}...");

            // Lógica de evaluación...

            evaluationStrategy.Evaluate(user);
            Console.WriteLine($"Evaluación de desempeño completada para {user.Name}");

            // Notificar a todos los observadores
            Notify($"Evaluación de desempeño completada para {user.Name}", user);

            // Estrategia de evaluación

            Console.WriteLine($"Fin de la evaluación de desempeño para {user.Name}\n");
        }
    }
}
