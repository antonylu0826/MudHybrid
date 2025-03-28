using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using MudHybrid.Shared.Services;
using System.Security.Cryptography;

namespace MudHybrid.Web.Services
{
    public class ProtectedLocalStorageService : ISecureStorage
    {
        readonly ProtectedLocalStorage LocalStorage;
        public ProtectedLocalStorageService(ProtectedLocalStorage localStorage)
        {
            LocalStorage = localStorage;
        }

        public async Task<string?> GetValueAsync(string key)
        {
            try
            {
                var token = await LocalStorage.GetAsync<string>(key);
                if (token.Success && token.Value != default)
                {
                    return token.Value;
                }
            }
            catch (CryptographicException)
            {
                await LocalStorage.DeleteAsync(key);
            }
            return null;
        }

        public async Task RemoveValueAsync(string key)
        {
            await LocalStorage.DeleteAsync(key);
        }

        public async Task SetValueAsync(string key, string token)
        {
            await LocalStorage.SetAsync(key, token);
        }
    }
}
