using $ext_safeprojectname$.Shared.Services;

namespace $safeprojectname$.Services
{
    public class PlatformFactor : IPlatformFactor
    {
        public string GetDeviceIdom()
        {
            return DeviceInfo.Idiom.ToString();
        }

        public string GetPlatform()
        {
            return DeviceInfo.Platform.ToString() + " - " + DeviceInfo.VersionString;
        }
    }
}
