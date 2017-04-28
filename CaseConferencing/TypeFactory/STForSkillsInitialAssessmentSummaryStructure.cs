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
	public class STForSkillsInitialAssessmentSummaryStructureTypeFactoryImpl: RsseSpaceForSkillsConnector.ISTForSkillsInitialAssessmentSummaryStructureTypeFactory {
		private static readonly STForSkillsInitialAssessmentSummaryStructureTypeFactoryImpl Instance = new STForSkillsInitialAssessmentSummaryStructureTypeFactoryImpl();

		private STForSkillsInitialAssessmentSummaryStructureTypeFactoryImpl() {}

		public static void InitializeFactory() {
			RsseSpaceForSkillsConnector.Factory.FactorySTForSkillsInitialAssessmentSummaryStructureSingleton = Instance;

		}

		public IRecord CreateRsseSpaceForSkillsConnectorSTForSkillsInitialAssessmentSummaryStructure() {
			return new STForSkillsInitialAssessmentSummaryStructure(null);
		}

	}
}