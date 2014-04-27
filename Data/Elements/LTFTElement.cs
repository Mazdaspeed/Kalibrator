using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class LTFTElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Long Term FT (%)";

        #endregion

        #region Create Method

        public static LTFTElement Create(string value)
        {
            LTFTElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new LTFTElement()
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
