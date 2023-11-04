namespace Entrega3_Patrones.Business.Enums
{
    public class Enumerations
    {
        public enum DepartmentType
        {
            HumanResources,
            DevelopmentFactory,
            RequirementsEngineering // Nueva área
        }

        // Enumeración para las posiciones de los empleados
        public enum PositionType
        {
            Manager,
            Developer,
            QualityAnalyst
        }

        public static Dictionary<DepartmentType, string> DepartamentName =>
            new Dictionary<DepartmentType, string>
            {
            { DepartmentType.DevelopmentFactory, "Fabrica de desarrollo" },
            { DepartmentType.HumanResources, "Recursos humanos" },
            { DepartmentType.RequirementsEngineering, "Ingeniería de Requisitos" }
            };
    }
}
