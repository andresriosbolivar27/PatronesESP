using Entrega3_Patrones.Business.Entities;
using Entrega3_Patrones.Business.Entities.Abstractions;
using Entrega3_Patrones.Observers.Implements;
using Entrega3_Patrones.Strategies.Abstractions;
using Entrega3_Patrones.Strategies.Implements;
using static Entrega3_Patrones.Business.Enums.Enumerations;

namespace Entrega3_Patrones
{
    public class Program
    {
        static void Main()
        {
            var printer = new PrinterHelper();
            printer.ImprimirSeparador();
            Console.WriteLine("Bienvenido al Sistema de Evaluación de Desempeño");
            printer.ImprimirSeparador().ImprimirSaltoLinea();
            PerformanceEvaluator evaluator = new PerformanceEvaluator();

            User hrLeader = new Manager("Líder HR", 45, 0);
            User desarrolloLeader = new Manager("Líder Desarrollo", 40, 0);
            User ingenieriaRequisitosLeader = new Manager("Líder Ingeniería de Requisitos", 38, 0);
            QualityAnalyst qaAnalyst = new QualityAnalyst("Analista de Calidad", 30, "Functional Testing", DepartmentType.DevelopmentFactory);
            Manager manager = new Manager("Gerente A", 35, 10);
            Developer developer = new Developer("Desarrollador B", 28, "C#", DepartmentType.DevelopmentFactory);

            HumanResourcesDepartment hrDepartment = new HumanResourcesDepartment("Contratación y Desarrollo", hrLeader);
            DevelopmentFactoryDepartment desarrolloDepartment = new DevelopmentFactoryDepartment("C# y .NET", desarrolloLeader);
            RequirementsEngineeringDepartment ingenieriaRequisitosDepartment = new RequirementsEngineeringDepartment("Pruebas Unitarias", ingenieriaRequisitosLeader);

            evaluator.AddObserver(hrDepartment);
            evaluator.AddObserver(desarrolloDepartment);
            evaluator.AddObserver(ingenieriaRequisitosDepartment);
            
            printer.ImprimirSeparador();
            hrDepartment.AssignEmployee(manager);
            printer.ImprimirSeparador();
            desarrolloDepartment.AssignEmployee(developer);
            printer.ImprimirSeparador();
            ingenieriaRequisitosDepartment.AssignEmployee(qaAnalyst);
            printer.ImprimirSeparador().ImprimirSaltoLinea();

            printer.ImprimirSeparador();
            hrDepartment.ShowEmployees();
            printer.ImprimirSeparador();
            desarrolloDepartment.ShowEmployees();
            printer.ImprimirSeparador();
            ingenieriaRequisitosDepartment.ShowEmployees();
            printer.ImprimirSeparador().ImprimirSaltoLinea();

            IPerformanceEvaluationStrategy managerEvaluationStrategy = new ManagerEvaluationStrategy();
            IPerformanceEvaluationStrategy developerEvaluationStrategy = new DeveloperEvaluationStrategy();
            IPerformanceEvaluationStrategy qaAnalystEvaluationStrategy = new QualityAnalystEvaluationStrategy();
            
            printer.ImprimirSeparador();
            evaluator.EvaluateEmployee(manager, managerEvaluationStrategy);
            printer.ImprimirSeparador();
            evaluator.EvaluateEmployee(developer, developerEvaluationStrategy);
            printer.ImprimirSeparador();
            evaluator.EvaluateEmployee(qaAnalyst, qaAnalystEvaluationStrategy);
            printer.ImprimirSeparador();
        }
    }    
}