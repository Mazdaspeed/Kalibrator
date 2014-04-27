using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class IntakeTempElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Intake Temp. ( F)";

        #endregion

        #region Create Method

        public static IntakeTempElement Create(string value)
        {
            IntakeTempElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new IntakeTempElement()
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
