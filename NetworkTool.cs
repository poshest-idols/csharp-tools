using System.Net.NetworkInformation;
namespace CSharpTools {
  public static class NetworkTool {
    public static bool IsNetworkAvailable() => NetworkInterface.GetIsNetworkAvailable();
  }
}
