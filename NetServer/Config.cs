namespace Kontroller
{
    public static class Config
    {
        private static string _otpKey;

#if DEBUG
        private static bool _debugMode = true;
#endif

#if RELEASE
        private static bool _debugMode = false;
#endif
        public static string OtpKey
        {
            get => _otpKey;
            set => _otpKey = value;
        }

        public static bool IsDebug
        {
            get => _debugMode;
            set => _debugMode = value;
        }
    }
}