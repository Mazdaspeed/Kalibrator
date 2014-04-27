using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class BoostAirTempElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Boost Air Temp. ( F)";

        #endregion

        #region Create Method

        public static BoostAirTempElement Create(string value)
        {
            BoostAirTempElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new BoostAirTempElement()
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
