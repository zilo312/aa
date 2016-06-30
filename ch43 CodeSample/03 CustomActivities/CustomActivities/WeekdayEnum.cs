using System;
using System.Drawing.Design;
using System.ComponentModel;

namespace CustomActivities
{
    /// <summary>
    /// An enum that allows you to define a day or set of days
    /// </summary>
    [Flags]
    [Editor(typeof(FlagsEnumEditor), typeof(UITypeEditor))]
    public enum WeekdayEnum : byte
    {
        None = 0x00,
        Sunday = 0x01,
        Monday = 0x02,
        Tuesday = 0x04,
        Wednesday = 0x08,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40
    }
}
