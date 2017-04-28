﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.Processes;
using OutSystems.ObjectKeys;

namespace ssCaseConferencing.Processes {
	public abstract class AbstractProcessActivity: ProcessBase.AbstractProcessActivityBase {

		/// <summary>
		/// Create a new activity instance
		/// The activity representation can be set as not running,
		/// and execution info can be searched in the database if not running
		/// </summary>
		/// <param name="activityId"></param>
		protected AbstractProcessActivity(int processId, int activityId, bool isRunning): base(processId, activityId, isRunning) {}

		private static object activitiesDefinitionLock = new object();
		private static Dictionary<ObjectKey, ProcessBase.CreateActivityDelegate> activitiesDefinition = null;
		private static Dictionary<ObjectKey, ProcessBase.CreateActivityDelegate> ActivitiesDefinition {
			get {
				if (activitiesDefinition == null) {
					lock(activitiesDefinitionLock) {
						if (activitiesDefinition == null) {
							Dictionary<ObjectKey, ProcessBase.CreateActivityDelegate> temp = new Dictionary<ObjectKey, ProcessBase.CreateActivityDelegate>();
							AbstractProcess.FillAllActivitiesDefinitions(temp);
							activitiesDefinition = temp;
						}
					}
				}
				return activitiesDefinition;
			}
		}

		/// <summary>
		/// Used to get a generic activity instance from the base class
		/// </summary>
		protected sealed override bool GetProcessActivityInstance(int processId, int activityId, ObjectKey activityKey, bool isRunning, out IProcessActivity instance) {
			return GetProcessActivityImplementation(processId, activityId, activityKey, isRunning, out instance);
		}

		public static bool GetProcessActivityImplementation(int processId, int activityId, ObjectKey activityKey, bool isRunning, out IProcessActivity instance) {
			ProcessBase.CreateActivityDelegate createInstanceMethod;
			instance = null;

			if (ActivitiesDefinition.TryGetValue(activityKey, out createInstanceMethod)) {
				instance = createInstanceMethod(processId, activityId, isRunning);
				return true;
			}
			return false;
		}

		protected sealed override bool GetDummyProcessActivity(ObjectKey activityKey, out IProcessActivity instance) {
			if (GetProcessActivityImplementation(DummyId, DummyId, activityKey, false, out instance)) {
				return true;
			}
			return false;
		}

		protected override bool GetPrecedentActivity(ObjectKey targetSSKey, out IProcessActivity instance) {
			int prededentActivityId;
			using(Transaction trans = DatabaseAccess.ForSystemDatabase.GetRequestTransaction()) {
				prededentActivityId = DBRuntimePlatform.Instance.GetPrecedentActivityId(trans, ActivityId, ObjectKeyUtils.DatabaseValue(targetSSKey));
			}
			instance = null;

			if (prededentActivityId != 0) {
				return GetProcessActivityImplementation(ProcessId, prededentActivityId, targetSSKey, false, out instance);
			}
			return false;
		}
	}
}