

namespace Entrega2_Patrones.Bridges.Abstractions
{
    public abstract class Notification
    {
        protected INotificationImplementor implementor;

        public Notification(INotificationImplementor implementor)
        {
            this.implementor = implementor;
        }

        public abstract void Notify(string message);
    }
}
