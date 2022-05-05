namespace test
{
    internal class Configuration
    {

        private static object _lock = new object();
        private static Configuration _instance = null;
        // game properties Configuration
        public int _windowLeftBorder { get; set; } = 30;
        public int _windowRightBorder { get; set; } = 650;
        public int _bottonBorder { get; set; } = 800;
        public int _skyBorder { get; set; } = 0;
        // Rocket properties Configuration
        public int _rocketSpeed { get; set; } = 13;
        // Asteroid properties Configuration

        private Configuration()
        {

        }
        public static Configuration Get()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Configuration();
                }
            }
            return _instance;
        }
    }
}
