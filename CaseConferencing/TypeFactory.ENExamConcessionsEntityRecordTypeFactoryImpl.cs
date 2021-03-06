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
	public class ENExamConcessionsEntityRecordTypeFactoryImpl: RsseSpaceCornwallCollegeData.IENExamConcessionsEntityRecordTypeFactory {
		private static readonly ENExamConcessionsEntityRecordTypeFactoryImpl Instance = new ENExamConcessionsEntityRecordTypeFactoryImpl();

		private ENExamConcessionsEntityRecordTypeFactoryImpl() {}

		public static void InitializeFactory() {
			RsseSpaceCornwallCollegeData.Factory.FactoryENExamConcessionsEntityRecordSingleton = Instance;
		}

		public IRecord CreateENExamConcessionsEntityRecord() {
			return new ENExamConcessionsEntityRecord(null);
		}

	}
}