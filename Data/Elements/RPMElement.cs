using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class RPMElement : BaseElement<short>
    {
        #region Constants

        public const string LogPropertyName = "RPM (RPM)";

        #endregion

        #region Create Method

        public static RPMElement Create(string value)
        {
            RPMElement result = null;

            short tempValue;
            if (short.TryParse(value, out tempValue))
            {
                result = new RPMElement()
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
