using System.Text.RegularExpressions;
namespace CSharpTools {
  public static class ValidationTool {
    public static bool IsValidEmail(string email) => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
  }
}
