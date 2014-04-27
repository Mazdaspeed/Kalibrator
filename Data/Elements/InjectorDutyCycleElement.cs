using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class InjectorDutyCycleElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Inj. Duty Cycle (%)";

        #endregion

        #region Create Method

        public static InjectorDutyCycleElement Create(string value)
        {
            InjectorDutyCycleElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new InjectorDutyCycleElement()
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
