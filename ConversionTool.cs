using System;
namespace CSharpTools {
  public static class ConversionTool {
    public static int ToInt(string input) => int.TryParse(input, out var result) ? result : 0;
    public static double ToDouble(string input) => double.TryParse(input, out var result) ? result : 0.0;
  }
}
