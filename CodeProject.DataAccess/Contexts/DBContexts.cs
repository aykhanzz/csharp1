using CodeProject.Core.Entities;

namespace CodeProject.DataAccess.Contexts;

public static class DBContexts
{
    public static List<Employee> Employees { get; set; } = new();
    public static List<Departament> Departaments { get; set; } = new();
    public static List<Company> Companies { get; set; } = new();
}
