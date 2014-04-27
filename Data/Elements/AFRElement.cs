using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class AFRElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Actual AFR (AFR)";

        #endregion

        #region Create Method

        public static AFRElement Create(string value)
        {
            AFRElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new AFRElement()
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
