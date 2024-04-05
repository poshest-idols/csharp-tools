using System;
namespace CSharpTools {
  public static class DateTimeTool {
    public static string GetCurrentDate() => DateTime.Now.ToString("yyyy-MM-dd");
    public static string GetCurrentTime() => DateTime.Now.ToString("HH:mm:ss");
  }
}
