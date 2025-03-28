namespace MudHybrid.Client.Services
{
    internal class SecureStorageService : Shared.Services.ISecureStorage
    {

        public async Task<string?> GetValueAsync(string key)
        {
            return await SecureStorage.GetAsync(key);
        }

        public async Task RemoveValueAsync(string key)
        {
            SecureStorage.Remove(key);
        }

        public async Task SetValueAsync(string key, string token)
        {
            await SecureStorage.SetAsync(key, token);
        }
    }
}
