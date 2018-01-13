
namespace GameGeek.Config
{

    public class ConfigManager
    {
        private static ConfigManager sInstance;

        private ConfigManager()
        {

        }


        public static ConfigManager GetInstance()
        {
            if (sInstance == null)
            {
                sInstance = new ConfigManager();
            }
            return sInstance;
        }
    }
}