using OtpNet;

namespace Kontroller.Helper
{
    public class Otp
    {
        public static bool Check(string key, string pass)
            => pass == (new Totp(Base32Encoding.ToBytes(key))).ComputeTotp();
    }
}