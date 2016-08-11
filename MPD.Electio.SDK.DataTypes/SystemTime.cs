using System;

namespace MPD.Electio.SDK.DataTypes
{
    public class SystemTime
    {
        [ThreadStatic]
        private static Func<DateTime> _dateTimeFunc;

        public static DateTime Now
        {
            get { return _dateTimeFunc?.Invoke() ?? DateTime.Now; }

            set
            {
                _dateTimeFunc = () => value;
            }
        }
    }
}
