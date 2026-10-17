using OSDC.UnitConversion.Conversion.DrillingEngineering;
using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Model;

/// <summary>Discovery projection; excludes engineering arrays and nested definitions.</summary>
public sealed class PhysicalQuantityLight
{
    public string? Name { get; set; }
    public System.Guid? ID { get; set; }
    public string? DescriptionMD { get; set; }
    public string? SIUnitName { get; set; }
    public string? SIUnitLabelLatex { get; set; }
    public double? LengthDimension { get; set; }
    public double? MassDimension { get; set; }
    public double? TimeDimension { get; set; }
    public double? TemperatureDimension { get; set; }
    public double? AmountSubstanceDimension { get; set; }
    public double? ElectricCurrentDimension { get; set; }
    public double? LuminousIntensityDimension { get; set; }
    public double? PlaneAngleDimension { get; set; }
    public double? SolidAngleDimension { get; set; }
    public double? MeaningfulPrecisionInSI { get; set; }
    public string? TypicalSymbol { get; set; }
    public string? SIUnitLabel { get; set; }
    public string? PhysicalDimensionLatex { get; set; }
}

/// <summary>A bounded UUID-ordered page. NextOffset is null on the final page.</summary>
public sealed class PhysicalQuantityDiscoveryPage
{
    public List<PhysicalQuantityLight> Items { get; set; } = new();
    public int Offset { get; set; }
    public int Limit { get; set; }
    public int TotalCount { get; set; }
    public int? NextOffset { get; set; }
}

/// <summary>Discovery projection; excludes engineering arrays and nested definitions.</summary>
public sealed class UnitConversionSetLight
{
    public OSDC.DotnetLibraries.General.DataManagement.MetaInfo? MetaInfo { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public System.DateTimeOffset? CreationDate { get; set; }
    public System.DateTimeOffset? LastModificationDate { get; set; }
}

/// <summary>A bounded UUID-ordered page. NextOffset is null on the final page.</summary>
public sealed class UnitConversionSetDiscoveryPage
{
    public List<UnitConversionSetLight> Items { get; set; } = new();
    public int Offset { get; set; }
    public int Limit { get; set; }
    public int TotalCount { get; set; }
    public int? NextOffset { get; set; }
}

/// <summary>A bounded UUID-ordered page. NextOffset is null on the final page.</summary>
public sealed class UnitSystemDiscoveryPage
{
    public List<UnitSystemLight> Items { get; set; } = new();
    public int Offset { get; set; }
    public int Limit { get; set; }
    public int TotalCount { get; set; }
    public int? NextOffset { get; set; }
}

/// <summary>Discovery projection; excludes engineering arrays and nested definitions.</summary>
public sealed class UnitSystemConversionSetLight
{
    public OSDC.DotnetLibraries.General.DataManagement.MetaInfo? MetaInfo { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public System.DateTimeOffset? CreationDate { get; set; }
    public System.DateTimeOffset? LastModificationDate { get; set; }
    public System.Guid? UnitSystemInID { get; set; }
    public System.Guid? UnitSystemOutID { get; set; }
}

/// <summary>A bounded UUID-ordered page. NextOffset is null on the final page.</summary>
public sealed class UnitSystemConversionSetDiscoveryPage
{
    public List<UnitSystemConversionSetLight> Items { get; set; } = new();
    public int Offset { get; set; }
    public int Limit { get; set; }
    public int TotalCount { get; set; }
    public int? NextOffset { get; set; }
}
