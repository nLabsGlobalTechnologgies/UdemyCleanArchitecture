using System.Reflection;

namespace UdemyCleanArchitecture.Application;
public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(Assembly).Assembly;
}
