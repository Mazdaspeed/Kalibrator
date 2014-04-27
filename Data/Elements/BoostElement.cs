using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class BoostElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Boost (PSI)";

        #endregion

        #region Create Method

        public static BoostElement Create(string value)
        {
            BoostElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new BoostElement()
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
