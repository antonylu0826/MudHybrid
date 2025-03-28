using MudHybrid.Shared.Services;

namespace MudHybrid.Client.Services
{
    public class PreferencesFactor : IPreferencesFactor
    {
        public void Set(string key, string? value)
        {
            Preferences.Set(key, value);
        }
    }
}
