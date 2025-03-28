using $ext_safeprojectname$.Shared.Services;

namespace $safeprojectname$.Services
{
    public class PreferencesFactor : IPreferencesFactor
    {
        public void Set(string key, string? value)
        {
            Preferences.Set(key, value);
        }
    }
}
