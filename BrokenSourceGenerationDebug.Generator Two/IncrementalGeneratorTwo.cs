using Microsoft.CodeAnalysis;

namespace BrokenSourceGenerationDebug.Generator_Two
{
    [Generator(LanguageNames.CSharp)]
    public class IncrementalGeneratorTwo : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
        }
    }
}
