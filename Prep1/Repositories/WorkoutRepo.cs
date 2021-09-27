using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prep1.Types;

namespace Prep1.Repositories
{
    public class WorkoutRepo
    {
        private readonly List<Workout> Workouts = new List<Workout>
        {
            new Workout
            {
                UserId = 1,
                WorkoutId = 1,
                WorkoutTitle = "workout 1",
                WorkoutIntervals = new List<Interval>
                {
                    new Interval { AvgHeartRate = 123, Distance = 200, TotalTime = TimeSpan.FromMinutes(10) },
                    new Interval { AvgHeartRate = 123, Distance = 200, TotalTime = TimeSpan.FromMinutes(10) },
                    new Interval { AvgHeartRate = 123, Distance = 200, TotalTime = TimeSpan.FromMinutes(10) },
                }
            },
            new Workout
            {
                UserId = 2,
                WorkoutId = 1,
                WorkoutTitle = "workout 2",
                WorkoutIntervals = new List<Interval>
                {
                    new Interval { AvgHeartRate = 123, Distance = 200, TotalTime = TimeSpan.FromMinutes(10) },
                    new Interval { AvgHeartRate = 123, Distance = 200, TotalTime = TimeSpan.FromMinutes(10) },
                    new Interval { AvgHeartRate = 123, Distance = 200, TotalTime = TimeSpan.FromMinutes(10) },
                }
            }
        };

        public List<Workout> GetAllWorkouts()
        {
            return Workouts;
        }

        public Workout GetWorkout(int workoutId)
        {
            return Workouts.Where(x => x.WorkoutId == workoutId).FirstOrDefault();
        }
    }
}
