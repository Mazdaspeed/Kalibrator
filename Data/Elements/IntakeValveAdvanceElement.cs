using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class IntakeValveAdvanceElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Intake Valve Adv. ()";

        #endregion

        #region Create Method

        public static IntakeValveAdvanceElement Create(string value)
        {
            IntakeValveAdvanceElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new IntakeValveAdvanceElement()
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
