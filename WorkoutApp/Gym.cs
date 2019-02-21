using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WorkoutApp
{
    public static class Gym
    {
        public static GymDb db = new GymDb();

        public static User AddUser(string username, string emailAddress)
        {
            var user = new User
            {
                Username = username,
                EmailAddress = emailAddress,
            };
            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }

        public static IEnumerable<User> GetUser(string username)
        {
            return db.Users.Where(user => user.Username == username);

        }

        /// <summary>
        /// add workout database
        /// </summary>
        /// <param name="workoutDate"></param>
        /// <param name="workoutType"></param>
        /// <param name="workoutDuration"></param>
        /// <returns></returns>
        public static Workout AddWorkout(DateTime workoutDate, int workoutDuration, 
                TypeOfWorkout workoutType = TypeOfWorkout.Run)
        {
            var workout = new Workout
            {
                WorkoutDate = workoutDate,
                WorkoutDuration = workoutDuration,
                WorkoutType = workoutType,
            };
            db.Workouts.Add(workout);
            db.SaveChanges();
            return workout;
        }

        public static Workout EditWorkout(DateTime workoutDate, int workoutDuration, 
                TypeOfWorkout workoutType)
        { 
            var workout = new Workout
            {
                WorkoutDate = workoutDate,
                WorkoutDuration = workoutDuration,
                WorkoutType = workoutType,
            };
            db.Workouts.Add(workout);
            db.SaveChanges();
            return workout;
        }
    }
}

