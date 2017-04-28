﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace ssCaseConferencing {
	public class STXAxisFormatStructureTypeFactoryImpl: RsseSpaceCharts.ISTXAxisFormatStructureTypeFactory {
		private static readonly STXAxisFormatStructureTypeFactoryImpl Instance = new STXAxisFormatStructureTypeFactoryImpl();

		private STXAxisFormatStructureTypeFactoryImpl() {}

		public static void InitializeFactory() {
			RsseSpaceCharts.Factory.FactorySTXAxisFormatStructureSingleton = Instance;

		}

		public IRecord CreateRsseSpaceChartsSTXAxisFormatStructure() {
			return new STXAxisFormatStructure(null);
		}

	}
}