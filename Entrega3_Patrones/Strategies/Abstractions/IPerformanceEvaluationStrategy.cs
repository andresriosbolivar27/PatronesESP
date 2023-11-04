using Entrega3_Patrones.Business.Entities.Abstractions;

namespace Entrega3_Patrones.Strategies.Abstractions
{
    public interface IPerformanceEvaluationStrategy
    {
        void Evaluate(User user);
    }
}
