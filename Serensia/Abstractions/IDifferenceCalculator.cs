
namespace Serensia.Abstractions
{

    public interface IDifferenceCalculator
    {
        int GetDifferenceScore(ReadOnlySpan<char> left, ReadOnlySpan<char> right);
    }
}

