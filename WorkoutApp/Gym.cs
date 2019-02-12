using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WorkoutApp
{
    static class Gym
    {
        private static List<User> users = new List<User>();
        private static List<Workout> workouts = new List<Workout>();

        public static User AddUser(string username, string emailAddress)
        {
            var user = new User
            {
                Username = username,
                EmailAddress = emailAddress,
            };
            users.Add(user);
            return user;
        }

        public static IEnumerable<User> GetUser(string username)
        {
            return users.Where(user => user.Username == username);

        }

        /// <summary>
        /// add workout database
        /// </summary>
        /// <param name="workoutDate"></param>
        /// <param name="workoutType"></param>
        /// <param name="workoutDuration"></param>
        /// <returns></returns>
        public static Workout AddWorkout(int workoutDuration, DateTime workoutDate,
                TypeOfWorkout workoutType = TypeOfWorkout.Run)
        {
            var workout = new Workout
            {
                WorkoutDate = workoutDate,
                WorkoutType = workoutType,
                WorkoutDuration = workoutDuration,
            };
            workouts.Add(workout);
            return workout;
        }

        public static Workout EditWorkout(int workoutDuration, DateTime workoutDate,
                TypeOfWorkout workoutType = TypeOfWorkout.Run)
        {
            var workout = new Workout
            {
                WorkoutDuration = workoutDuration,
                WorkoutDate = workoutDate, 
                WorkoutType = workoutType,
                
            };
            workouts.Add(workout);
            return workout;
        }
    }
}

