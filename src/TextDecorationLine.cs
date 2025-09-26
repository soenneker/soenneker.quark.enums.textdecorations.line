using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// CSS text decoration keywords in enumeration form.
/// </summary>
[Intellenum<string>]
public partial class TextDecorationLine
{
    /// <summary>No text decoration.</summary>
    public static readonly TextDecorationLine None = new("none");

    /// <summary>Draws a line underneath the text.</summary>
    public static readonly TextDecorationLine Underline = new("underline");

    /// <summary>Draws a line above the text.</summary>
    public static readonly TextDecorationLine Overline = new("overline");

    /// <summary>Draws a line through the text.</summary>
    public static readonly TextDecorationLine LineThrough = new("line-through");

    public static implicit operator TextDecorationLine(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}