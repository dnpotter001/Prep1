using System;
using System.Collections.Generic;

namespace Prep1.Types
{
    public class Workout
    {
        public string WorkoutTitle;
        public int UserId;
        public int WorkoutId;
        public List<Interval> WorkoutIntervals;

        public Interval GetAveragesForWorkout()
        {
            return new Interval { AvgHeartRate = 100, Distance = 100, TotalTime = TimeSpan.FromMinutes(10) };
        }
    }
}
