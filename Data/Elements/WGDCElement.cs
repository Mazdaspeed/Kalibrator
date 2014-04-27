using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class WGDCElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Wastegate Duty (%)";

        #endregion

        #region Create Method

        public static WGDCElement Create(string value)
        {
            WGDCElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new WGDCElement()
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
