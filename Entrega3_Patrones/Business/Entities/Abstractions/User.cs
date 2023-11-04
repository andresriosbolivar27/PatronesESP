namespace Entrega3_Patrones.Business.Entities.Abstractions
{
    public abstract class User
    {
        public string Name { get; }
        public int Age { get; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
