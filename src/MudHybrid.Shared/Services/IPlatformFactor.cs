namespace MudHybrid.Shared.Services
{
    public interface IPlatformFactor
    {
        public string GetDeviceIdom();
        public string GetPlatform();
    }
}
