using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTask.Lib.Commons
{
    internal static class SystemMessages
    {
        public static List<string> MessageList { get; set; }

        static SystemMessages()
        {
            MessageList = new List<string>
            {
                "found!",
                "not found!",
                "empty",
                "not empty",
            };
        }

    }
}
