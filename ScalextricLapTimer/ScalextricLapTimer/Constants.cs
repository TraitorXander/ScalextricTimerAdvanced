using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalextricLapTimer
{
    public static class Constants
    {
        public const string APP_NAME = "Scalextric Lap Timer";
        public const string APP_VERSION = "0.0.0.1";

        public static readonly string[] BaudRates =
        {
            "4800",
            "9600",
            "19200",
            "38400"
        };

        public const char MSG_DELIM = ' ';
    }
}
