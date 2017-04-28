/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.RuntimePlatform {
	/// <summary>
	/// This interface defines a Timer signature
	/// </summary>
	public interface ISsTimer {
		string Schedule {
			get;
			set;
		}
		DateTime LastRun {
			get;
		}
		DateTime NextRun {
			get;
		}
		void Execute( HeContext heContext);
		void CalculateNextRun( out DateTime nextRun);
	}
	
	enum kind {	Daily, Weekly, DayOfMonth, WeekdayOfMonth }
	enum ssWeekDay { Sun, Mon, Tue, Wed, Thu, Fri, Sat }
	enum ssWeekDayOrder{ _last, _1st, _2nd, _3rd, _4th }
	enum listType { Time, WeekDay, MonthDay	}
    enum scheduleType { TimeOnly, TimeOrdinalWeekday, TimeWeekdays, TimeDays, Invalid}

	public class RuntimeScheduler {

        private static string HOURS_PATTERN = "(2[0-3]|[0-1][0-9]):[0-5][0-9]";
        private static string ORDINALS_PATTERN = "1st|2nd|3rd|4th|last";
        private static string DAYSOFWEEK_PATTERN = "Mon|Tue|Wed|Thu|Fri|Sat|Sun";
        private static string DAYSOFMONTH_PATTERN = "0[1-9]|[12][0-9]|3[01]";

        private static string TrimEndAndEnsureDoubleDigits(string schedule) {
            schedule = schedule.TrimEnd(' ');
            
            schedule = Regex.Replace(schedule, "(^|\\s)([0-9])(:|\\s|$)", "${1}0${2}${3}");

            // #600844 - run twice to account for adjacent single digits (for example, scheduler = "08:00 1 2 3 4")
            
            schedule = Regex.Replace(schedule, "(^|\\s)([0-9])(:|\\s|$)", "${1}0${2}${3}");
            return schedule;
        }

        private static bool IsHour(string input) {
            Match m;
            m = Regex.Match(input, HOURS_PATTERN, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            return m.Success;
        }

        private static bool IsOrdinal(string input) {
            Match m;
            m = Regex.Match(input, ORDINALS_PATTERN, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            return m.Success;
        }

        private static bool IsDayOfWeek(string input) {
            Match m;
            m = Regex.Match(input, DAYSOFWEEK_PATTERN, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            return m.Success;
        }

        private static bool IsDayOfMonth(string input) {
            Match m;
            m = Regex.Match(input, DAYSOFMONTH_PATTERN, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            return m.Success;
        }

        private static void ValidateAndSeparateScheduleParts(string[]scheduleParts, out scheduleType schType, out List<string> hoursInSchedule, out List<string> daysInSchedule,
                                                    out List<string> weekdaysInSchedule, out string ordinalInSchedule) {

            bool foundHours = false;
            bool foundOrdinal = false;
            bool foundMonthDay = false;
            bool foundWeekDay = false;

            hoursInSchedule = new List<string>();
            daysInSchedule = new List<string>();
            weekdaysInSchedule = new List<string>();
            ordinalInSchedule = null;
            schType = scheduleType.Invalid;

            int numParts = scheduleParts.Length;
            for (int i = 0; i < numParts; i++) {

                string currentPart = scheduleParts[i];

                if (IsHour(currentPart)) {
                    if (!foundOrdinal && !foundMonthDay && !foundWeekDay) {
                        foundHours = true;
                        hoursInSchedule.Add(currentPart);
                        schType = scheduleType.TimeOnly;
                        continue;
                    } else {
                        schType = scheduleType.Invalid;
                        break;
                    }
                }

                if (foundHours) {

                    if (IsOrdinal(currentPart)) {
                        if (!foundOrdinal && !foundMonthDay && !foundWeekDay) {
                            foundOrdinal = true;
                            ordinalInSchedule = "_" + currentPart;
                            continue;
                        } else {
                            schType = scheduleType.Invalid;
                            break;
                        }
                    }

                    if (IsDayOfWeek(currentPart)) {

                        if (!foundMonthDay) {
                            weekdaysInSchedule.Add(currentPart);

                            if (foundOrdinal && !foundWeekDay) {
                                schType = scheduleType.TimeOrdinalWeekday;
                            } else if (!foundOrdinal) {
                                schType = scheduleType.TimeWeekdays;
                            } else {
                                schType = scheduleType.Invalid;
                                break;
                            }

                            foundWeekDay = true;
                            continue;
                        } else {
                            schType = scheduleType.Invalid;
                            break;
                        }
                    }

                    if (IsDayOfMonth(currentPart)) {
                        if (!foundOrdinal && !foundWeekDay) {
                            foundMonthDay = true;
                            daysInSchedule.Add(currentPart);
                            schType = scheduleType.TimeDays;
                        } else {
                            schType = scheduleType.Invalid;
                            break;
                        }
                    }
                } else {
                    schType = scheduleType.Invalid;
                    break;
                }
            }
        }

        public static bool ValidateSchedule(string schedule) {
			if( schedule == "")
				return true;

            schedule = TrimEndAndEnsureDoubleDigits(schedule);

            List<string> hoursInSchedule;
            List<string> daysInSchedule;
            List<string> weekdaysInSchedule;
            string ordinalInSchedule;

            string[] scheduleParts = schedule.Split(' ');
            scheduleType schType = scheduleType.Invalid;
            ValidateAndSeparateScheduleParts(scheduleParts, out schType, out hoursInSchedule, out daysInSchedule, out weekdaysInSchedule, out ordinalInSchedule);

            return !schType.Equals(scheduleType.Invalid);
        }

		public static void NextRun( string schedule, DateTime current, DateTime lastRun, out DateTime nextRun) {
            if (schedule.Trim() == "" || schedule.Trim() == Constants.TimerScheduleWhenPublished) {
				nextRun = new DateTime(3000,1,1);
				return;
			}

            schedule = TrimEndAndEnsureDoubleDigits(schedule);

            string[] scheduleParts = schedule.Split(' ');
            scheduleType schType = scheduleType.Invalid;

            List<string> hoursInSchedule;
            List<string> daysInSchedule;
            List<string> weekdaysInSchedule;
            string ordinalInSchedule;
            ValidateAndSeparateScheduleParts(scheduleParts, out schType, out hoursInSchedule, out daysInSchedule, out weekdaysInSchedule, out ordinalInSchedule);

            TimeSpan ts = new TimeSpan( 0, 0, 0, 0);
            switch(schType) {
                case scheduleType.TimeOnly:
                    // daily at the same hours
                    CalculateNextTimeSpan(current, hoursInSchedule.ToArray(), out ts);
                    break;
                case scheduleType.TimeDays:
                    // on those days of the month at those hours
                    CalculateNextDayOfMonthSpan(current, hoursInSchedule.ToArray(), daysInSchedule.ToArray(), out ts);
                    break;
                case scheduleType.TimeOrdinalWeekday:
                    // on the nth weekday of the month
                    CalculateNextWeekdayOfMonthSpan(current, hoursInSchedule.ToArray(), ordinalInSchedule, weekdaysInSchedule[0], out nextRun);
                    return;
                case scheduleType.TimeWeekdays:
                    // on those days of the week at those hours
                    CalculateNextWeekDaySpan(current, hoursInSchedule.ToArray(), weekdaysInSchedule.ToArray(), out ts);
                    break;
            }

            if (!schType.Equals(scheduleType.Invalid)) {
                nextRun = current.Add(ts);
            } else {
                nextRun = new DateTime(3000, 1, 1);
            }
		}

		private static void CalculateNextTimeSpan(DateTime current, string[] occurencesFromSchedule, out TimeSpan timeSpan) {
            
            string[] occurences = SortList(occurencesFromSchedule, listType.Time);
			TimeSpan nextTs;
			TimeSpan currentTs = new TimeSpan( current.Hour, current.Minute, current.Second);
			bool firstTime = true;
			TimeSpan firstTs = new TimeSpan( 0, 0, 0, 0);
			foreach( string time in occurences) {
				nextTs = TimeSpan.Parse( time + ":00");
				if( firstTime) {
					firstTs = nextTs;
					firstTime = false;
				}
				if( nextTs.CompareTo( currentTs) > 0) {
					timeSpan = nextTs.Subtract( currentTs);
					return;
				}
			}
			timeSpan = new TimeSpan( 1, 0, 0, 0).Subtract( currentTs).Add( firstTs);
		}

		private static void CalculateNextWeekDaySpan( 
			DateTime current,
            string[] timeOccurencesFromSchedule,
            string[] wdOccurencesFromSchedule,
			out TimeSpan timeSpan) {
            string[] timeOccurences = SortList(timeOccurencesFromSchedule, listType.Time);
            string[] wdOccurences = SortList(wdOccurencesFromSchedule, listType.WeekDay);

			TimeSpan nextTs;
			TimeSpan currentTs = new TimeSpan(  (int) current.DayOfWeek, current.Hour, current.Minute, current.Second);
			bool firstTime = true;
			TimeSpan firstTs = new TimeSpan( 0, 0, 0, 0);
			foreach( string weekDay in wdOccurences) {
				foreach( string time in timeOccurences) {
					nextTs = new TimeSpan( (int) Enum.Parse( typeof( ssWeekDay), weekDay, true), 0, 0, 0).Add( TimeSpan.Parse( time + ":00"));
					if( firstTime) {
						firstTs = nextTs;
						firstTime = false;
					}
					if( nextTs.CompareTo( currentTs) > 0) {
						timeSpan = nextTs.Subtract( currentTs);
						return;
					}
				}
			}
			timeSpan = new TimeSpan( 7, 0, 0, 0).Subtract( currentTs).Add( firstTs);
		}

		private static void CalculateNextDayOfMonthSpan(
			DateTime current,
            string[] timeOccurencesFromSchedule,
            string[] dayOccurencesFromSchedule,
			out TimeSpan timeSpan) {

            string[] timeOccurences = SortList(timeOccurencesFromSchedule, listType.Time);
            string[] dayOccurences = SortList(dayOccurencesFromSchedule, listType.MonthDay);

			TimeSpan nextTs;
			TimeSpan currentTs = new TimeSpan(  current.Day, current.Hour, current.Minute, current.Second);
			bool firstTime = true;
			TimeSpan firstTs = new TimeSpan( 0, 0, 0, 0);
			int daysInMonth;
			foreach( string day in dayOccurences) {
				foreach( string time in timeOccurences) {
					nextTs = new TimeSpan( Int32.Parse( day), 0, 0, 0).Add( TimeSpan.Parse( time + ":00"));
					if( firstTime) {
						firstTs = nextTs;
						firstTime = false;
					}
					if( nextTs.CompareTo( currentTs) > 0) {
						daysInMonth = DateTime.DaysInMonth( current.Year, current.Month);
						if( Int32.Parse( day) <= daysInMonth) {
							timeSpan = nextTs.Subtract( currentTs);
							return;
						}
					}
				}
			}
			int datePeriod = 0;
			for( DateTime aux = current.AddMonths( 1);; aux = aux.AddMonths( 1)) {
				daysInMonth = DateTime.DaysInMonth( aux.Year, aux.Month);
				if( daysInMonth < firstTs.Days)
					datePeriod += daysInMonth;
				else
					break;
			}
            timeSpan = new TimeSpan( DateTime.DaysInMonth( current.Year, current.Month), 0, 0, 0).Subtract( currentTs).Add( firstTs).Add( new TimeSpan( datePeriod, 0, 0, 0));
		}

		private static void CalculateNextWeekdayOfMonthSpan(
			DateTime current,
            string[] timeOcurrencesFromSchedule,
            string ordinal,
            string wkDay,
			out DateTime nextRun) {

            string[] timeOccurences = SortList(timeOcurrencesFromSchedule, listType.Time);

			ssWeekDayOrder order = ( ssWeekDayOrder) Enum.Parse( typeof( ssWeekDayOrder), ordinal, true);
			ssWeekDay weekDay = ( ssWeekDay) Enum.Parse( typeof( ssWeekDay), wkDay, true);

			Hashtable map = new Hashtable();
			int dayOfWeek, occurrenceCount;
			DateTime dt;
			// map all dates for each week day occurrence of the month
			for( dt = new DateTime( current.Year, current.Month, 1), occurrenceCount = 0 ; 
				dt.Month == current.Month; 
				dt = dt.AddDays( 1)) {
				dayOfWeek = ( int) dt.DayOfWeek;
				if( ( int) weekDay == ( int) dayOfWeek) {
					map.Add( ++occurrenceCount, dt);
				}
			}
			if( order != ssWeekDayOrder._last)
				occurrenceCount = ( int) order;
			dt = ( DateTime) map[ occurrenceCount];
			if( dt.Day > current.Day) {
				// future date, add first time occurence
				nextRun = dt.Add( TimeSpan.Parse( timeOccurences[0] + ":00"));
				return;
			}
			if( dt.Day == current.Day) {
				// same day, find correct time slot
				TimeSpan nextTs;
				TimeSpan currentTs = new TimeSpan( current.Hour, current.Minute, current.Second);
				foreach( string time in timeOccurences) {
					nextTs = TimeSpan.Parse( time + ":00");
					if( nextTs.CompareTo( currentTs) > 0) {
						nextRun = dt.Add( nextTs);
						return;
					}
				}
			}
			// past date, find date for the next month
			map.Clear();
			for( dt = new DateTime( current.Month == 12 ? current.Year + 1 : current.Year, current.Month == 12 ? 1 :current.Month + 1, 1), occurrenceCount = 0 ; 
				dt.Month == ( current.Month == 12 ? 1 :current.Month + 1); 
				dt = dt.AddDays( 1)) {
				dayOfWeek = ( int) dt.DayOfWeek;
				if( ( int) weekDay == ( int) dayOfWeek) {
					map.Add( ++occurrenceCount, dt);
				}
			}
			if( order != ssWeekDayOrder._last)
				occurrenceCount = ( int) order;
			dt = ( DateTime) map[ occurrenceCount];
			nextRun = dt.Add( TimeSpan.Parse( timeOccurences[0] + ":00"));
		}

        private static string[] SortList(string []ocurrences, listType type){
            SortedList sl = new SortedList();

            foreach (string elm in ocurrences) {
                switch (type) {
                    case listType.MonthDay:
                        if (!sl.ContainsKey(Int32.Parse(elm)) && elm != "") {
                            sl.Add(Int32.Parse(elm), elm);
                        }
					    break;
                    case listType.Time:
                        if (!sl.ContainsKey(elm) && elm != "") {
                            sl.Add(elm, elm);
                        }
                        break;
                    case listType.WeekDay:
                        int wDay = (int)Enum.Parse(typeof(ssWeekDay), elm, true);
                        if (elm != "" && !sl.ContainsKey(wDay)) {
                            sl.Add((int)wDay, elm);
                        }
					    break;
                }
            }
            int index = 0;
            string [] result = new string[sl.Count];
            foreach (string elm in sl.Values) {
                result[index++] = elm;
            }
            return result;
        }
	}
}