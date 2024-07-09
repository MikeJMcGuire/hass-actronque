using System;
using System.Collections.Generic;
using System.Text;

namespace HMX.HASSActronQue
{
	public class AirConditionerPeripheral
	{
		public int LogicalAddress; // all sensors have a unique logical address - use this for a key?
		public string Serial; // each sensor has a unique serial based on the MAC
		public string Location; // will be filled based on zone assignments
		public bool ZoneSensor; // is it a zone sensor (and therefore has battery)
		public double Temperature; // RemoteTemperatures_oC
		public double Battery; // Battery_pc
		public Dictionary<int, int> ZoneAssignments;
//		public AirConditionerPeripheral(string strLogicalAddress, string strSerial)
		public AirConditionerPeripheral()
		{
//			LogicalAddress = strLogicalAddress;
//			Serial = strSerial;
			ZoneAssignments = new Dictionary<int, int>();
		}
	}
}
