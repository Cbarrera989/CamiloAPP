using Xamarin.Essentials;

namespace CamiloAPP.Services
{
    internal class AppUserSettingService : IAppUserSettingService
    {
        private const string USERNAME_KEY = "UserNameKey";
        private const string TOKEN_KEY = "TokenKey";

        public string UserName
        {
            get
            {
                return Preferences.Get(USERNAME_KEY, "");
            }
            set
            {
                Preferences.Set(USERNAME_KEY, value);
            }
        }

        public string UserToken
        {
            get
            {
                return Preferences.Get(TOKEN_KEY, "");
            }
            set
            {
                Preferences.Set(TOKEN_KEY, value);
            }
        }


        public void Clear()
        {
            Preferences.Clear();
        }
    }
}