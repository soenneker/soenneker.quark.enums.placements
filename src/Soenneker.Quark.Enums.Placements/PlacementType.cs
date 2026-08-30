using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents a placement option exposed by Quark components.
/// </summary>
[EnumValue<string>]
public sealed partial class PlacementType
{
    /// <summary>
    /// Places content at the logical start edge.
    /// </summary>
    public static readonly PlacementType Start = new("start");

    /// <summary>
    /// Places content at the logical end edge.
    /// </summary>
    public static readonly PlacementType End = new("end");

    /// <summary>
    /// Places content at the top edge.
    /// </summary>
    public static readonly PlacementType Top = new("top");

    /// <summary>
    /// Places content at the bottom edge.
    /// </summary>
    public static readonly PlacementType Bottom = new("bottom");
}
