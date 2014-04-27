using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class MassAirflowElement : BaseElement<float>
    {
        #region Constants

        public const string LogPropertyName = "Mass Airflow (g/s)";

        #endregion

        #region Create Method

        public static MassAirflowElement Create(string value)
        {
            MassAirflowElement result = null;

            float tempValue;
            if (float.TryParse(value, out tempValue))
            {
                result = new MassAirflowElement()
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
