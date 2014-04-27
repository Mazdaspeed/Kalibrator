using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class STFTElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Short Term FT (%)";

        #endregion

        #region Create Method

        public static STFTElement Create(string value)
        {
            STFTElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new STFTElement()
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
