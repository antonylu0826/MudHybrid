using $ext_safeprojectname$.Shared.Services;

namespace $safeprojectname$.Services
{
    public class PlatformFactor : IPlatformFactor
    {
        public string GetDeviceIdom()
        {
            return "Web";
        }

        public string GetPlatform()
        {
            return Environment.OSVersion.ToString();
        }
    }
}
