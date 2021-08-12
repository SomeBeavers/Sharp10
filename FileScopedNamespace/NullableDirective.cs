#nullable disable
//
namespace FileScopedNamespace; // namespace comment
#nullable enable

/// <summary>
///     comment
/// </summary>
public class NullableDirective
{
    private string? GetString()
    {
        return null;
    }
}