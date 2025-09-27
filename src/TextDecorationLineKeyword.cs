using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// CSS text decoration keywords in enumeration form.
/// </summary>
[Intellenum<string>]
public partial class TextDecorationLineKeyword
{
    /// <summary>No text decoration.</summary>
    public static readonly TextDecorationLineKeyword None = new("none");

    /// <summary>Draws a line underneath the text.</summary>
    public static readonly TextDecorationLineKeyword Underline = new("underline");

    /// <summary>Draws a line above the text.</summary>
    public static readonly TextDecorationLineKeyword Overline = new("overline");

    /// <summary>Draws a line through the text.</summary>
    public static readonly TextDecorationLineKeyword LineThrough = new("line-through");

    public static implicit operator TextDecorationLineKeyword(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}
