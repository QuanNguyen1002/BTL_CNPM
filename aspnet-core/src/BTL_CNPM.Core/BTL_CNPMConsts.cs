using BTL_CNPM.Debugging;

namespace BTL_CNPM
{
    public class BTL_CNPMConsts
    {
        public const string LocalizationSourceName = "BTL_CNPM";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "35a86ccd32664f89a4adb6d069fa559f";
    }
}
