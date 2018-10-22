using System;
using System.Collections.Generic;
namespace FormsDemo
{
    public static class AppHistory
    {
        static List<string> mAppIds =
            new List<string>();
        public static IEnumerable<string>
            AppIds => mAppIds.ToArray();

        public static void AddApp(string appId) {
            mAppIds.Insert(0, appId);
        }
    }
}
