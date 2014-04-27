using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class MAFVoltageElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "MAF Voltage (V)";

        #endregion

        #region Create Method

        public static MAFVoltageElement Create(string value)
        {
            MAFVoltageElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new MAFVoltageElement()
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
