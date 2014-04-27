using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class HPFPElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "HPFP Act. Press. (PSI)";

        #endregion

        #region Create Method

        public static HPFPElement Create(string value)
        {
            HPFPElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new HPFPElement()
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
