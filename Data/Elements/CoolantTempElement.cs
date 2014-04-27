using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class CoolantTempElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Coolant Temp. ( F)";

        #endregion

        #region Create Method

        public static CoolantTempElement Create(string value)
        {
            CoolantTempElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new CoolantTempElement()
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
