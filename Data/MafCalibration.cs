using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data
{
    public class MafCalibration : OutputData
    {
        #region Member Variables

        private Dictionary<float, float> _mafValues = null;

        #endregion

        #region Public Properties

        public Dictionary<float, float> MafValues
        {
            get { return _mafValues; }
            set { _mafValues = value; }
        }

        #endregion

        #region OutputData Overrides

        public override string GetDisplayedOutput()
        {
            StringBuilder result = new StringBuilder();

            foreach (float mafValue in _mafValues.Values)
            {
                result.AppendFormat("{0}\t", mafValue);
            }

            return result.ToString();
        }

        #endregion
    }
}
