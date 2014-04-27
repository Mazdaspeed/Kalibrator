using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class APPElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Accel. Pedal Pos. (%)";

        #endregion

        #region Create Method

        public static APPElement Create(string value)
        {
            APPElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new APPElement()
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
