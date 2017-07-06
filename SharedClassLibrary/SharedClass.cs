using System;

namespace SharedClassLibrary
{
    public static class SharedClass
    {
        public static string GetCurrentAssemblyLocation()
        {
            try
            {
                return System.Reflection.Assembly.GetEntryAssembly()
    .Location;
            }
            catch (Exception)
            {
                return "this platform doesn't support this function";
            }


        }
    }
}
