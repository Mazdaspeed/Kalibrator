using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kalibrator.Data.Elements;

namespace Kalibrator.Data
{
    public class LogEntry
    {
        #region Member Variables

        private string _rawData = null;

        private Dictionary<string, string> _unknownDataValues = null;

        #region Elements

        AbsolutePressureElement _absolutePressure = null;
        AFRElement _afr = null;
        APPElement _app = null;
        BoostAirTempElement _boostAirTemp = null;
        BoostElement _boost = null;
        CalculatedLoadElement _calculatedLoad = null;
        CoolantTempElement _coolantTemp = null;
        HPFPElement _hpfp = null;
        InjectorDutyCycleElement _injectorDutyCycle = null;
        IntakeTempElement _intakeTemp = null;
        IntakeValveAdvanceElement _intakeValveAdvance = null;
        KnockRetardElement _knockRetard = null;
        LTFTElement _ltft = null;
        MAFVoltageElement _mafVoltage = null;
        MassAirflowElement _massAirflow = null;
        RPMElement _rpm = null;
        SparkAdvanceElement _sparkAdvance = null;
        STFTElement _stft = null;
        ThrottlePositionElement _throttlePosition = null;
        TimeElement _time = null;
        VehicleSpeedElement _vehicleSpeed = null;
        WGDCElement _wgdc = null;

        #endregion

        #endregion

        #region Constructor

        public LogEntry(string rawData)
        {
            _rawData = rawData;
        }

        #endregion

        #region Public Properties

        public string RawData
        {
            get { return _rawData; }
        }

        public AbsolutePressureElement AbsolutePressure
        {
            get { return _absolutePressure; }
        }
        public AFRElement AFR
        {
            get { return _afr; }
        }
        public APPElement APP
        {
            get { return _app; }
        }
        public BoostAirTempElement BoostAirTemp
        {
            get { return _boostAirTemp; }
        }
        public BoostElement Boost
        {
            get { return _boost; }
        }
        public CalculatedLoadElement CalculatedLoad
        {
            get { return _calculatedLoad; }
        }
        public CoolantTempElement CoolantTemp
        {
            get { return _coolantTemp; }
        }
        public HPFPElement HPFP
        {
            get { return _hpfp; }
        }
        public InjectorDutyCycleElement InjectorDutyCycle
        {
            get { return _injectorDutyCycle; }
        }
        public IntakeTempElement IntakeTemp
        {
            get { return _intakeTemp; }
        }
        public IntakeValveAdvanceElement IntakeValveAdvance
        {
            get { return _intakeValveAdvance; }
        }
        public KnockRetardElement KnockRetard
        {
            get { return _knockRetard; }
        }
        public LTFTElement LTFT
        {
            get { return _ltft; }
        }
        public MAFVoltageElement MAFVoltage
        {
            get { return _mafVoltage; }
        }
        public MassAirflowElement MassAirflow
        {
            get { return _massAirflow; }
        }
        public RPMElement RPM
        {
            get { return _rpm; }
        }
        public SparkAdvanceElement SparkAdvance
        {
            get { return _sparkAdvance; }
        }
        public STFTElement STFT
        {
            get { return _stft; }
        }
        public ThrottlePositionElement ThrottlePosition
        {
            get { return _throttlePosition; }
        }
        public TimeElement Time
        {
            get { return _time; }
        }
        public VehicleSpeedElement VehicleSpeed
        {
            get { return _vehicleSpeed; }
        }
        public WGDCElement WGDC
        {
            get { return _wgdc; }
        }

        #endregion

        #region Parse

        public bool Parse(List<string> firstLineSplit)
        {
            bool result = true;

            try
            {
                _unknownDataValues = new Dictionary<string, string>();
                List<string> splitData = _rawData.Split(',').ToList();

                for (int i = 0; i < splitData.Count; i++)
                {
                    if (firstLineSplit[i] == AbsolutePressureElement.LogPropertyName)
                    {
                        _absolutePressure = AbsolutePressureElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == AFRElement.LogPropertyName)
                    {
                        _afr = AFRElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == APPElement.LogPropertyName)
                    {
                        _app = APPElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == BoostAirTempElement.LogPropertyName)
                    {
                        _boostAirTemp = BoostAirTempElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == BoostElement.LogPropertyName)
                    {
                        _boost = BoostElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == CalculatedLoadElement.LogPropertyName)
                    {
                        _calculatedLoad = CalculatedLoadElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == CoolantTempElement.LogPropertyName)
                    {
                        _coolantTemp = CoolantTempElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == HPFPElement.LogPropertyName)
                    {
                        _hpfp = HPFPElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == InjectorDutyCycleElement.LogPropertyName)
                    {
                        _injectorDutyCycle = InjectorDutyCycleElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == IntakeTempElement.LogPropertyName)
                    {
                        _intakeTemp = IntakeTempElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == IntakeValveAdvanceElement.LogPropertyName)
                    {
                        _intakeValveAdvance = IntakeValveAdvanceElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == KnockRetardElement.LogPropertyName)
                    {
                        _knockRetard = KnockRetardElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == LTFTElement.LogPropertyName)
                    {
                        _ltft = LTFTElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == MAFVoltageElement.LogPropertyName)
                    {
                        _mafVoltage = MAFVoltageElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == MassAirflowElement.LogPropertyName)
                    {
                        _massAirflow = MassAirflowElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == RPMElement.LogPropertyName)
                    {
                        _rpm = RPMElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == SparkAdvanceElement.LogPropertyName)
                    {
                        _sparkAdvance = SparkAdvanceElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == STFTElement.LogPropertyName)
                    {
                        _stft = STFTElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == ThrottlePositionElement.LogPropertyName)
                    {
                        _throttlePosition = ThrottlePositionElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == TimeElement.LogPropertyName)
                    {
                        _time = TimeElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == VehicleSpeedElement.LogPropertyName)
                    {
                        _vehicleSpeed = VehicleSpeedElement.Create(splitData[i]);
                    }
                    else if (firstLineSplit[i] == WGDCElement.LogPropertyName)
                    {
                        _wgdc = WGDCElement.Create(splitData[i]);
                    }
                    else
                    {
                        // Unknown Element Type, add it to our dictionary
                        _unknownDataValues.Add(firstLineSplit[i], splitData[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                result = false;
            }

            // We no longer need the raw data after we parse, do this to save memory
            _rawData = null;

            return result;
        }

        #endregion

    }
}
