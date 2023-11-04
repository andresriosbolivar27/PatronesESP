using Entrega3_Patrones.Business.Entities.Abstractions;

namespace Entrega3_Patrones.Observers.Abstractions
{
    public interface IPerformanceEvaluationContext
    {
        void EvaluateEmployee(User user);
        void AddObserver(INoficatorEvaluation observer);
        void RemoveObserver(INoficatorEvaluation observer);
        void Notify(string mensaje, User user);
    }
}
