using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data.Elements
{
    public class BaseElement<T>
    {
        private string _rawValue = null;

        #region Protected Members

        protected string RawValue
        {
            get { return _rawValue; }
            // set { _rawValue = value; } // This one will store the raw string value but eats extra memory
            set { }
        }

        protected T _value = default(T);

        #endregion

        #region Public Properties

        public T Value
        {
            get { return _value; }
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        #endregion
    }
}
