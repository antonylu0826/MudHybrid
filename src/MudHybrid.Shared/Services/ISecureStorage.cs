namespace MudHybrid.Shared.Services
{
    public interface ISecureStorage
    {
        public Task<string?> GetValueAsync(string key);

        public Task SetValueAsync(string key, string token);

        public Task RemoveValueAsync(string key);
    }
}
