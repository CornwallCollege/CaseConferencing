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
	public class RLStudentAttenndance_ListListTypeFactoryImpl: RsseSpaceCornwallCollegeFunct.IRLStudentAttenndance_ListListTypeFactory {
		private static readonly RLStudentAttenndance_ListListTypeFactoryImpl Instance = new RLStudentAttenndance_ListListTypeFactoryImpl();

		private RLStudentAttenndance_ListListTypeFactoryImpl() {}

		public static void InitializeFactory() {
			RsseSpaceCornwallCollegeFunct.Factory.FactoryRLStudentAttenndance_ListListSingleton = Instance;

		}

		public RecordList CreateRsseSpaceCornwallCollegeFunctRLStudentAttenndance_ListList() {
			return new RLStudentAttenndance_ListList();
		}

	}
}