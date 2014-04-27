using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class VehicleSpeedElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Vehicle Speed (mph)";

        #endregion

        #region Create Method

        public static VehicleSpeedElement Create(string value)
        {
            VehicleSpeedElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new VehicleSpeedElement()
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
