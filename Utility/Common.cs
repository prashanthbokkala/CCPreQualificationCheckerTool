using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utilities
{
    public class Common
    {
        public static int GetAge(DateTime dateofBirth)
        {
            //DateTime age = new DateTime(PresentYear.Subtract(dob).Ticks);
            return new DateTime(DateTime.Now.Subtract(dateofBirth).Ticks).Year - 1;
        }
    }
}
