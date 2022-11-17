using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_Sync.Utils
{
    internal class Time
    {

        public static string GetCurrentTime()
        {
            return DateTime.Now.ToShortTimeString();
        }

    }
}
