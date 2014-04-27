using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class ThrottlePositionElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Throttle Position (%)";

        #endregion

        #region Create Method

        public static ThrottlePositionElement Create(string value)
        {
            ThrottlePositionElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new ThrottlePositionElement()
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
