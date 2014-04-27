using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class SparkAdvanceElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Spark Adv. ()";

        #endregion

        #region Create Method

        public static SparkAdvanceElement Create(string value)
        {
            SparkAdvanceElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new SparkAdvanceElement()
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
