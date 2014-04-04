using System.ComponentModel;

namespace AW.LLBLGen.DataContextDriver
{
  internal static class Constants
  {
    public const string Author = "Jeremy Thomas";
    public const string AssemblyCompany = Author;
    /// <summary>
    /// 4.1
    /// </summary>
    public const string LLBLVersion = "4.1";
    public const string CopyrightYear = "2014";
    public const string LLBLGenNameVersion = "LLBLGen Pro v" + LLBLVersion;
    public const string DriverName = "AW " + LLBLGenNameVersion;
    public const string Name = DriverName + " (v" + Version + ")";
    public const string AssemblyCopyright = "Copyright " + CopyrightYear + " " + Author;
    public const string AssemblyProduct = "AW LLBLGen typed data context driver";
    public const string AssemblyDescription = LLBLGenNameVersion + " LINQPad typed data context driver";
    public const string MajorVersion = "2";
    public const string MinorVersion = "7";
    public const string Version = MajorVersion + "." + MinorVersion;
    public const string AssemblyVersion = Version + ".0.0";
  }

  public enum DisplayInGrid
  {
    [Description("Exclude EntityBase Properties")]
    ExcludeEntityBaseProperties,
    [Description("Default Linqpad behavior")]
    AllProperties,
    [Description("Use the Editable Data Grid included with the driver rather than the LinqPad grid")]
    UseEditableGrid,
    [Description("Use the Editable Data Grid with a page size of 10")]
    UseEditableGridPaged
  }
}