using System;
namespace CSharpTools {
  public static class SystemTool {
    public static string GetOSVersion() => Environment.OSVersion.ToString();
    public static int GetProcessorCount() => Environment.ProcessorCount;
  }
}
