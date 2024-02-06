using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvingCredit.Core.Extensions
{
    public static class StringExtension
    {
        public static int ToInt(this string value) {
            int nReturn = 0;
            if (int.TryParse(value, out nReturn))
            {
                return nReturn;
            }
            else
            {
                throw new Exception("String cannot be coverted to integer");
            }
        }
    }
}
