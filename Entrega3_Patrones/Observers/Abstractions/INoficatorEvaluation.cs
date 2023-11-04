using Entrega3_Patrones.Business.Entities.Abstractions;

namespace Entrega3_Patrones.Observers.Abstractions
{
    public interface INoficatorEvaluation
    {
        void Update(string mensaje, User user);
    }
}
