using System;

namespace SubtitlesSync {
    public class Parse {
        public static long GetMillis(int h, int m, int s, int ms) {
            return ((h * 60 + m) * 60 + s) * 1000 + ms;
        }

        public static string GetTime(long ms) {
            var ts = TimeSpan.FromMilliseconds(ms);
            return $"{ts.Hours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2},{ts.Milliseconds:D3}";
        }
    }
}
