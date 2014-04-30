using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalibrator.Data
{
    public class FormData
    {
        #region Member Variables

        private Dictionary<float, float> _mafValues = null;

        private Dictionary<float, float> _wotAFRValues = null;        

        private int? _openLoopAPP = null;
        
        private float? _openLoopLoad = null;        

        #endregion

        #region Public Properties

        public Dictionary<float, float> MafValues
        {
            get { return _mafValues; }
            set { _mafValues = value; }
        }
        public Dictionary<float, float> WotAFRValues
        {
            get { return _wotAFRValues; }
            set { _wotAFRValues = value; }
        }
        public int? OpenLoopAPP
        {
            get { return _openLoopAPP; }
            set { _openLoopAPP = value; }
        }
        public float? OpenLoopLoad
        {
            get { return _openLoopLoad; }
            set { _openLoopLoad = value; }
        }

        #endregion
    }
}
