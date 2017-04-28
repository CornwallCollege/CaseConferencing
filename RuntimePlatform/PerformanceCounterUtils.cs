/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Diagnostics;

namespace OutSystems.HubEdition.RuntimePlatform {

    public static class PerformanceCountersUtils {

        private static DateTime lastLogTime;
        private const int logAgainAfter = 5000; //in secs

        public static PerformanceCounter NewCounterLogErrorDelayed(string counterName) {
            PerformanceCounter c = null;
            try {
                c = new PerformanceCounter();
                c.BeginInit();
                c.CategoryName = "OutSystems";
                c.CounterName = counterName;
                c.MachineName = ".";
                c.ReadOnly = false;
                c.EndInit();
            } catch (System.Exception e) {
                System.TimeSpan diff1 = DateTime.Now.Subtract(lastLogTime);
                if (diff1.TotalSeconds > logAgainAfter) {
                    try {
                        if (!EventLog.SourceExists("OutSystems Performance Counters")) {
                            EventLog.CreateEventSource("OutSystems Performance Counters", null);
                        }
                        EventLog.WriteEntry("OutSystems Performance Counters", e.Message, EventLogEntryType.Error);
                        lastLogTime = DateTime.Now;
                    } catch (System.Exception) {
                    }
                }
                c = null;
            }
            return c;
        }

        public static PerformanceCounter NewCounter(string counterName) {
            try {
                PerformanceCounter counter = new PerformanceCounter();
                counter.BeginInit();
                counter.CategoryName = "OutSystems";
                counter.CounterName = counterName;
                counter.MachineName = ".";
                counter.ReadOnly = false;
                counter.EndInit();
                return counter;
            } catch (Exception e) {
                throw new Exception("Unable to setup the performance counter '" + counterName + "': " + e.ToString());
            }
        }
    }
}