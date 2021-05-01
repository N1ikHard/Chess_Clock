using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Clock
{
    class BadClock
    {
        int hms;// Сколько времени осталось до конца тайма
        bool paused;
        public BadClock(int hours, int minutes, int seconds)
        {
            hms = 10 * (hours * 3600 + minutes * 60 + seconds);
            paused = false;
        }
        public void StopClock()
        {
            paused = true;
        }
        public void PlayClock()
        {
            paused = false;
        }
        public void TikTakClock()
        {
            if (paused) return;
            hms--;
            if (hms < 0) hms = 0;
        }
        public string ShowClock()
        {
            int h, m, s, ms;
            ms = hms % 10;
            s = hms / 10 % 60;
            m = hms / 10 % 3600 / 60;
            h = hms / 60;
            return h == 0 ? h.ToString("00:") : "" + m.ToString("00") + ":" + s.ToString("00") + "." + ms.ToString();
        }
    }
}

