using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class AbsolutePressureElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Abs. Press. (PSI)";

        #endregion

        #region Create Method

        public static AbsolutePressureElement Create(string value)
        {
            AbsolutePressureElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new AbsolutePressureElement()
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
