using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int min, int max)
        {
            minValue = min;
            maxValue = max;
        }

        public override bool IsValid(object obj)
        {
            return (int)obj >= minValue && (int)obj <= maxValue;
        }
    }
}
