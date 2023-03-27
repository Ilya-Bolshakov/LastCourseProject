using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Extensions
{
    public static class EnumExtensions
    {
        public static string GetEnumValue<T>(this T customEnum, int index) where T : Enum
        {
            return ((T)Enum.GetValues(typeof(T)).GetValue(index)).ToString();
        }
    }
}
