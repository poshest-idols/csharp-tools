using System;
namespace CSharpTools {
  public static class AdvancedTool {
    public static string Encrypt(string input) {
      // Simple encryption logic here
      return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input));
    }
  }
}
