using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class KnockRetardElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Knock Retard ()";

        #endregion

        #region Create Method

        public static KnockRetardElement Create(string value)
        {
            KnockRetardElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new KnockRetardElement()
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
