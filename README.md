[![](https://img.shields.io/nuget/v/soenneker.quark.enums.placements.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.placements/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.placements/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.placements/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.placements/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.placements/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.placements.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.placements/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.placements/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.placements/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.Placements

Strongly typed placement choices shared by Quark component APIs.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.Placements
```

## Usage

```csharp
PlacementType placement = PlacementType.Bottom;
string value = placement.Value; // "bottom"
```

Use `Top` and `Bottom` for vertical placement. Use the logical `Start` and `End` values for horizontal placement so the consuming component can respect its own layout direction.

## Values

| Member | Value |
| --- | --- |
| `Start` | `start` |
| `End` | `end` |
| `Top` | `top` |
| `Bottom` | `bottom` |

This package defines the values only. The component receiving a `PlacementType` determines positioning, collision handling, and right-to-left behavior.
