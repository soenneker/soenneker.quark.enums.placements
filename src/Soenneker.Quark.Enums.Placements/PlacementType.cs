using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// An enumeration for Quark, representing placement.
/// </summary>
[EnumValue<string>]
public sealed partial class PlacementType
{
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly PlacementType Start = new("start");

    /// <summary>
    /// The end.
    /// </summary>
    public static readonly PlacementType End = new("end");

    /// <summary>
    /// The top.
    /// </summary>
    public static readonly PlacementType Top = new("top");

    /// <summary>
    /// The bottom.
    /// </summary>
    public static readonly PlacementType Bottom = new("bottom");
}
