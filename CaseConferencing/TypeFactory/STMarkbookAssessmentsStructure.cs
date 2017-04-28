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
	public class STMarkbookAssessmentsStructureTypeFactoryImpl: RsseSpaceProMonitorConnector.ISTMarkbookAssessmentsStructureTypeFactory {
		private static readonly STMarkbookAssessmentsStructureTypeFactoryImpl Instance = new STMarkbookAssessmentsStructureTypeFactoryImpl();

		private STMarkbookAssessmentsStructureTypeFactoryImpl() {}

		public static void InitializeFactory() {
			RsseSpaceProMonitorConnector.Factory.FactorySTMarkbookAssessmentsStructureSingleton = Instance;

		}

		public IRecord CreateRsseSpaceProMonitorConnectorSTMarkbookAssessmentsStructure() {
			return new STMarkbookAssessmentsStructure(null);
		}

	}
}