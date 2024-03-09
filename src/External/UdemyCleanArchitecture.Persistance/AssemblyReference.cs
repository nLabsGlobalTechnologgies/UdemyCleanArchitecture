using System.Reflection;

namespace UdemyCleanArchitecture.Persistance;
public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(Assembly).Assembly;
}
