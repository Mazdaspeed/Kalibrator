using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class TimeElement : BaseElement<double>
    {
        #region Constants

        public const string LogPropertyName = "Time";

        #endregion

        #region Create Method

        public static TimeElement Create(string value)
        {
            TimeElement result = null;

            double tempValue;
            if (double.TryParse(value, out tempValue))
            {
                result = new TimeElement()
                {
                    _value = tempValue,
                    RawValue = value
                };
            }

            return result;
        }

        #endregion
    }
}
