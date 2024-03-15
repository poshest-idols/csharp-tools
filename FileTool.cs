using System;
namespace CSharpTools {
  public static class FileTool {
    public static void WriteToFile(string path, string content) {
      System.IO.File.WriteAllText(path, content);
    }
  }
}
