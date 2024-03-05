using System;
namespace CSharpTools {
  public static class TextTool {
    public static string Reverse(string input) {
      char[] chars = input.ToCharArray();
      Array.Reverse(chars);
      return new string(chars);
    }
  }
}
