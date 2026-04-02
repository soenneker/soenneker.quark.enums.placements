using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// An enumeration for Quark, representing placement.
/// </summary>
[EnumValue<string>]
public sealed partial class PlacementType
{
    public static readonly PlacementType Start = new("start");

    public static readonly PlacementType End = new("end");

    public static readonly PlacementType Top = new("top");

    public static readonly PlacementType Bottom = new("bottom");
}
