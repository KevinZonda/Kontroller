namespace Kontroller
{
    public static class Config
    {
#if DEBUG
#endif

#if RELEASE
        private static bool _debugMode = false;
#endif
        public static string OtpKey { get; set; }

        public static bool IsDebug { get; set; } = true;
    }
}