using Microsoft.CodeAnalysis;

namespace BrokenSourceGenerationDebug.GeneratorOne
{
    [Generator(LanguageNames.CSharp)]
    public class IncrementalGeneratorOne : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
        }
    }
}
