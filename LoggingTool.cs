using System;
namespace CSharpTools {
  public static class LoggingTool {
    public static void Log(string message) {
      Console.WriteLine($"[{DateTime.Now}] {message}");
    }
  }
}
