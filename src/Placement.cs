using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// An enumeration for Quark, representing placement.
/// </summary>
[Intellenum<string>]
public sealed partial class Placement
{
    public static readonly Placement Start = new("start");

    public static readonly Placement End = new("end");

    public static readonly Placement Top = new("top");

    public static readonly Placement Bottom = new("bottom");
}
