using System.Collections.Generic;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class FunctionBindingMapGenerator : GeneratorBase
{
    private readonly IEnumerable<FunctionExport> _functionExports;

    private FunctionBindingMapGenerator(string path, GenerationContext context, IEnumerable<FunctionExport> functionExports)
        : base(path, context) => _functionExports = functionExports;

    public static void Generate(string path, GenerationContext context, IEnumerable<FunctionExport> functionExports)
    {
        using var g = new FunctionBindingMapGenerator(path, context, functionExports);
        g.Generate();
    }

    public override IEnumerable<string> Usings()
    {
        yield return "System";
        yield return "System.Collections.Generic";
    }

    protected override void GenerateBody()
    {
        WriteLine("internal static class DynamicallyLoadedBindingMap");

        using (BeginBlock())
        {
            WriteLine("internal static Dictionary<string, string[]> Functions => new Dictionary<string, string[]>");

            using (BeginBlock(true))
            {
                foreach (var libraryGroup in _functionExports
                             .GroupBy(x => x.LibraryName)
                             .OrderBy(x => x.Key))
                {
                    var functions = string.Join(", ", libraryGroup
                        .Select(x => x.Name)
                        .Distinct()
                        .OrderBy(x => x)
                        .Select(x => $"\"{x}\""));
                    WriteLine($"{{\"{libraryGroup.Key}\", new string[] {{ {functions} }} }},");
                }
            }

            WriteLine(";");
        }
    }
}