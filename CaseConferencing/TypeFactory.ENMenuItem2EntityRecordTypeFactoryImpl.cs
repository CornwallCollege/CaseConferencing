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
	public class ENMenuItem2EntityRecordTypeFactoryImpl: RsseSpaceThemeProvider.IENMenuItem2EntityRecordTypeFactory {
		private static readonly ENMenuItem2EntityRecordTypeFactoryImpl Instance = new ENMenuItem2EntityRecordTypeFactoryImpl();

		private ENMenuItem2EntityRecordTypeFactoryImpl() {}

		public static void InitializeFactory() {
			RsseSpaceThemeProvider.Factory.FactoryENMenuItem2EntityRecordSingleton = Instance;
		}

		public IRecord CreateENMenuItem2EntityRecord() {
			return new ENMenuItem2EntityRecord(null);
		}

	}
}