using System;
namespace CSharpTools {
  public static class CryptoTool {
    public static string Base64Encode(string plainText) => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(plainText));
    public static string Base64Decode(string base64EncodedData) => System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(base64EncodedData));
  }
}
