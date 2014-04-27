using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class CalculatedLoadElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Calculated Load (Load)";

        #endregion

        #region Create Method

        public static CalculatedLoadElement Create(string value)
        {
            CalculatedLoadElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new CalculatedLoadElement()
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
