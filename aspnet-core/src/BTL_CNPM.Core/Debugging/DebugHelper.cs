namespace BTL_CNPM.Debugging
{
    public static class DebugHelper
    {
        public static bool IsDebug
        {
            get
            {
#pragma warning disable
#if DEBUG
                return true;
#endif
                return false;
#pragma warning restore
            }
        }
    }
}
